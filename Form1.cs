using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfas_de_tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A1=double.Parse(textBox1.Text);
            double A2 = double.Parse(textBox2.Text);
            double A3 = double.Parse(textBox3.Text);
            double A4 = double.Parse(textBox4.Text);
            double A5 = double.Parse(textBox5.Text);
            double T = A1 + A2 + A3 + A4 + A5;
            if (T > 2000)
            {
               
                int Td = (int)(T - (T * 0.10));
                textBox6.Text = T.ToString();
                textBox7.Text = Td.ToString();
                textBox8.Text = "10%";
            }
            else
            {

                textBox6.Text = T.ToString();
                textBox7.Text = "0";
                textBox8.Text = "0%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
