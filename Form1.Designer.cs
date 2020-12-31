namespace Com_Drive_Net___Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Init = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.plcInformation = new System.Windows.Forms.GroupBox();
            this.txtPlcName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtFactoryBoot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBinLib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.TextBox();
            this.AddVariable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Plot = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.File_name = new System.Windows.Forms.TextBox();
            this.Delay_time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Stop_cont = new System.Windows.Forms.Button();
            this.Run_cont = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Retries = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.ComboBox();
            this.Ret = new System.Windows.Forms.Label();
            this.Timeout = new System.Windows.Forms.Label();
            this.DataBits = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.ComboBox();
            this.par = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Portip = new System.Windows.Forms.TextBox();
            this.Ipip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timeoutip = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Timout = new System.Windows.Forms.ComboBox();
            this.Retriesip = new System.Windows.Forms.ComboBox();
            this.plcInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(113, 22);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect to PLC";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 40);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(113, 22);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset PLC";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(12, 68);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(113, 22);
            this.Init.TabIndex = 2;
            this.Init.Text = "Init PLC";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 96);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(113, 22);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop PLC";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(12, 124);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(113, 22);
            this.Run.TabIndex = 4;
            this.Run.Text = "Run PLC";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(12, 152);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(113, 22);
            this.Disconnect.TabIndex = 5;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // plcInformation
            // 
            this.plcInformation.Controls.Add(this.txtPlcName);
            this.plcInformation.Controls.Add(this.label7);
            this.plcInformation.Controls.Add(this.txtModel);
            this.plcInformation.Controls.Add(this.txtFactoryBoot);
            this.plcInformation.Controls.Add(this.label6);
            this.plcInformation.Controls.Add(this.txtBinLib);
            this.plcInformation.Controls.Add(this.label5);
            this.plcInformation.Controls.Add(this.txtBoot);
            this.plcInformation.Controls.Add(this.label4);
            this.plcInformation.Controls.Add(this.txtOS);
            this.plcInformation.Controls.Add(this.label3);
            this.plcInformation.Controls.Add(this.txtHW);
            this.plcInformation.Controls.Add(this.label2);
            this.plcInformation.Controls.Add(this.label1);
            this.plcInformation.Location = new System.Drawing.Point(540, 12);
            this.plcInformation.Name = "plcInformation";
            this.plcInformation.Size = new System.Drawing.Size(246, 197);
            this.plcInformation.TabIndex = 18;
            this.plcInformation.TabStop = false;
            this.plcInformation.Text = "PLC Information";
            // 
            // txtPlcName
            // 
            this.txtPlcName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlcName.Location = new System.Drawing.Point(88, 170);
            this.txtPlcName.Name = "txtPlcName";
            this.txtPlcName.ReadOnly = true;
            this.txtPlcName.Size = new System.Drawing.Size(152, 20);
            this.txtPlcName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "PLC Name";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.Location = new System.Drawing.Point(88, 15);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(152, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtFactoryBoot
            // 
            this.txtFactoryBoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtFactoryBoot.Location = new System.Drawing.Point(88, 144);
            this.txtFactoryBoot.Name = "txtFactoryBoot";
            this.txtFactoryBoot.ReadOnly = true;
            this.txtFactoryBoot.Size = new System.Drawing.Size(152, 20);
            this.txtFactoryBoot.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Factory Boot";
            // 
            // txtBinLib
            // 
            this.txtBinLib.BackColor = System.Drawing.SystemColors.Window;
            this.txtBinLib.Location = new System.Drawing.Point(88, 118);
            this.txtBinLib.Name = "txtBinLib";
            this.txtBinLib.ReadOnly = true;
            this.txtBinLib.Size = new System.Drawing.Size(152, 20);
            this.txtBinLib.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "BinLib Version";
            // 
            // txtBoot
            // 
            this.txtBoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoot.Location = new System.Drawing.Point(88, 92);
            this.txtBoot.Name = "txtBoot";
            this.txtBoot.ReadOnly = true;
            this.txtBoot.Size = new System.Drawing.Size(152, 20);
            this.txtBoot.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Boot Version";
            // 
            // txtOS
            // 
            this.txtOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtOS.Location = new System.Drawing.Point(88, 66);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(152, 20);
            this.txtOS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "OS Version";
            // 
            // txtHW
            // 
            this.txtHW.BackColor = System.Drawing.SystemColors.Window;
            this.txtHW.Location = new System.Drawing.Point(88, 40);
            this.txtHW.Name = "txtHW";
            this.txtHW.ReadOnly = true;
            this.txtHW.Size = new System.Drawing.Size(152, 20);
            this.txtHW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "HW Revision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLC Model";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CurrentTime);
            this.groupBox1.Controls.Add(this.AddVariable);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Plot);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.File_name);
            this.groupBox1.Controls.Add(this.Delay_time);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Stop_cont);
            this.groupBox1.Controls.Add(this.Run_cont);
            this.groupBox1.Controls.Add(this.Write);
            this.groupBox1.Controls.Add(this.Read);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 325);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(525, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 71;
            this.label16.Text = "Current time";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Location = new System.Drawing.Point(627, 88);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(84, 20);
            this.CurrentTime.TabIndex = 70;
            // 
            // AddVariable
            // 
            this.AddVariable.Location = new System.Drawing.Point(0, 19);
            this.AddVariable.Name = "AddVariable";
            this.AddVariable.Size = new System.Drawing.Size(113, 40);
            this.AddVariable.TabIndex = 69;
            this.AddVariable.Text = "Add variable";
            this.AddVariable.UseVisualStyleBackColor = true;
            this.AddVariable.Click += new System.EventHandler(this.AddVariable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 274);
            this.dataGridView1.TabIndex = 68;
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(0, 252);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(113, 40);
            this.Plot.TabIndex = 67;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(525, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 66;
            this.label15.Text = "File name";
            // 
            // File_name
            // 
            this.File_name.Location = new System.Drawing.Point(627, 54);
            this.File_name.Name = "File_name";
            this.File_name.Size = new System.Drawing.Size(84, 20);
            this.File_name.TabIndex = 65;
            // 
            // Delay_time
            // 
            this.Delay_time.Location = new System.Drawing.Point(627, 19);
            this.Delay_time.Name = "Delay_time";
            this.Delay_time.Size = new System.Drawing.Size(84, 20);
            this.Delay_time.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(525, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 63;
            this.label13.Text = "Loop time[ms]";
            // 
            // Stop_cont
            // 
            this.Stop_cont.Location = new System.Drawing.Point(0, 206);
            this.Stop_cont.Name = "Stop_cont";
            this.Stop_cont.Size = new System.Drawing.Size(113, 40);
            this.Stop_cont.TabIndex = 62;
            this.Stop_cont.Text = "Stop cont.";
            this.Stop_cont.UseVisualStyleBackColor = true;
            this.Stop_cont.Click += new System.EventHandler(this.Stop_cont_Click_1);
            // 
            // Run_cont
            // 
            this.Run_cont.Location = new System.Drawing.Point(0, 160);
            this.Run_cont.Name = "Run_cont";
            this.Run_cont.Size = new System.Drawing.Size(113, 40);
            this.Run_cont.TabIndex = 61;
            this.Run_cont.Text = "Run cont.";
            this.Run_cont.UseVisualStyleBackColor = true;
            this.Run_cont.Click += new System.EventHandler(this.Run_cont_Click);
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(0, 114);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(113, 40);
            this.Write.TabIndex = 6;
            this.Write.Text = "Write Values";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(0, 68);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(113, 40);
            this.Read.TabIndex = 5;
            this.Read.Text = "Read Values";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Port
            // 
            this.Port.FormattingEnabled = true;
            this.Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.Port.Location = new System.Drawing.Point(219, 37);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(110, 21);
            this.Port.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(170, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Port";
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.Baud.Location = new System.Drawing.Point(219, 67);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(110, 21);
            this.Baud.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(143, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Baud rate";
            // 
            // Retries
            // 
            this.Retries.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Retries.FormattingEnabled = true;
            this.Retries.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Retries.Location = new System.Drawing.Point(219, 93);
            this.Retries.Name = "Retries";
            this.Retries.Size = new System.Drawing.Size(110, 21);
            this.Retries.TabIndex = 26;
            // 
            // time
            // 
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.time.Location = new System.Drawing.Point(219, 120);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(110, 21);
            this.time.TabIndex = 27;
            // 
            // Ret
            // 
            this.Ret.AutoSize = true;
            this.Ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ret.Location = new System.Drawing.Point(146, 98);
            this.Ret.Name = "Ret";
            this.Ret.Size = new System.Drawing.Size(53, 17);
            this.Ret.TabIndex = 28;
            this.Ret.Text = "Retries";
            // 
            // Timeout
            // 
            this.Timeout.AutoSize = true;
            this.Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Timeout.Location = new System.Drawing.Point(135, 124);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(78, 17);
            this.Timeout.TabIndex = 29;
            this.Timeout.Text = "Timeout [s]";
            // 
            // DataBits
            // 
            this.DataBits.AutoSize = true;
            this.DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataBits.Location = new System.Drawing.Point(143, 178);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(61, 17);
            this.DataBits.TabIndex = 33;
            this.DataBits.Text = "DataBits";
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Parity.Location = new System.Drawing.Point(158, 153);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(44, 17);
            this.Parity.TabIndex = 32;
            this.Parity.Text = "Parity";
            // 
            // data
            // 
            this.data.AutoCompleteCustomSource.AddRange(new string[] {
            "7",
            "8"});
            this.data.FormattingEnabled = true;
            this.data.Items.AddRange(new object[] {
            "7",
            "8"});
            this.data.Location = new System.Drawing.Point(219, 177);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(110, 21);
            this.data.TabIndex = 31;
            // 
            // par
            // 
            this.par.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Odd",
            "Even"});
            this.par.FormattingEnabled = true;
            this.par.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.par.Location = new System.Drawing.Point(219, 150);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(110, 21);
            this.par.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(143, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "StopBits";
            // 
            // StopBits
            // 
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Items.AddRange(new object[] {
            "1"});
            this.StopBits.Location = new System.Drawing.Point(219, 204);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(110, 21);
            this.StopBits.TabIndex = 34;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(218, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Serial";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(411, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Ethernet";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(371, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Port";
            // 
            // Portip
            // 
            this.Portip.Location = new System.Drawing.Point(411, 38);
            this.Portip.Name = "Portip";
            this.Portip.Size = new System.Drawing.Size(110, 20);
            this.Portip.TabIndex = 40;
            // 
            // Ipip
            // 
            this.Ipip.Location = new System.Drawing.Point(411, 68);
            this.Ipip.Name = "Ipip";
            this.Ipip.Size = new System.Drawing.Size(110, 20);
            this.Ipip.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(339, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "IP Adress";
            // 
            // timeoutip
            // 
            this.timeoutip.AutoSize = true;
            this.timeoutip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeoutip.Location = new System.Drawing.Point(335, 121);
            this.timeoutip.Name = "timeoutip";
            this.timeoutip.Size = new System.Drawing.Size(74, 17);
            this.timeoutip.TabIndex = 46;
            this.timeoutip.Text = "Timeout[s]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(352, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "Retries";
            // 
            // Timout
            // 
            this.Timout.FormattingEnabled = true;
            this.Timout.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Timout.Location = new System.Drawing.Point(411, 120);
            this.Timout.Name = "Timout";
            this.Timout.Size = new System.Drawing.Size(110, 21);
            this.Timout.TabIndex = 44;
            // 
            // Retriesip
            // 
            this.Retriesip.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Retriesip.FormattingEnabled = true;
            this.Retriesip.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Retriesip.Location = new System.Drawing.Point(411, 93);
            this.Retriesip.Name = "Retriesip";
            this.Retriesip.Size = new System.Drawing.Size(110, 21);
            this.Retriesip.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 622);
            this.Controls.Add(this.timeoutip);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Timout);
            this.Controls.Add(this.Retriesip);
            this.Controls.Add(this.Ipip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Portip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StopBits);
            this.Controls.Add(this.DataBits);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.data);
            this.Controls.Add(this.par);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.Ret);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Retries);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Baud);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plcInformation);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Connect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.plcInformation.ResumeLayout(false);
            this.plcInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.GroupBox plcInformation;
        private System.Windows.Forms.TextBox txtFactoryBoot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBinLib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPlcName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Retries;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Label Ret;
        private System.Windows.Forms.Label Timeout;
        private System.Windows.Forms.Label DataBits;
        private System.Windows.Forms.Label Parity;
        private System.Windows.Forms.ComboBox data;
        private System.Windows.Forms.ComboBox par;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Portip;
        private System.Windows.Forms.TextBox Ipip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label timeoutip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Timout;
        private System.Windows.Forms.ComboBox Retriesip;
        private System.Windows.Forms.Button Run_cont;
        private System.Windows.Forms.Button Stop_cont;
        private System.Windows.Forms.TextBox Delay_time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox File_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Plot;
        private System.Windows.Forms.Button AddVariable;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CurrentTime;
    }
}

