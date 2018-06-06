using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraEditors;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using Services;

namespace UI
{
    public partial class FrmLogin : MaterialForm, ILoginView
    {
        private ILoginService _loginFormToLoginInfo;

        public FrmLogin()
        {
            InitializeComponent();
            InitializeUI();
            InitializeLogic();
        }

        private void InitializeLogic()
        {
            _loginFormToLoginInfo = new LoginService(this);
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

            ssmLogin.ShowWaitForm();
            _loginFormToLoginInfo.ValidateUser(username, password);
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

        public void OnLoginSuccess(User user)
        {
            FrmDashboard frmDashboard = new FrmDashboard(user);
            frmDashboard.Show();
            ssmLogin.CloseWaitForm();
            this.Hide();
        }

        public void OnLoginFail(string error)
        {
            ssmLogin.CloseWaitForm();
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}