using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptonAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anaMetin = textBox1.Text;
            byte[] veriDizisi = ASCIIEncoding.ASCII.GetBytes(anaMetin); // ana metni byte olarak al.
            string sifreliMetin = Convert.ToBase64String(veriDizisi); // byte formatındaki diziyi şifreler.
            textBox2.Text = sifreliMetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifrelenmisMetin = textBox2.Text;
            byte[] cozulenVeriDizi = Convert.FromBase64String(sifrelenmisMetin); // sifrelenmişi byte olarak çöz.
            string anaMetin = ASCIIEncoding.ASCII.GetString(cozulenVeriDizi); // byte olarak çözülen veriyi string formatında al.
            textBox1.Text = anaMetin;

        }
    }
}
