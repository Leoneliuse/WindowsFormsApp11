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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 t5 = new Form5();
            t5.Show();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y,z;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = y * x;
            label3.Text = "Ответ= " + z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 t3 = new Form3();
            t3.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
