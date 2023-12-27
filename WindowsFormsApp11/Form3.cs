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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 t4 = new Form4();
            t4.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(textBox1.Text);
            y = x * 0.453592;
            label3.Text = "Килограммы= " + y.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 t2 = new Form2();
            t2.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
