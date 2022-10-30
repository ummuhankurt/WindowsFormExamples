using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CaptureaNewsHeadlinefromHürriyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //XmlTextReader xmlOku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlOku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());

                }

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            XmlTextReader xmlOku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            string ilgiliHaber = listBox1.SelectedItem.ToString();
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "description")
                {
                    listBox2.Items.Add(xmlOku.ReadString());
                }
            }


        }

        // tıkladığın haberin detayları.
    }
}
