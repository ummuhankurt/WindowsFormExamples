using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClassAndObjectConcept
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Arabalar araba2 = new Arabalar();
            araba2.renk = "mavi";
            araba2.fiyat = 27.475;
            araba2.durum = 'i';
            araba2.model = 2018;
            araba2.hiz = 180;

            label1.Text = araba2.renk;
            label2.Text = araba2.fiyat.ToString();
            label3.Text = araba2.durum.ToString();
            label4.Text = araba2.model.ToString();
            label5.Text = araba2.hiz.ToString();
        }
    }
}
