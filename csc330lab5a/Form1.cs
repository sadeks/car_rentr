using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csc330lab5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            int days = Int32.Parse(numericUpDown1.Value.ToString());
            if (radioButton1.Checked)
            {
                total=19.95 * days;
                total += total * 0.0875;//add NY tax
                textBox1.Text ="$"+ total.ToString("#.##");
            }
            else if (radioButton2.Checked)
            {
                total = 24.95 * days;
                total += total * 0.0875;
                textBox1.Text = "$" + total.ToString("#.##");
            }
            else if (radioButton3.Checked)
            {
                total = 39.95 * days;
                total += total * 0.0875;
                textBox1.Text = "$" + total.ToString("#.##");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            radioButton1.Checked = true;
        }
    }
}
