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

namespace SaveTheImageToDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data source=UMMUHANKURT; Initial Catalog=FilmArsiv;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Bilgisayardaki dosyaları açar.
            pictureBox1.ImageLocation = openFileDialog1.FileName; // Dosya yolundaki fotoğrafı fotoğraf kutusunda gösterir.
            TxtResimPath.Text = pictureBox1.ImageLocation; // Dosya yolunu text alanına yazar.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnGirisYap.Enabled)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Filmler (FilmAd, Tur,FilmPuan,FilmKategori,FilmResim) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtTur.Text);
                komut.Parameters.AddWithValue("@p3", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p4", TxtKategori.Text);
                komut.Parameters.AddWithValue("@p5", TxtResimPath.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }

            else
            {
                MessageBox.Show("Giriş yapınız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Filmler", baglanti);
            var reader = komut.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void verileriGetir_Click(object sender, EventArgs e)
        {
            if (btnGirisYap.Enabled)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Filmler where FilmId = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    TxtAd.Text = dr["FilmAd"].ToString();
                    TxtTur.Text = dr["Tur"].ToString();
                    TxtPuan.Text = dr["FilmPuan"].ToString();
                    TxtKategori.Text = dr["FilmKategori"].ToString();
                    TxtResimPath.Text = dr["FilmResim"].ToString();
                    pictureBox1.ImageLocation = TxtResimPath.Text;
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Giriş Yapınız");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPuan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResimPath.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation = TxtResimPath.Text;
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (btnGirisYap.Enabled)
            {
                SqlCommand komut = new SqlCommand("Update Filmler Set FilmAd = @p1,Tur = @p2, FilmPuan=@p3, FilmKategori=@p4 ,FilmResim = @p5 ", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtTur.Text);
                komut.Parameters.AddWithValue("@p3", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p4", TxtKategori.Text);
                komut.Parameters.AddWithValue("@p5", TxtResimPath.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            else
            {
                MessageBox.Show("Giriş yapınız");
            }
        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            if (kullaniciAdi == "" && parola == "")
            {
                MessageBox.Show("enable");
                MessageBox.Show("Giriş Yapılmadı");
            }
            else
            {
                btnGirisYap.Enabled = true; ;
                MessageBox.Show("Giriş yapıldı");
            }
        }
    }
}
