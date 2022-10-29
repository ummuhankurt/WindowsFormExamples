using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;

namespace Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Test()
        {
            string adres = "https://www.google.com";
            try
            {
                WebRequest webRequest = WebRequest.Create(adres); // isteği gönder.
                WebResponse webResponse = webRequest.GetResponse(); // istekten yanıtı al.
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Test())
            {
                this.Text = "Bağlantı var";
            }
            else
            {
                this.Text = "Bağlantı yok";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/"); // Türkçeden ingilizceye çevir.

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/"); // ingilizceden türkçeye çevir.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox1.Text ; // çeviri yaparken nereden çevireceğimiz alan.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                richTextBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;

            }
            if (radioButton2.Checked == true)
            {
                richTextBox1.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;

            }

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox2.Text;
        }
    }
}
