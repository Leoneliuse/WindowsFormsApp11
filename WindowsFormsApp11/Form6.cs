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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int l = 0, h = 0, m = 0, cena = 600000;
            double skidka = 1,obs;
            if (checkBox1.Checked)
            {
                l = 150000;
            }
            if (checkBox2.Checked)
            {
                h = 80000;
            }
            if (checkBox3.Checked)
            {
                m = 170000;
            }
            obs = (cena + l + h + m) * skidka;
            label1.Text = "Стоимость= " + obs.ToString();
            if ((checkBox1.Checked)&& (checkBox2.Checked) && (checkBox3.Checked))
            {
                skidka = 100000;
                obs = (cena + l + h + m) - skidka;
                label1.Text = "Стоимость (+скидка 10%)= " + obs.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 t5 = new Form5();
            t5.Show();
            Close();
        }
    }
}
