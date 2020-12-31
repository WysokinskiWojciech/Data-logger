namespace Com_Drive_Net___Example
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Plot1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Plot1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plot1
            // 
            chartArea2.Name = "ChartArea1";
            this.Plot1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Plot1.Legends.Add(legend2);
            this.Plot1.Location = new System.Drawing.Point(0, 0);
            this.Plot1.Name = "Plot1";
            this.Plot1.Size = new System.Drawing.Size(803, 573);
            this.Plot1.TabIndex = 0;
            this.Plot1.Text = "chart1";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(675, 391);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 72);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close Plot";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Plot1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Plot1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Plot1;
        private System.Windows.Forms.Button Close;
    }
}