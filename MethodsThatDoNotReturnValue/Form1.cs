using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsThatDoNotReturnValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void metot1()
        {
            label1.Text = "23 Ekim 2022";
            label2.Text = "Soğuk bir sonbahar gecesi";
            label3.Text = "Peynir-karpuz-su";
            label4.Text = "İstanbul / Şişli / Mecidiyeköy";
        }

        void metot2()
        {
            label1.BackColor = Color.OrangeRed;
            label2.BackColor = Color.BlueViolet;
            label3.BackColor = Color.Pink;
            label4.BackColor = Color.LemonChiffon;
        }

        void metot3()
        {
            label1.ForeColor = Color.White;
            this.Text = "C# Ders 9 / ikinci 100"; // sol üst köşe.
            MessageBox.Show("Ders bitti");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metot1();
            metot2();
            metot3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metot3();
        }
    }
}
