using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PreventRepetitiveRecording
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=UMMUHANKURT;Initial Catalog=DersVeriTabani;Integrated Security=True");
        bool durum;
        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from bilgi where Numara = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtNumara.Text);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            if (sqlDataReader.Read()) // @p1 değeri veri tabanında varsa
            {
                durum = false; // veritabanında böyle bir kayıt var, yenisini ekleme.
            }
            else
            {
                durum = true; // veritabanında böyle bir kayıt yok, yenisini ekleyebilirsin.
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into bilgi values(@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtNumara.Text);
                komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt eklendi");
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
