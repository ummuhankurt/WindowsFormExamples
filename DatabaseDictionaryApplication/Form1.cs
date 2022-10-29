using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseDictionaryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbSozluk.mdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select ingilizce,turkce from sozluk", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]).ToString();

            }
            baglanti.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox2.Text = listBox1.SelectedItem.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select turkce from sozluk where ingilizce = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", listBox1.SelectedItem);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }

            OleDbCommand komut2 = new OleDbCommand("Select ingilizce from sozluk where turkce = @p2", baglanti);
            komut2.Parameters.AddWithValue("@p2", listBox1.SelectedItem);
            OleDbDataReader dr2 = komut2.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr2[0].ToString();
            }
            baglanti.Close();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    listBox1.Items.Clear();
        //    baglanti.Open();
        //    OleDbCommand komut = new OleDbCommand("Select ingilizce from sozluk where ingilizce like '" + textBox1.Text + "%'", baglanti);
        //    OleDbDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        listBox1.Items.Add(dr[0]).ToString();
        //    }
        //    baglanti.Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select turkce from sozluk", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]).ToString();

            }
            baglanti.Close();
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    listBox1.Items.Clear();
        //    baglanti.Open();
        //    OleDbCommand komut = new OleDbCommand("Select turkce from sozluk where turkce like '" + textBox2.Text + "%'", baglanti);
        //    OleDbDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        listBox1.Items.Add(dr[0]).ToString();
        //    }
        //    baglanti.Close();
        //}


        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Tr to en.
        {
            radioButton1.Checked = false;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select ingilizce from sozluk where turkce = @p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
            }

            baglanti.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select turkce from sozluk where ingilizce = @p2", baglanti);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }
            
            baglanti.Close();
        }
    }
}
