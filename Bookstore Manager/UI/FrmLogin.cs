using System;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraSplashScreen;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;
using Services;

namespace UI
{
    public partial class FrmLogin : MaterialForm, ILoginView
    {
        private ILoginService _loginService;

        public FrmLogin()
        {
            InitializeComponent();
            InitUI();
            InitInstances();
        }

        private void InitInstances()
        {
            _loginService = new LoginService(this);
        }

        private void InitUI()
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
            tbUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (username.Equals("") || password.Equals(""))
                return;

            ssmLogin.ShowWaitForm();
            _loginService.ValidateUser(username, password);
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
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            Ultilities.SetupDataLocation();

            if (!Ultilities.IsDatabaseConnected())
            {
                using (var form = new FrmDbConfiguration())
                {
                    var result = form.ShowDialog();
                }
            }
        }
    }
}