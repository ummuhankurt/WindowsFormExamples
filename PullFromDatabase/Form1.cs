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
namespace PullFromDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data source=UMMUHANKURT; Initial Catalog=FilmArsiv;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();



            SqlCommand komut = new SqlCommand("select *from Filmler", baglanti);
            var reader = komut.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            baglanti.Close();
            MessageBox.Show("Geldi");
        }
    }
}
