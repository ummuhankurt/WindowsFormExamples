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

namespace DisplayMemberAndValueMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=OrnekDatabase;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Hareketler (Urun,Musteri,Personel) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue); // SelectedValue : int.
            komut.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
            komut.ExecuteNonQuery();
            MessageBox.Show("Eklendi");
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ürünleri çekme
            SqlCommand komut = new SqlCommand("Select * from Urunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "UrunId";
            comboBox1.DisplayMember = "UrunAd";
            comboBox1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select * from Musteriler", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "MusteriId";
            comboBox2.DisplayMember = "MusteriAd";
            comboBox2.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("Select * from Personeller", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox3.ValueMember = "PersonelId";
            comboBox3.DisplayMember = "PersonelAd";
            comboBox3.DataSource = dt3;
        }
    }
}
