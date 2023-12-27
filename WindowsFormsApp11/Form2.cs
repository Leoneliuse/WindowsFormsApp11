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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            double x, y;
            x = double.Parse(textBox1.Text);
            y = x * 1.60934;
            label2.Text = "Километры= " + y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 t3 = new Form3();
            t3.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 t1 = new Form1();
            t1.Show();
            Close();
        }
    }
}
