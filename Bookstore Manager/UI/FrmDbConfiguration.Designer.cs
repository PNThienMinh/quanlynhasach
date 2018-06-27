namespace UI
{
    partial class FrmDbConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDbConfiguration));
            this.tbServerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCheckConn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ssmWaiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.FrmWaiting), true, true);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServerName
            // 
            this.tbServerName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbServerName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbServerName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbServerName.BorderThickness = 3;
            this.tbServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbServerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbServerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbServerName.isPassword = false;
            this.tbServerName.Location = new System.Drawing.Point(3, 18);
            this.tbServerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(366, 37);
            this.tbServerName.TabIndex = 0;
            this.tbServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbServerName.OnValueChanged += new System.EventHandler(this.tbServerName_OnValueChanged);
            // 
            // btnCheckConn
            // 
            this.btnCheckConn.Location = new System.Drawing.Point(78, 77);
            this.btnCheckConn.Name = "btnCheckConn";
            this.btnCheckConn.Size = new System.Drawing.Size(107, 25);
            this.btnCheckConn.TabIndex = 2;
            this.btnCheckConn.Text = "Kiểm tra kết nối";
            this.btnCheckConn.UseVisualStyleBackColor = true;
            this.btnCheckConn.Click += new System.EventHandler(this.btnCheckConn_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(211, 77);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 25);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbServerName);
            this.groupBox1.Location = new System.Drawing.Point(49, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tên máy chủ (Server name)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 77);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ssmWaiting
            // 
            this.ssmWaiting.ClosingDelay = 500;
            // 
            // FrmDbConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 114);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCheckConn);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDbConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox tbServerName;
        private System.Windows.Forms.Button btnCheckConn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmWaiting;
    }
}