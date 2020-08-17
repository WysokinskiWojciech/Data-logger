using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Threading;


namespace Com_Drive_Net___Example
{
    public partial class Form2 : Form
    {

        bool state = false;
        private BackgroundWorker _worker = null;// inicjalizacja obiektu do wielowątkowości
        public Form2()
        {
            InitializeComponent();
            _worker = new BackgroundWorker();// inicjalizacja wielowątkowości
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += new DoWorkEventHandler(UpdateChart);// odczyt danych  w pętli
            _worker.ProgressChanged += new ProgressChangedEventHandler(Print_Data);//wyświetlanie danych w pętli po odczycie danych
            _worker.RunWorkerAsync();
            state = true;
        }

        private void UpdateChart(object sender, DoWorkEventArgs e)
        {
            while (state)
            {
                
                _worker.ReportProgress(1);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void Print_Data(object sender, ProgressChangedEventArgs e)
        {
            Plot1.Series["Var1"].Points.Clear();
            Plot1.Series["Var2"].Points.Clear();
            Plot1.Series["Var3"].Points.Clear();
            Plot1.Series["Var4"].Points.Clear();
            Plot1.Series["Var5"].Points.Clear();
            for (int i = 0; i < Form1.plotdata.Length; i++) { 
        
                if (Form1.plotdata[i] != Int32.MinValue) {
                Plot1.Series["Var1"].Points.AddY(Form1.plotdata[i]);
                }

                if (Form1.plotdata2[i] != Int32.MinValue)
                {
                    Plot1.Series["Var2"].Points.AddY(Form1.plotdata2[i]);
                }

                if (Form1.plotdata3[i] != Int32.MinValue)
                {
                    Plot1.Series["Var3"].Points.AddY(Form1.plotdata3[i]);
                }

                if (Form1.plotdata4[i] !=Int32.MinValue)
                {
                    Plot1.Series["Var4"].Points.AddY(Form1.plotdata4[i]);
                }

                if (Form1.plotdata5[i] != Int32.MinValue)
                {
                    Plot1.Series["Var5"].Points.AddY(Form1.plotdata5[i]);
                }

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            state = false;
            _worker.CancelAsync();
        }
    }
    }

