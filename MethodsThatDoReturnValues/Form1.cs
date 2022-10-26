using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsThatDoReturnValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Topla(int s1,int s2)
        {
            int topla = s1 + s2;
            return topla;
        }

        int Cikar(int s1,int s2)
        {
            
            int cikar = s1 - s2;
            return cikar;
        }

        int Carp(int s1,int s2)
        {
            
            int carp = s1 * s2;
            return carp;
        }

        double Bol(double s1, double s2)
        {
            
            double bol = s1 / s2;
            return bol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            label4.Text = Topla(sayi1,sayi2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            label4.Text = Cikar(sayi1,sayi2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            label4.Text = Carp(sayi1,sayi2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            label4.Text = Bol(sayi1,sayi2).ToString();
        }
    }
}
