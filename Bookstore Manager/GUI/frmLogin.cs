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

namespace GUI
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                MaterialSkin.Primary.Green600,
                MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.Blue500,
                Accent.Orange700,
                MaterialSkin.TextShade.WHITE
                );

        }
    }
}
