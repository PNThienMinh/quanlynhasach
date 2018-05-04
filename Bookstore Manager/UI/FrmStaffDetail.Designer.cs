namespace UI
{
    partial class FrmStaffDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaffDetail));
            this.lbTitle = new MaterialSkin.Controls.MaterialLabel();
            this.functionBindingSource = new System.Windows.Forms.BindingSource();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbSex = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.QuitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Depth = 0;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(35, 24);
            this.lbTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(118, 19);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Staff Infomation";
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(DTO.Function);
            // 
            // cbFunc
            // 
            this.cbFunc.DataSource = this.functionBindingSource;
            this.cbFunc.DisplayMember = "Func";
            this.cbFunc.DropDownHeight = 150;
            this.cbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.IntegralHeight = false;
            this.cbFunc.ItemHeight = 15;
            this.cbFunc.Location = new System.Drawing.Point(474, 312);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(162, 23);
            this.cbFunc.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(641, 482);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = false;
            this.btnUpdate.Size = new System.Drawing.Size(64, 36);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(383, 444);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(132, 19);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "Confirm password";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(35, 444);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(108, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "New password";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(37, 312);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Email";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(368, 312);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(67, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Function";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(368, 244);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Phone number";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(368, 179);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Birthday";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 244);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "UID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(33, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Sex";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 18);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbName.LineThickness = 3;
            this.tbName.Location = new System.Drawing.Point(104, 93);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(370, 44);
            this.tbName.TabIndex = 22;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbSex
            // 
            this.tbSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSex.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSex.HintForeColor = System.Drawing.Color.Empty;
            this.tbSex.HintText = "";
            this.tbSex.isPassword = false;
            this.tbSex.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSex.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSex.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSex.LineThickness = 3;
            this.tbSex.Location = new System.Drawing.Point(104, 154);
            this.tbSex.Margin = new System.Windows.Forms.Padding(4);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(171, 44);
            this.tbSex.TabIndex = 22;
            this.tbSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUID
            // 
            this.tbUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUID.HintForeColor = System.Drawing.Color.Empty;
            this.tbUID.HintText = "";
            this.tbUID.isPassword = false;
            this.tbUID.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUID.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUID.LineThickness = 3;
            this.tbUID.Location = new System.Drawing.Point(104, 219);
            this.tbUID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(171, 44);
            this.tbUID.TabIndex = 22;
            this.tbUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPhone
            // 
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPhone.HintForeColor = System.Drawing.Color.Empty;
            this.tbPhone.HintText = "";
            this.tbPhone.isPassword = false;
            this.tbPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPhone.LineThickness = 3;
            this.tbPhone.Location = new System.Drawing.Point(474, 219);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(171, 44);
            this.tbPhone.TabIndex = 22;
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 3;
            this.tbEmail.Location = new System.Drawing.Point(104, 287);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 44);
            this.tbEmail.TabIndex = 22;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPassword.HintText = "";
            this.tbNewPassword.isPassword = false;
            this.tbNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPassword.LineThickness = 3;
            this.tbNewPassword.Location = new System.Drawing.Point(150, 419);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(198, 44);
            this.tbNewPassword.TabIndex = 22;
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbConfirmPassword.HintText = "";
            this.tbConfirmPassword.isPassword = false;
            this.tbConfirmPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbConfirmPassword.LineThickness = 3;
            this.tbConfirmPassword.Location = new System.Drawing.Point(529, 419);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(198, 44);
            this.tbConfirmPassword.TabIndex = 22;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.RoyalBlue;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(474, 162);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(231, 36);
            this.datePicker.TabIndex = 23;
            this.datePicker.Value = new System.DateTime(2018, 4, 16, 19, 58, 35, 317);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.White;
            this.QuitButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton.Image")));
            this.QuitButton.ImageActive = null;
            this.QuitButton.Location = new System.Drawing.Point(696, 6);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(37, 26);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuitButton.TabIndex = 24;
            this.QuitButton.TabStop = false;
            this.QuitButton.Zoom = 10;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(77, 61);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(578, 25);
            this.bunifuSeparator1.TabIndex = 25;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(77, 387);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(578, 25);
            this.bunifuSeparator2.TabIndex = 25;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // FrmStaffDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 533);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbFunc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaffDetail";
            this.Text = "FrmStaffDetail";
            this.Load += new System.EventHandler(this.FrmStaffDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbTitle;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private System.Windows.Forms.ComboBox cbFunc;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbConfirmPassword;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private Bunifu.Framework.UI.BunifuImageButton QuitButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}