using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Kitap
        {
            public string KitapAdi;
            public string Yazar;
            public int Sayfa;
            public string Tur;
            public double puan;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAdi = "Masumiyet Müzesi";
            kitap.Yazar = "Orhan Pamuk";
            kitap.Tur = "Roman";
            kitap.Sayfa = 350;
            kitap.puan = 8.6;
            label6.Text = kitap.KitapAdi;
            label7.Text = kitap.Yazar;
            label8.Text = kitap.Sayfa.ToString();
            label9.Text = kitap.Tur;
            label10.Text = kitap.puan.ToString();

        }
    }
}
