using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.PersonellerTableAdapter dt = new DataSet1TableAdapters.PersonellerTableAdapter();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.PersonelListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dt.Insert(textBox1.Text, textBox2.Text);
            MessageBox.Show("Presonel eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dt.DeleteQuery(Convert.ToInt16(txtPersonelId.Text));
            MessageBox.Show("Personel silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dt.UpdateQuery(textBox1.Text, textBox2.Text, Convert.ToInt16(txtPersonelId.Text));
            MessageBox.Show("Personel güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

        }

        private void btnSartliListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.SartliGetir();
        }
    }
}
