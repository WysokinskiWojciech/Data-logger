using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com_Drive_Net___Example
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            Ok.Enabled = false;
        }

       
        private void Ok_Click(object sender, EventArgs e)
        {   
            form1.dataGridView1.Rows.Add(comboBox1.Text,textBox1.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            { 
                Ok.Enabled = true;
            }
        }
    }
}
