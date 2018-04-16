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
using Business;
using Contract;
using DTO;

namespace GUI
{
    public partial class FrmLogin : MaterialForm, ILoginContract
    {

        private ILoginFormToLoginInfo _loginFormToLoginInfo;

        public FrmLogin()
        {
            InitializeComponent();
            InitializeUI();
            InitializeLogic();
        }

        private void InitializeLogic()
        {
            _loginFormToLoginInfo = new LoginInfo(this);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = lblUsername.Text.Trim().ToString();
            string password = lblPassword.Text.Trim().ToString();

            _loginFormToLoginInfo.ValidateUser(username, password);
        }

        public void OnLoginSuccess(User user)
        {
            // TODO: Display user's info in dashboard
            FrmDashboard frmDashboard = new FrmDashboard();
            this.Hide();
            frmDashboard.ShowDialog();
            this.Close();

        }

        public void OnLoginFail(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void lblPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
