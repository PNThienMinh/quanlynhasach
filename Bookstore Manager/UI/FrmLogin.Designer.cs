namespace UI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager ssmWaiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.SplashScreen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ssmLogin = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.FrmWaiting), true, true, true);
            this.SuspendLayout();
            // 
            // ssmWaiting
            // 
            ssmWaiting.ClosingDelay = 500;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(188, 191);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(94, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Depth = 0;
            this.tbPassword.Hint = "Mật khẩu";
            this.tbPassword.Location = new System.Drawing.Point(32, 140);
            this.tbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(250, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Depth = 0;
            this.tbUsername.Hint = "Tên đăng nhập";
            this.tbUsername.Location = new System.Drawing.Point(32, 100);
            this.tbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.Size = new System.Drawing.Size(250, 23);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblUsername_KeyDown);
            // 
            // ssmLogin
            // 
            this.ssmLogin.ClosingDelay = 500;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 254);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbUsername;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmLogin;
    }
}