using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 t4 = new Form4();
            t4.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum,cena = 0;
            int n;
            n = int.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                cena = 8.5;
            }
            if (radioButton2.Checked)
            {
                cena = 10;
            }
            if (radioButton3.Checked)
            {
                cena = 15;
            }
            n = Convert.ToInt32(textBox1.Text);
            sum = cena * n;
            label3.Text = "Цена: " + cena.ToString("c") + "\nКоличество: " + n.ToString()+ "шт.\n" + "Сумма заказа: " + sum.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 t6 = new Form6();
            t6.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
