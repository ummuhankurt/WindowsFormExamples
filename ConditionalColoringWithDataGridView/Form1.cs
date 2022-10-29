using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionalColoringWithDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personellerDataSet.PerInformation' table. You can move, or remove it, as needed.
            this.perInformationTableAdapter.Fill(this.personellerDataSet.PerInformation);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if((bool)dataGridView1.Rows[i].Cells[5].Value == true)
                {
                    renk.BackColor = Color.Pink;
                    renk.ForeColor = Color.Black;
                }
                else
                {
                    renk.BackColor = Color.FloralWhite;
                    renk.ForeColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk; // varsayılan hücre biçimi olarak renkten gelen değerleri uygula.
            }

        }
    }
}
