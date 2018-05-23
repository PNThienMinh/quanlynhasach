namespace UI
{
    partial class FrmNewCustomer
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
            this.btnCreate = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDistrict = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPhoneNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Depth = 0;
            this.btnCreate.Location = new System.Drawing.Point(526, 375);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = false;
            this.btnCreate.Size = new System.Drawing.Size(68, 36);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(328, 266);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(98, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Số điện thoại";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(30, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Quận/Huyện";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 266);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(412, 28);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Giới tính";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Tên khách hàng";
            // 
            // tbDistrict
            // 
            this.tbDistrict.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDistrict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDistrict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDistrict.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDistrict.HintForeColor = System.Drawing.Color.Gray;
            this.tbDistrict.HintText = "Thủ Đức";
            this.tbDistrict.isPassword = false;
            this.tbDistrict.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbDistrict.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDistrict.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbDistrict.LineThickness = 4;
            this.tbDistrict.Location = new System.Drawing.Point(34, 181);
            this.tbDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(259, 44);
            this.tbDistrict.TabIndex = 16;
            this.tbDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPhoneNo.HintForeColor = System.Drawing.Color.Gray;
            this.tbPhoneNo.HintText = "0968012012";
            this.tbPhoneNo.isPassword = false;
            this.tbPhoneNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPhoneNo.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPhoneNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPhoneNo.LineThickness = 4;
            this.tbPhoneNo.Location = new System.Drawing.Point(332, 309);
            this.tbPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(262, 44);
            this.tbPhoneNo.TabIndex = 18;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNo_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbEmail.HintForeColor = System.Drawing.Color.Gray;
            this.tbEmail.HintText = "abcd@xyz.com";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 4;
            this.tbEmail.Location = new System.Drawing.Point(34, 309);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(262, 44);
            this.tbEmail.TabIndex = 17;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbName.HintForeColor = System.Drawing.Color.Gray;
            this.tbName.HintText = "Nguyễn Văn A";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbName.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbName.LineThickness = 4;
            this.tbName.Location = new System.Drawing.Point(34, 66);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(328, 44);
            this.tbName.TabIndex = 8;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(328, 140);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(114, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Tỉnh/Thành phố";
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbCity.HintForeColor = System.Drawing.Color.Gray;
            this.tbCity.HintText = "Hồ Chí Minh";
            this.tbCity.isPassword = false;
            this.tbCity.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCity.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbCity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCity.LineThickness = 4;
            this.tbCity.Location = new System.Drawing.Point(332, 181);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(259, 44);
            this.tbCity.TabIndex = 16;
            this.tbCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ItemHeight = 19;
            this.cbSex.Location = new System.Drawing.Point(416, 83);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 27);
            this.cbSex.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(479, 375);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(39, 36);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 426);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbDistrict);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnCreate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbDistrict;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPhoneNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCity;
        private System.Windows.Forms.ComboBox cbSex;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
    }
}