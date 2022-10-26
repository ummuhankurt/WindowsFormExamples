using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Sehir
        {
            public string sehir;
            public short plaka;
            public string meshur;
            public string renk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehir sehir = new Sehir();
            sehir.sehir = txtSehir.Text;
            sehir.plaka = Convert.ToInt16(txtPlaka.Text);
            sehir.meshur = txtMeshur.Text;
            sehir.renk = txtRenk.Text;
            MessageBox.Show(sehir.sehir + " \n" + sehir.plaka + " \n" + sehir.meshur + " \n" + sehir.renk);
        }
    }
}
