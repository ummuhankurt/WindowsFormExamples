using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void islemler(int sayi);
        void Fonksiyon(int sayi)
        {
            int sonuc = 4 * sayi * 2 + 5 * sayi + 10;
            listBox1.Items.Add(sonuc);
        }

        void Kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            listBox1.Items.Add(sonuc);
        }
        void Kare(int sayi)
        {
            int sonuc = sayi * 4;
            listBox1.Items.Add(sonuc);
        }
        void Daire(int sayi)
        {
            int sonuc = (int)3.14 * sayi * sayi;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            islemler islemler = new islemler(Fonksiyon);
            islemler += Kup;
            islemler += Kare;
            islemler += Daire;
            islemler(5);
        }
    }
}
