using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Unitronics.ComDriver;
using Unitronics.ComDriver.Messages.DataRequest;
using System.IO;

namespace Com_Drive_Net___Example

{
    public partial class Form1 : Form
    {
        PLC plc;
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private BackgroundWorker _worker = null;// inicjalizacja obiektu do wielowątkowości
        bool state = false;
        String[] val = new string[5];

        public static int[] plotdata = new int[50];
        public static int[] plotdata2 = new int[50];
        public static int[] plotdata3 = new int[50];
        public static int[] plotdata4 = new int[50];
        public static int[] plotdata5 = new int[50];

        string var1;
        string var2;
        string var3;
        string var4;
        string var5;

        string var11;
        string var21;
        string var31;
        string var41;
        string var51;
        
        public static int delay;
        string name = "";
        public Form1()
        {
            InitializeComponent();


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

            txt0.Enabled = false;
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txtMI0.Enabled = false;
            txtMI1.Enabled = false;
            txtMI2.Enabled = false;
            txtMI3.Enabled = false;
            txtMI4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            Delay_time.Text = "1000";
            File_name.Text = "Data.txt";
            setButtonsEnableState(false);
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
            Plot.Enabled = value;

        }

        private void Connect_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
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

            if (checkBox1.Checked == false && checkBox2.Checked == false) {
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

            if (Var1.Checked == true)
            {

                ReadWriteRequest[] rw = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox1.Text, true);

                rw[0] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt0.Text)),
                };

                try
                {
                    plc.ReadWrite(ref rw);

                    object[] values = (object[])(rw[0].ResponseValues);

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != null)
                        {
                            txtMI0.Text = ((short)values[i]).ToString();
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var2.Checked == true)
            {

                ReadWriteRequest[] rw2 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox2.Text, true);

                rw2[0] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt1.Text)),
                };

                try
                {
                    plc.ReadWrite(ref rw2);

                    object[] values = (object[])(rw2[0].ResponseValues);

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != null)
                        {
                            txtMI1.Text = ((short)values[i]).ToString();
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var3.Checked == true)
            {

                ReadWriteRequest[] rw3 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox3.Text, true);

                rw3[0] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt2.Text)),
                };

                try
                {
                    plc.ReadWrite(ref rw3);

                    object[] values = (object[])(rw3[0].ResponseValues);

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != null)
                        {
                            txtMI2.Text = ((short)values[i]).ToString();
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var4.Checked == true)
            {

                ReadWriteRequest[] rw4 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox4.Text, true);

                rw4[0] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt3.Text)),
                };

                try
                {
                    plc.ReadWrite(ref rw4);

                    object[] values = (object[])(rw4[0].ResponseValues);

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != null)
                        {
                            txtMI3.Text = ((short)values[i]).ToString();
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var5.Checked == true)
            {

                ReadWriteRequest[] rw5 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox5.Text, true);

                rw5[0] = new ReadOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt4.Text)),
                };

                try
                {
                    plc.ReadWrite(ref rw5);

                    object[] values = (object[])(rw5[0].ResponseValues);

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != null)
                        {
                            txtMI4.Text = ((short)values[i]).ToString();
                        }
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }


        }

        private void Write_Click(object sender, EventArgs e)
        {
            if (Var1.Checked == true)
            {

                ReadWriteRequest[] rw1 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox1.Text, true);
                object[] values = new object[1];
                values[0] = (object)Convert.ToInt16(txtMI0.Text);
                rw1[0] = new WriteOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt0.Text)),
                    Values = values,
                };

                try
                {
                    plc.ReadWrite(ref rw1);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var2.Checked == true)
            {

                ReadWriteRequest[] rw2 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox2.Text, true);
                object[] values = new object[1];
                values[0] = (object)Convert.ToInt16(txtMI1.Text);
                rw2[0] = new WriteOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt1.Text)),
                    Values = values,
                };

                try
                {
                    plc.ReadWrite(ref rw2);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var3.Checked == true)
            {

                ReadWriteRequest[] rw3 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox3.Text, true);
                object[] values = new object[1];
                values[0] = (object)Convert.ToInt16(txtMI2.Text);
                rw3[0] = new WriteOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt2.Text)),
                    Values = values,
                };

                try
                {
                    plc.ReadWrite(ref rw3);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }

            if (Var4.Checked == true)
            {

                ReadWriteRequest[] rw4 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox4.Text, true);
                object[] values = new object[1];
                values[0] = (object)Convert.ToInt16(txtMI3.Text);
                rw4[0] = new WriteOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt3.Text)),
                    Values = values,
                };

                try
                {
                    plc.ReadWrite(ref rw4);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
            }


            if (Var5.Checked == true)
            {

                ReadWriteRequest[] rw5 = new ReadWriteRequest[1];
                OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), comboBox1.Text, true);
                object[] values = new object[1];
                values[0] = (object)Convert.ToInt16(txtMI4.Text);
                rw5[0] = new WriteOperands()
                {
                    OperandType = OperandTyp,
                    NumberOfOperands = 1,
                    StartAddress = ((ushort)Convert.ToInt32(txt0.Text)),
                    Values = values,
                };

                try
                {
                    plc.ReadWrite(ref rw5);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                }
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
            if (checkBox1.Checked == true) {
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

        private void Var1_CheckedChanged(object sender, EventArgs e)
        {
            if (Var1.Checked == true)
            {
                comboBox1.Enabled = true;
                txt0.Enabled = true;
                txtMI0.Enabled = true;

            }

            if (Var1.Checked == false)
            {
                comboBox1.Enabled = false;
                txt0.Enabled = false;
                txtMI0.Enabled = false;
            }

        }

        private void Var2_CheckedChanged(object sender, EventArgs e)
        {
            if (Var2.Checked == true)
            {
                comboBox2.Enabled = true;
                txt1.Enabled = true;
                txtMI1.Enabled = true;

            }

            if (Var2.Checked == false)
            {
                comboBox2.Enabled = false;
                txt1.Enabled = false;
                txtMI1.Enabled = false;
            }
        }

        private void Var3_CheckedChanged(object sender, EventArgs e)
        {
            if (Var3.Checked == true)
            {
                comboBox3.Enabled = true;
                txt2.Enabled = true;
                txtMI2.Enabled = true;

            }

            if (Var3.Checked == false)
            {
                comboBox3.Enabled = false;
                txt2.Enabled = false;
                txtMI2.Enabled = false;
            }
        }

        private void Var4_CheckedChanged(object sender, EventArgs e)
        {
            if (Var4.Checked == true)
            {
                comboBox4.Enabled = true;
                txt3.Enabled = true;
                txtMI3.Enabled = true;

            }

            if (Var4.Checked == false)
            {
                comboBox4.Enabled = false;
                txt3.Enabled = false;
                txtMI3.Enabled = false;
            }

        }

        private void Var5_CheckedChanged(object sender, EventArgs e)
        {
            if (Var5.Checked == true)
            {
                comboBox5.Enabled = true;
                txt4.Enabled = true;
                txtMI4.Enabled = true;

            }

            if (Var5.Checked == false)
            {
                comboBox5.Enabled = false;
                txt4.Enabled = false;
                txtMI4.Enabled = false;
            }
        }

        private void Run_cont_Click(object sender, EventArgs e)
        {
            _worker = new BackgroundWorker();// inicjalizacja wielowątkowości
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += new DoWorkEventHandler(Read_Data);// odczyt danych  w pętli
            _worker.ProgressChanged += new ProgressChangedEventHandler(Print_Data);//wyświetlanie danych w pętli po odczycie danych
            state = true;
            var1 = comboBox1.Text;
            var2 = comboBox2.Text;
            var3 = comboBox3.Text;
            var4 = comboBox4.Text;
            var5 = comboBox5.Text;

            var11 = txt0.Text;
            var21 = txt1.Text;
            var31 = txt2.Text;
            var41 = txt3.Text;
            var51 = txt4.Text;

            for (int i = 0; i < plotdata.Length; i++)
            {
                plotdata[i] = Int32.MinValue;
                plotdata2[i] = Int32.MinValue;
                plotdata3[i] = Int32.MinValue;
                plotdata4[i] = Int32.MinValue;
                plotdata5[i] = Int32.MinValue;
            }

            name = File_name.Text;
            delay = Convert.ToInt16(Delay_time.Text);
            _worker.RunWorkerAsync();  //uruchomienie wielowątkowości 


        }

        private void Read_Data(object sender, DoWorkEventArgs e)/// odczyt danych
        {
            int count = 0;
            string header = "";
            string data = "";
            DateTime thisDay = DateTime.Today;
            header = "Time;" + var1 + var11 + ";" + var2 + var21 + ";" + var3 + var31 + ";" + var4 + var41 + ";" + var5 + var51;
            using (System.IO.StreamWriter file =
                             new System.IO.StreamWriter(name, true))//zapis danych do pliku
            {
                file.WriteLine(header);
            }
            while (state == true)
            {
                if (count == 49) {
                    for (int i = 0; i <plotdata.Length; i++)
                    {
                        plotdata[i] = Int32.MinValue;
                        plotdata2[i] = Int32.MinValue;
                        plotdata3[i] = Int32.MinValue;
                        plotdata4[i] = Int32.MinValue;
                        plotdata5[i] = Int32.MinValue;
                    }
                    count = 0;
                }
                data = "";
                data += DateTime.Now.ToString("HH:mm:ss:FFF") + ";";
                if (Var1.Checked == true)
                {

                    ReadWriteRequest[] rw = new ReadWriteRequest[1];
                    OperandTypes OperandTyp1 = (OperandTypes)Enum.Parse(typeof(OperandTypes), var1, true);

                    rw[0] = new ReadOperands()
                    {
                        OperandType = OperandTyp1,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(txt0.Text)),
                    };

                    try
                    {
                        plc.ReadWrite(ref rw);

                        object[] values = (object[])(rw[0].ResponseValues);

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != null)
                            {
                                val[0] = ((short)values[i]).ToString();
                                data += val[0] + ";";
                                plotdata[count]=Convert.ToInt32(((short)values[i]));
                            }
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                    }
                }

                if (Var2.Checked == true)
                {

                    ReadWriteRequest[] rw2 = new ReadWriteRequest[1];
                    OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), var2, true);

                    rw2[0] = new ReadOperands()
                    {
                        OperandType = OperandTyp,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(txt1.Text)),
                    };

                    try
                    {
                        plc.ReadWrite(ref rw2);

                        object[] values = (object[])(rw2[0].ResponseValues);

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != null)
                            {
                                val[1] = ((short)values[i]).ToString();
                                data += val[1] + ";";
                                plotdata2[count] = Convert.ToInt32(((short)values[i]));
                            }
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                    }
                }

                if (Var3.Checked == true)
                {

                    ReadWriteRequest[] rw3 = new ReadWriteRequest[1];
                    OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), var3, true);

                    rw3[0] = new ReadOperands()
                    {
                        OperandType = OperandTyp,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(txt2.Text)),
                    };

                    try
                    {
                        plc.ReadWrite(ref rw3);

                        object[] values = (object[])(rw3[0].ResponseValues);

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != null)
                            {
                                val[2] = ((short)values[i]).ToString();
                                data += val[2] + ";";
                                plotdata3[count] = Convert.ToInt32(((short)values[i]));
                            }
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                    }
                }

                if (Var4.Checked == true)
                {

                    ReadWriteRequest[] rw4 = new ReadWriteRequest[1];
                    OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), var4, true);

                    rw4[0] = new ReadOperands()
                    {
                        OperandType = OperandTyp,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(txt3.Text)),
                    };

                    try
                    {
                        plc.ReadWrite(ref rw4);

                        object[] values = (object[])(rw4[0].ResponseValues);

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != null)
                            {
                                val[3] = ((short)values[i]).ToString();
                                data += val[3] + ";";
                                plotdata4[count] = Convert.ToInt32(((short)values[i]));
                            }
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                    }
                }

                if (Var5.Checked == true)
                {

                    ReadWriteRequest[] rw5 = new ReadWriteRequest[1];
                    OperandTypes OperandTyp = (OperandTypes)Enum.Parse(typeof(OperandTypes), var5, true);

                    rw5[0] = new ReadOperands()
                    {
                        OperandType = OperandTyp,
                        NumberOfOperands = 1,
                        StartAddress = ((ushort)Convert.ToInt32(txt4.Text)),
                    };

                    try
                    {
                        plc.ReadWrite(ref rw5);

                        object[] values = (object[])(rw5[0].ResponseValues);

                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] != null)
                            {
                                val[4] = ((short)values[i]).ToString();
                                data += val[4] + ";";
                                plotdata5[count] = Convert.ToInt32(((short)values[i]));
                            }
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC");
                    }
                }

                using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(name, true))//zapis danych do pliku
                {
                    file.WriteLine(data);
                }
                count = count + 1;
                _worker.ReportProgress(1);
                System.Threading.Thread.Sleep(delay);
            }

        }

        private void Stop_cont_Click_1(object sender, EventArgs e)
        {
            _worker.CancelAsync();
            state = false;
            for (int i = 0; i < plotdata.Length; i++)
            {
                plotdata[i] = Int32.MinValue;
                plotdata2[i] = Int32.MinValue;
                plotdata3[i] = Int32.MinValue;
                plotdata4[i] = Int32.MinValue;
                plotdata5[i] = Int32.MinValue;
            }


        }

        private void Print_Data(object sender, ProgressChangedEventArgs e)
        { // wyświetlanie danych na wyświetlaczach

            for (int i = 0; i < val.Length; i++)/// wyświetlanie temperatur na wyświetlaczu
            {
                TextBox txtbox1 = this.groupBox1.Controls["txtMI" + i.ToString()] as TextBox;
                txtbox1.Text = val[i];
            }


        }

        public void Plot_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        } 
    }
}
