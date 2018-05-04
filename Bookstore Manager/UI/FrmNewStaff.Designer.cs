namespace UI
{
    partial class FrmNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewStaff));
            this.btnValidate = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.functionBindingSource = new System.Windows.Forms.BindingSource();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnCreate = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbPhoneNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QuitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnValidate.Image = ((System.Drawing.Image)(resources.GetObject("btnValidate.Image")));
            this.btnValidate.ImageActive = null;
            this.btnValidate.Location = new System.Drawing.Point(1006, 124);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(36, 35);
            this.btnValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnValidate.TabIndex = 62;
            this.btnValidate.TabStop = false;
            this.btnValidate.Zoom = 10;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 49);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(578, 25);
            this.bunifuSeparator1.TabIndex = 61;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(707, 16);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(36, 348);
            this.bunifuSeparator2.TabIndex = 60;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // cbSex
            // 
            this.cbSex.DisplayMember = "Func";
            this.cbSex.DropDownHeight = 150;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.IntegralHeight = false;
            this.cbSex.ItemHeight = 15;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Location = new System.Drawing.Point(107, 177);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(162, 23);
            this.cbSex.TabIndex = 54;
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
            this.cbFunc.Location = new System.Drawing.Point(525, 320);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(162, 23);
            this.cbFunc.TabIndex = 53;
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(DTO.Function);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.RoyalBlue;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(456, 164);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(231, 36);
            this.datePicker.TabIndex = 39;
            this.datePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.Depth = 0;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.Location = new System.Drawing.Point(999, 371);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = false;
            this.btnCreate.Size = new System.Drawing.Size(62, 36);
            this.btnCreate.TabIndex = 59;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Depth = 0;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(7, 5);
            this.lbTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(118, 19);
            this.lbTitle.TabIndex = 57;
            this.lbTitle.Text = "Staff Infomation";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(777, 283);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(138, 19);
            this.materialLabel9.TabIndex = 50;
            this.materialLabel9.Text = "Confirm password*";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(775, 81);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(83, 19);
            this.materialLabel10.TabIndex = 49;
            this.materialLabel10.Text = "Username*";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(777, 190);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 19);
            this.materialLabel8.TabIndex = 48;
            this.materialLabel8.Text = "Password*";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 322);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 47;
            this.materialLabel6.Text = "Email";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(452, 322);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 51;
            this.materialLabel7.Text = "Function*";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(327, 254);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(111, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Phone number*";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(327, 181);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Birthday*";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 254);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "UID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 181);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 43;
            this.materialLabel3.Text = "Sex*";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPhoneNo.HintForeColor = System.Drawing.Color.Empty;
            this.tbPhoneNo.HintText = "";
            this.tbPhoneNo.isPassword = false;
            this.tbPhoneNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPhoneNo.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPhoneNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPhoneNo.LineThickness = 4;
            this.tbPhoneNo.Location = new System.Drawing.Point(456, 229);
            this.tbPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(231, 44);
            this.tbPhoneNo.TabIndex = 41;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 4;
            this.tbEmail.Location = new System.Drawing.Point(107, 297);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(306, 44);
            this.tbEmail.TabIndex = 52;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbConfirmPassword.HintText = "";
            this.tbConfirmPassword.isPassword = true;
            this.tbConfirmPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbConfirmPassword.LineThickness = 4;
            this.tbConfirmPassword.Location = new System.Drawing.Point(779, 320);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(210, 44);
            this.tbConfirmPassword.TabIndex = 58;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.HintForeColor = System.Drawing.Color.Empty;
            this.tbUsername.HintText = "";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUsername.LineThickness = 4;
            this.tbUsername.Location = new System.Drawing.Point(779, 115);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(210, 44);
            this.tbUsername.TabIndex = 55;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPassword.LineThickness = 4;
            this.tbPassword.Location = new System.Drawing.Point(781, 213);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(210, 44);
            this.tbPassword.TabIndex = 56;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUID
            // 
            this.tbUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUID.HintForeColor = System.Drawing.Color.Empty;
            this.tbUID.HintText = "";
            this.tbUID.isPassword = false;
            this.tbUID.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUID.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUID.LineThickness = 4;
            this.tbUID.Location = new System.Drawing.Point(107, 229);
            this.tbUID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(164, 44);
            this.tbUID.TabIndex = 40;
            this.tbUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbName.LineThickness = 4;
            this.tbName.Location = new System.Drawing.Point(107, 81);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(453, 44);
            this.tbName.TabIndex = 37;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.White;
            this.QuitButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton.Image")));
            this.QuitButton.ImageActive = null;
            this.QuitButton.Location = new System.Drawing.Point(1035, 4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(37, 26);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuitButton.TabIndex = 38;
            this.QuitButton.TabStop = false;
            this.QuitButton.Zoom = 10;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Name*";
            // 
            // FrmNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 411);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbFunc);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewStaff";
            this.Text = "FrmNewStaff";
            ((System.ComponentModel.ISupportInitialize)(this.btnValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnValidate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private MaterialSkin.Controls.MaterialFlatButton btnCreate;
        private MaterialSkin.Controls.MaterialLabel lbTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPhoneNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbConfirmPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        private Bunifu.Framework.UI.BunifuImageButton QuitButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}