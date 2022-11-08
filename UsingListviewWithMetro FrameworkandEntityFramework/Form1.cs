using EntityFrameworkModelFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingListviewWithMetro_FrameworkandEntityFramework
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OrnekDatabaseEntities1 entities = new OrnekDatabaseEntities1())
            {
                List<Musteriler> musteriList = entities.Musterilers.ToList();
                foreach (var item in musteriList)
                {
                    ListViewItem listViewItem = new ListViewItem(item.MusteriId.ToString());
                    listViewItem.SubItems.Add(item.MusteriAd);
                    listViewItem.SubItems.Add(item.MusteriSoyad);
                    listViewItem.SubItems.Add(item.MusteriBakiye.ToString());
                    listViewItem.SubItems.Add(item.MusteriPuan.ToString());
                    metroListView1.Items.Add(listViewItem);
                }
            }
        }
    }
}
