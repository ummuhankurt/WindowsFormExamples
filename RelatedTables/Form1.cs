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

namespace RelatedTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data source=UMMUHANKURT; Initial Catalog=SehirListesi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SehirAd from Sehirler", baglanti);
            //ExecuteReader komutu DML komutu olarak Select de kullanılır.
            //ExecuteNonQuery komutu insert,update ve delete de kullanılır.Yani tablo üstünde değişiklik yapılan komutlarda.
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]); //sadece sehir adı dönecek o da 0.indexte

            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select IlceAd from Ilceler where ilId = @p1", baglanti);
            // tablodaki id'ler 1 den başlıyor ama combobaxtaki indexler 0 dan başlıyor 
            komut2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex+1);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while(dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]); //sadece ilçe adı dönecek o da 0.indexte
            }
            baglanti.Close();
        }
    }
}
