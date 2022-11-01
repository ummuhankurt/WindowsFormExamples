using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Baran");
            kisiler.Add("Eylül");
            kisiler.Add("Aslan");
            kisiler.Add("Eda");
            kisiler.Add("Mesut");
            foreach (string item in kisiler)
            {
                listBox1.Items.Add(item);
            }
            kisiler.Remove("Aslan");
            kisiler.RemoveAt(3);
            for (int i = 0; i < kisiler.Count; i++)
            {
                comboBox1.Items.Add(kisiler[i]);
            }

            //if (kisiler.Contains("Eda"))
            //{
            //    label1.Text = "Eda kişisi mevcut";
            //}
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Secilen kisi : " + listBox1.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Secilen kisi : " + comboBox1.SelectedItem;
        }
        
    }
}
