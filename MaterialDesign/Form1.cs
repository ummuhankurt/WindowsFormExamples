using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace MaterialDesign
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this); // bu form(this) mun yönetimine ekle.
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Pink900, Primary.LightBlue200, Primary.Green400,Accent.DeepOrange200 ,TextShade.WHITE);
            //1. Primary.Pink900 :> Navbar 
            //2. Primary.LightBlue200 :> en üst
            //3. ? 
            // 4. Accent.Green400 Tab geçiş ve tik renkleri.
            // 5.TextShade.WHITE :> Yazı renkleri.
        }
    }
}
