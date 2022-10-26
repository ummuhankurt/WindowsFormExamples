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
using System.IO;

namespace GettingAnExternalLinkAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglantiAdresi;
        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader streamReader = new StreamReader("C:\\dataSource.txt");
            string satir = streamReader.ReadLine();
            while(satir != null)
            {
                baglantiAdresi = satir;
                satir = streamReader.ReadLine(); // satir okumaya devam etsin. Null değer görene kadar.
            }

            SqlConnection baglanti = new SqlConnection(baglantiAdresi);
            SqlDataAdapter da = new SqlDataAdapter("select *from Filmler",baglanti);
            DataSet ds = new DataSet(); // verileri hafızaya alıyor gibi düşünebiliriz.
            da.Fill(ds); // data adaterin içini doldur. datasetteki verilerle.
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
