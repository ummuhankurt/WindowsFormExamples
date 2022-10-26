using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndObjectConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arabalar araba = new Arabalar();
            araba.renk = "kirmizi";
            araba.fiyat = 32.475;
            araba.durum = 'S';
            araba.model = 2017;
            araba.hiz = 220;
         
            label1.Text = araba.renk;
            label2.Text = araba.fiyat.ToString();
            label3.Text = araba.durum.ToString();
            label4.Text = araba.model.ToString();
            label5.Text = araba.hiz.ToString();

            this.BackColor = Color.Red;
        }
    }
}
