using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Sehirler
        {
            x,Adana, Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın
        }

        

         // klavyeden girilen sayıya göre o sayının karşılığı olan ayı getir.
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text);
            Sehirler s;
            s = (Sehirler)plaka; // s değeri ; girmiş olduğum plakanın şehirlerdeki karşılığını alacak.
            label2.Text = s.ToString();
        }
        enum aylar
        {
            x, ocak, şubat, mart, nisan, mayıs, haziran, temmuz, ağustos, eylül, ekim, kasım, aralık
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox2.Text);
            aylar a = (aylar)ay;
            label1.Text = a.ToString();
        }
    }
}
