using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplama(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        int Toplama(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        int Toplama(int sayi1, int sayi2, int sayi3,int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("5 + 6 = " + Toplama(5, 6));
            listBox1.Items.Add("5 + 6 + 8 = " + Toplama(5, 6,8));
            listBox1.Items.Add("5 + 6 + 8 + 8 = " + Toplama(5, 6, 8,8));
        }
    }
}
