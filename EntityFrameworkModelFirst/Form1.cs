using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonellerEntities personellerEntities = new PersonellerEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personellerEntities.PerInformations.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PerInformation perInformation = new PerInformation(); // Tablodan (sınıftan) nesne üretiyoruz. Satırlar nesnelere karşılık gelir.
            perInformation.PerAd = txtAd.Text;
            perInformation.PerSoyad = txtSoyad.Text;
            perInformation.PerSehir = txtSehir.Text;
            perInformation.PerMaas = Convert.ToInt32(txtMaas.Text);
            perInformation.PerDurum = Convert.ToBoolean(txtDurum.Text);
            personellerEntities.PerInformations.Add(perInformation);
            personellerEntities.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personellerEntities.PerInformations.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme işleminde güncellenecek olan değerin hafızaya alınma işlemi var. First medotu.(LİNQ)
            // id'ye göre güncelleme işlemi yapılacak.
            int id = Convert.ToInt16(txtId.Text);
            PerInformation perInformation = personellerEntities.PerInformations.First(x => x.PerId == id);
            perInformation.PerAd = txtAd.Text;
            perInformation.PerSoyad = txtSoyad.Text;
            perInformation.PerSehir = txtSehir.Text;
            perInformation.PerMaas = Convert.ToInt16(txtMaas.Text);
            perInformation.PerDurum = Convert.ToBoolean(txtDurum.Text);
            personellerEntities.SaveChanges();
            MessageBox.Show("Personel güncellendi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silme işleminde silinecek olan değerin hafızaya alınma işlemi var. First medotu.(LİNQ)
            int id = Convert.ToInt16(txtId.Text);
            PerInformation perInformation = personellerEntities.PerInformations.First(x => x.PerId == id); // textboxtan gelen değer veritabanında var mı diye kontrol eder.
            personellerEntities.PerInformations.Remove(perInformation);
            personellerEntities.SaveChanges();
            MessageBox.Show("Personel silindi");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenHucre = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilenHucre].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilenHucre].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenHucre].Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secilenHucre].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilenHucre].Cells[4].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilenHucre].Cells[5].Value.ToString();
        }
    }
}
