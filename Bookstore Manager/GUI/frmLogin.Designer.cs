namespace GUI
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
            this.lblUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbRememberUser = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Depth = 0;
            this.lblUsername.Hint = "Username";
            this.lblUsername.Location = new System.Drawing.Point(30, 108);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.PasswordChar = '\0';
            this.lblUsername.SelectedText = "";
            this.lblUsername.SelectionLength = 0;
            this.lblUsername.SelectionStart = 0;
            this.lblUsername.Size = new System.Drawing.Size(250, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.UseSystemPasswordChar = false;
            this.lblUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblUsername_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.Depth = 0;
            this.lblPassword.Hint = "Password";
            this.lblPassword.Location = new System.Drawing.Point(30, 147);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.PasswordChar = '*';
            this.lblPassword.SelectedText = "";
            this.lblPassword.SelectionLength = 0;
            this.lblPassword.SelectionStart = 0;
            this.lblPassword.Size = new System.Drawing.Size(250, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.UseSystemPasswordChar = false;
            this.lblPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblPassword_KeyDown);
            // 
            // cbRememberUser
            // 
            this.cbRememberUser.AutoSize = true;
            this.cbRememberUser.Depth = 0;
            this.cbRememberUser.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbRememberUser.Location = new System.Drawing.Point(30, 189);
            this.cbRememberUser.Margin = new System.Windows.Forms.Padding(0);
            this.cbRememberUser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbRememberUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbRememberUser.Name = "cbRememberUser";
            this.cbRememberUser.Ripple = true;
            this.cbRememberUser.Size = new System.Drawing.Size(120, 30);
            this.cbRememberUser.TabIndex = 2;
            this.cbRememberUser.Text = "Remember me";
            this.cbRememberUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(186, 239);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(94, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 311);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbRememberUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Enter += new System.EventHandler(this.btnLogin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField lblUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblPassword;
        private MaterialSkin.Controls.MaterialCheckBox cbRememberUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    }
}

