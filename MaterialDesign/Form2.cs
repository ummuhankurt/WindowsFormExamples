using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialDesign
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this); // bu form(this) mun yönetimine ekle.
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(Primary.Pink900, Primary.LightBlue200, Primary.Green400, Accent.DeepOrange200, TextShade.WHITE);
        }
    }
}
