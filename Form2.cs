using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace Com_Drive_Net___Example
{

    public partial class Form2 : Form
    {
        private Form1 form1;
        bool state = false;
        private BackgroundWorker _worker = null;// inicjalizacja obiektu do wielowątkowości
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _worker = new BackgroundWorker();// inicjalizacja wielowątkowości
            _worker.WorkerSupportsCancellation = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += new DoWorkEventHandler(UpdateChart);// odczyt danych  w pętli
            _worker.ProgressChanged += new ProgressChangedEventHandler(Print_Data);//wyświetlanie danych w pętli po odczycie danych
            _worker.RunWorkerAsync();
            state = true;
            this.form1 = form1;
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            state = false;
            _worker.CancelAsync();

        }

        private void UpdateChart(object sender, DoWorkEventArgs e)
        {
            while (state)
            {
                _worker.ReportProgress(1);
                System.Threading.Thread.Sleep(1);
            }
        }

        private void Print_Data(object sender, ProgressChangedEventArgs e)
        {

            for (int j = 0; j < Form1.plot.Count; j++)
            {
                try
                {

                    var point = (Form1.plot.Dequeue());
                    foreach (System.Windows.Forms.DataVisualization.Charting.Series s1 in this.Plot1.Series)
                    {
                        decimal a = Convert.ToDecimal(point[Convert.ToInt32(s1.Tag.ToString())]);
                        s1.Points.AddY(a);
                    }

                }
                catch { }
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < Form1.list.Count; i++)
            {
                r.Next(0, 256);
                var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = form1.dataGridView1.Rows[i].Cells[0].Value.ToString() + form1.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Color = System.Drawing.Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)),
                    IsVisibleInLegend = true,
                    IsXValueIndexed = false,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    Tag = i.ToString(),

                };

                this.Plot1.Series.Add(series1);
                this.Plot1.ChartAreas[0].AxisX.IsMarginVisible =false;
                this.Plot1.Series[series1.Name.ToString()].BorderWidth = 3;
               
            }
        }


    }
}
