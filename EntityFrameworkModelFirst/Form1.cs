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
    }
}
