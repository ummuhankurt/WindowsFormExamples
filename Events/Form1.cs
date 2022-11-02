using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSeaGreen;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "sarı")
            {
                this.BackColor = Color.LightYellow;
            }
            if(textBox1.Text == "mavi")
            {
                this.BackColor = Color.LightBlue;
            }
            if (textBox1.Text == "pembe")
            {
                this.BackColor = Color.LightPink;
            }
            int kalan = Convert.ToInt16(label2.Text);
            kalan--;
            label2.Text = kalan.ToString();
            Control(kalan);
        }
        private void Control(int kalan)
        {
            if (kalan == 0)
            {
                MessageBox.Show("Daha fazla karakter girmeyin");
                textBox1.Enabled = false;
            }
        }
    }
}
