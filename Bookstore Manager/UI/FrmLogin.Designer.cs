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
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ssmLogin = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.WaitForm1), true, true, true);
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(188, 191);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(94, 37);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Depth = 0;
            this.lblPassword.Hint = "Mật khẩu";
            this.lblPassword.Location = new System.Drawing.Point(32, 140);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.PasswordChar = '*';
            this.lblPassword.SelectedText = "";
            this.lblPassword.SelectionLength = 0;
            this.lblPassword.SelectionStart = 0;
            this.lblPassword.Size = new System.Drawing.Size(250, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.UseSystemPasswordChar = false;
            this.lblPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblPassword_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.Depth = 0;
            this.lblUsername.Hint = "Tên đăng nhập";
            this.lblUsername.Location = new System.Drawing.Point(32, 100);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.PasswordChar = '\0';
            this.lblUsername.SelectedText = "";
            this.lblUsername.SelectionLength = 0;
            this.lblUsername.SelectionStart = 0;
            this.lblUsername.Size = new System.Drawing.Size(250, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.UseSystemPasswordChar = false;
            this.lblUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblUsername_KeyDown);
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
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblUsername;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmLogin;
    }
}