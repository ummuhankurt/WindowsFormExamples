using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void islemler(int sayi1, int sayi2); // işlemler adında bir temsilci tanımlandı.

        void topla(int sayi1,int sayi2)
        {
            int sonuc =  sayi1 + sayi2;
            listBox1.Items.Add(sonuc);
        }
        void fark(int sayi1, int sayi2)
        {
            int sonuc=  sayi1 - sayi2;
            listBox1.Items.Add(sonuc);
        }

        void  carpim(int sayi1, int sayi2)
        {
            int sonuc =  sayi1 * sayi2;
            listBox1.Items.Add(sonuc);
        }
        void bolum(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            listBox1.Items.Add(sonuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islemler isl = new islemler(topla);
            isl += fark;
            isl += carpim;
            isl += bolum;
            isl(10, 5);

            //listBox1.Items.Add(topla(10, 5));
            //listBox1.Items.Add(fark(10, 5));
            //listBox1.Items.Add(carpim(10, 5));
            //listBox1.Items.Add(bolum(10, 5));
        }
    }
}
