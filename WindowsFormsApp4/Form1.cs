using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string a1 = comboBox1.Text;
            string b1 = checkedListBox1.Text;
            double x = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(comboBox1.Text);
            double b = Convert.ToDouble(checkedListBox1.Text);
            if (rB1.Checked)
            {
                double c = Math.Sin(Math.Pow(x,2));
                if (x <= a)
                {
                    double z = c * Math.Sin(Math.Pow(b, 2)) * x + b * Math.Log10(c * x + a);
                    textBox2.Text = z.ToString("");
                }
                if (x >= a && x < b)
                {
                    double z = a + Math.Log10(b * x) - Math.Pow(Math.Sin(a + c * x), 2);
                    textBox2.Text = z.ToString("");
                }
                if (x > b)
                {
                    double z = Math.Sqrt(Math.Cos(a + b * x) + c * Math.Pow(x, 2));
                    textBox2.Text = z.ToString("");
                }
            }
            if (rB2.Checked)
            {
                double c = Math.Pow(Math.Sin(Math.Pow(x, 2)), 2);
                if (x <= a)
                {
                    double z = c * Math.Sin(Math.Pow(b, 2)) * x + b * Math.Log10(c * x + a);
                    textBox2.Text = z.ToString("");
                }
                if (x >= a && x < b)
                {
                    double z = a + Math.Log10(b * x) - Math.Pow(Math.Sin(a + c * x), 2);
                    textBox2.Text = z.ToString("");
                }
                if (x > b)
                {
                    double z = Math.Sqrt(Math.Cos(a + b * x) + c * Math.Pow(x, 2));
                    textBox2.Text = z.ToString("");
                }
            }
            if (rB3.Checked)
            {
                double c = Math.Pow(Math.Sin(x), 2);
                if (x <= a)
                {
                    double z = c * Math.Sin(Math.Pow(b, 2)) * x + b * Math.Log10(c * x + a);
                    textBox2.Text = z.ToString("");
                }
                if (x >= a && x < b)
                {
                    double z = a + Math.Log10(b * x) - Math.Pow(Math.Sin(a + c * x), 2);
                    textBox2.Text = z.ToString("");
                }
                if (x > b)
                {
                    double z = Math.Sqrt(Math.Cos(a + b * x) + c * Math.Pow(x, 2));
                    textBox2.Text = z.ToString("");
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
