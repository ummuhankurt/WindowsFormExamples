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

namespace DataListingWithExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ummuhan.UMMUHANKURT\OneDrive\Masaüstü\Kitap1.xlsx;Extended Properties='Excel 8.0; HDR=YES;'");
        void Veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from [sayfa1$]",baglanti); // bağlantı nesnesinin bulunduğu adreste.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Veriler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [sayfa1$] values(@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtTur.Text);
            komut.Parameters.AddWithValue("@p4", txtFiyat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Veriler();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete from [sayfa1$] where Kitap", baglanti);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // ilk tıklanılan alanın indexi.
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update [sayfa1$] set KitapAd = @p1 ,Yazar = @p2,Tür = @p3,Fiyat = @p4 where id=@p5 ", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtTur.Text);
            komut.Parameters.AddWithValue("@p4", txtFiyat.Text);
            komut.Parameters.AddWithValue("@p5", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
