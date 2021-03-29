using System;
using System.ComponentModel;
using System.Windows.Forms;
using Unitronics.ComDriver;
using Unitronics.ComDriver.Messages.DataRequest;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.IO.Ports;


namespace Com_Drive_Net___Example

{
    public partial class Form1 : Form
    {
        PLC plc;
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        List<Task> task = new List<Task>();//lista zadań
        CancellationTokenSource cancelSource;//anulowanie zadania
        volatile int count = 0;
        public static Queue<List<string>> plot = new Queue<List<string>>();
        public static List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Type of variable";
            dataGridView1.Columns[1].Name = "Address";
            dataGridView1.Columns[2].Name = "Value";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            Port.Enabled = false;
            Baud.Enabled = false;
            Retries.Enabled = false;
            time.Enabled = false;
            par.Enabled = false;
            data.Enabled = false;
            StopBits.Enabled = false;
            Portip.Enabled = false;
            Ipip.Enabled = false;
            Retriesip.Enabled = false;
            Timout.Enabled = false;
            Plot.Enabled = false;

            Delay_time.Text = "1000";
            File_name.Text = "Data.txt";
            setButtonsEnableState(false);

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Port.Items.Add(port);
            }
        }

        private void setButtonsEnableState(bool value)
        {
            Connect.Enabled = !value;
            Reset.Enabled = value;
            Init.Enabled = value;
            Stop.Enabled = value;
            Run.Enabled = value;
            Disconnect.Enabled = value;
            Read.Enabled = value;
            Write.Enabled = value;
            Run_cont.Enabled = value;
            Stop_cont.Enabled = value;

        }
        public async void Mod(CancellationToken cancellationToken)//obsługa trybu debug mode
        {
            while (!cancelSource.Token.IsCancellationRequested)//jeżeli nie anulowano zadania
            {
                Read_Data();
                await (Task.Delay(Convert.ToInt32(Delay_time.Text)));

            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                try
                {

                    SerialPortNames port = (SerialPortNames)Enum.Parse(typeof(SerialPortNames), Port.Text, true);
                    BaudRate baud = (BaudRate)Enum.Parse(typeof(BaudRate), "BR" + Baud.Text, true);
                    Unitronics.ComDriver.DataBits DataBits = (Unitronics.ComDriver.DataBits)Enum.Parse(typeof(Unitronics.ComDriver.DataBits), "DB" + data.Text, true);
                    System.IO.Ports.Parity Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), par.Text, true);
                    System.IO.Ports.StopBits stopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), StopBits.Text, true);
                    Serial serial = new Serial(port, baud, Convert.ToInt16(Retries.Text), Convert.ToInt16(data.Text) * 1000, DataBits, Parity, stopBits);

                    try
                    {
                        plc = PLCFactory.GetPLC(serial, 0);
                        plc.EventAbortCompleted += new PLC.AbortCompletedDelegate(plc_EventAbortCompleted);
                        setButtonsEnableState(true);
                        PlcVersion version = plc.Version;
                        txtModel.Text = version.OPLCModel;
                        txtHW.Text = version.HWVersion;
                        txtOS.Text = version.OSVersion;
                        txtBoot.Text = version.Boot;
                        txtBinLib.Text = version.BinLib;
                        txtFactoryBoot.Text = version.FactoryBoot;
                        try
                        {
                            txtPlcName.Text = plc.PlcName;
                        }
                        catch
                        {
                        }
                    }
                    catch
                    {
                        setButtonsEnableState(false);
                        serial.Disconnect();
                        System.Windows.Forms.MessageBox.Show("Could not establish a connection to the PLC");
                    }
                }
                catch
                {
                    setButtonsEnableState(false);
                    System.Windows.Forms.MessageBox.Show("Could not establish a connection to the PLC");
                }

            }


            if (checkBox2.Checked == true)
            {
                Ethernet ethernet = new Ethernet(Ipip.Text, Convert.ToInt16(Portip.Text), EthProtocol.TCP, Convert.ToInt16(Retriesip.Text), Convert.ToInt16(Timout.Text));

                try
                {
                    plc = PLCFactory.GetPLC(ethernet, 0);
                    plc.EventAbortCompleted += new PLC.AbortCompletedDelegate(plc_EventAbortCompleted);
                    setButtonsEnableState(true);
                    PlcVersion version = plc.Version;
                    txtModel.Text = version.OPLCModel;
                    txtHW.Text = version.HWVersion;
                    txtOS.Text = version.OSVersion;
                    txtBoot.Text = version.Boot;
                    txtBinLib.Text = version.BinLib;
                    txtFactoryBoot.Text = version.FactoryBoot;
                    try
                    {
                        txtPlcName.Text = plc.PlcName;
                    }
                    catch
                    {
                    }
                }
                catch
                {
                    setButtonsEnableState(false);
                    ethernet.Disconnect();
                    System.Windows.Forms.MessageBox.Show("Could not establish a connection to the PLC");
                }
            }

            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Wybierz typ komunikacji !!!");
            }

        }

        void plc_EventAbortCompleted()
        {
            MethodInvoker mi = delegate ()
            {

                System.Windows.Forms.MessageBox.Show("Requests abort completed");
            };
            UpdateUI(mi);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Reset();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }
        }

        private void Init_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Init();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Stop();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Run();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            plc.Disconnect();
            plc.EventAbortCompleted -= new PLC.AbortCompletedDelegate(plc_EventAbortCompleted);
            setButtonsEnableState(false);
            txtModel.Text = "";
            txtHW.Text = "";
            txtOS.Text = "";
            txtBoot.Text = "";
            txtBinLib.Text = "";
            txtFactoryBoot.Text = "";
            txtPlcName.Text = "";
        }

        private void Read_Click(object sender, EventArgs e)
        {

            Read_Data();

        }



        private void Write_Click(object sender, EventArgs e)
        {
            ReadWriteRequest[] rw1 = new ReadWriteRequest[dataGridView1.SelectedRows.Count];
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)//wykonaj dla wszystkich wierszy w tabeli
            {
                try
                {
                    OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), row.Cells[0].Value.ToString(), true);
                    object[] values = new object[dataGridView1.SelectedRows.Count];
                    values[count] = (object)Convert.ToInt32(row.Cells[2].Value.ToString());

                    rw1[count] = new WriteOperands()
                    {
                        OperandType = OperandTyp,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(row.Cells[1].Value.ToString())),
                        Values = values,
                    };
                    count++;
                }
                catch { }
            }

            try
            {
                plc.ReadWrite(ref rw1);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }



        }

        private void UpdateUI(MethodInvoker del)
        {
            if (this.InvokeRequired)
                this.Invoke(del);
            else
                del();
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Port.Enabled = true;
                Baud.Enabled = true;
                Retries.Enabled = true;
                time.Enabled = true;
                par.Enabled = true;
                data.Enabled = true;
                StopBits.Enabled = true;
                checkBox2.Enabled = false;

            }

            if (checkBox1.Checked == false)
            {
                Port.Enabled = false;
                Baud.Enabled = false;
                Retries.Enabled = false;
                time.Enabled = false;
                par.Enabled = false;
                data.Enabled = false;
                StopBits.Enabled = false;
                checkBox2.Enabled = true;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Portip.Enabled = true;
                Ipip.Enabled = true;
                Retriesip.Enabled = true;
                Timout.Enabled = true;
                checkBox1.Enabled = false;

            }

            if (checkBox2.Checked == false)
            {
                Portip.Enabled = false;
                Ipip.Enabled = false;
                Retriesip.Enabled = false;
                Timout.Enabled = false;
                checkBox1.Enabled = true;
            }

        }




        public void Run_cont_Click(object sender, EventArgs e)
        {
           
            AddVariable.Enabled = false;
            count = 0;
            cancelSource = new CancellationTokenSource();
            Task t = Task.Run(() => Mod(cancelSource.Token));
            task.Add(t);
            Plot.Enabled = true;
        } 

        private void Read_Data()/// odczyt danych
        {
            ReadWriteRequest[] rw = new ReadWriteRequest[dataGridView1.RowCount];
            string myvalue = "";
            string time = DateTime.Now.ToString("HH:mm:ss:FFF");
            string myvalue2 = time+";";
            CurrentTime.Invoke((MethodInvoker)delegate
            {
                CurrentTime.Text = time;
            });
            foreach (DataGridViewRow row in dataGridView1.Rows)//wykonaj dla wszystkich wierszy w tabeli
            {
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), row.Cells[0].Value.ToString(), true);
                rw[row.Index] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(row.Cells[1].Value.ToString())),
                };
            }
            try
            {
                plc.ReadWrite(ref rw);
                if (count==0)
                {
                    myvalue = "Time;";
                }
                list.Clear();
                for (int i = 0; i < rw.Length; i++)
                {
                    List<string> list1 = new List<string>();
                    object[] values = (object[])(rw[i].ResponseValues);
                    if (count==0)
                    {
                        myvalue += dataGridView1.Rows[i].Cells[0].Value.ToString() + dataGridView1.Rows[i].Cells[1].Value.ToString() + ";";
                    }
                   
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (values[j] != null)
                        {

                            dataGridView1.Rows[i].Cells[2].Value = values[j].ToString();
                            myvalue2 += values[j].ToString()+";";
                            list.Add(values[j].ToString());
                        }
                    }
                

                }
                plot.Enqueue(list);
                if (count==0)
                {
                    myvalue += "\n";
                }
                using (System.IO.StreamWriter file =
                                           new System.IO.StreamWriter(File_name.Text, true))//zapis danych do pliku
                {
                    file.WriteLine(myvalue+myvalue2);
                    count++;   
                }

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
            }
        }

        private void Stop_cont_Click_1(object sender, EventArgs e)
        {
            cancelSource.Cancel();
            task.Clear();
            AddVariable.Enabled = true;
            Plot.Enabled = false;
        }



        public void Plot_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2(this);
            Form2.Show();
        }

        private void AddVariable_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3(this);
            Form3.Show();

        }
    }
}
