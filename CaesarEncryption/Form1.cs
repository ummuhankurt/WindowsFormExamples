﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            string veri = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray(); //veri alanından gelen string değeri char dizisine dönüştürdü.
            foreach (char item in karakterler)
            {
                textBox2.Text += Convert.ToChar(item + 3).ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = textBox2.Text;
            char[] karakterler = sifre.ToCharArray();
            foreach (var item in karakterler)
            {
                textBox1.Text += Convert.ToChar(item - 3).ToString();
            }
        }
    }
}
