namespace UI
{
    partial class FrmBookDetail
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
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbBookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbAuthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbCategory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPublisher = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPublishDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(831, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(38, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(774, 448);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(39, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(247, 353);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 18);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Giá nhập";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(591, 246);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(101, 18);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Ngày xuất bản";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(247, 246);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(94, 18);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Nhà xuất bản";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(591, 130);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 18);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Thể loại";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(247, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 18);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Tác giả";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(247, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Tên sách";
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCost.Enabled = false;
            this.tbCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.ForeColor = System.Drawing.Color.Black;
            this.tbCost.HintForeColor = System.Drawing.Color.Empty;
            this.tbCost.HintText = "";
            this.tbCost.isPassword = false;
            this.tbCost.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCost.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbCost.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCost.LineThickness = 4;
            this.tbCost.Location = new System.Drawing.Point(251, 376);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(262, 44);
            this.tbCost.TabIndex = 5;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // tbBookName
            // 
            this.tbBookName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookName.Enabled = false;
            this.tbBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookName.ForeColor = System.Drawing.Color.Black;
            this.tbBookName.HintForeColor = System.Drawing.Color.Empty;
            this.tbBookName.HintText = "";
            this.tbBookName.isPassword = false;
            this.tbBookName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbBookName.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbBookName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbBookName.LineThickness = 4;
            this.tbBookName.Location = new System.Drawing.Point(251, 51);
            this.tbBookName.Margin = new System.Windows.Forms.Padding(4);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(370, 44);
            this.tbBookName.TabIndex = 0;
            this.tbBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbAuthor
            // 
            this.tbAuthor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthor.Enabled = false;
            this.tbAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.ForeColor = System.Drawing.Color.Black;
            this.tbAuthor.HintForeColor = System.Drawing.Color.Empty;
            this.tbAuthor.HintText = "";
            this.tbAuthor.isPassword = false;
            this.tbAuthor.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbAuthor.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbAuthor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbAuthor.LineThickness = 4;
            this.tbAuthor.Location = new System.Drawing.Point(251, 153);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(262, 44);
            this.tbAuthor.TabIndex = 1;
            this.tbAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbCategory
            // 
            this.tbCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCategory.Enabled = false;
            this.tbCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.ForeColor = System.Drawing.Color.Black;
            this.tbCategory.HintForeColor = System.Drawing.Color.Empty;
            this.tbCategory.HintText = "";
            this.tbCategory.isPassword = false;
            this.tbCategory.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCategory.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbCategory.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCategory.LineThickness = 4;
            this.tbCategory.Location = new System.Drawing.Point(595, 153);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(259, 44);
            this.tbCategory.TabIndex = 2;
            this.tbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPublisher
            // 
            this.tbPublisher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPublisher.Enabled = false;
            this.tbPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublisher.ForeColor = System.Drawing.Color.Black;
            this.tbPublisher.HintForeColor = System.Drawing.Color.Empty;
            this.tbPublisher.HintText = "";
            this.tbPublisher.isPassword = false;
            this.tbPublisher.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPublisher.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPublisher.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPublisher.LineThickness = 4;
            this.tbPublisher.Location = new System.Drawing.Point(251, 289);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(262, 44);
            this.tbPublisher.TabIndex = 3;
            this.tbPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbPublishDate
            // 
            this.tbPublishDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPublishDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPublishDate.Enabled = false;
            this.tbPublishDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublishDate.ForeColor = System.Drawing.Color.Black;
            this.tbPublishDate.HintForeColor = System.Drawing.Color.Empty;
            this.tbPublishDate.HintText = "";
            this.tbPublishDate.isPassword = false;
            this.tbPublishDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPublishDate.LineIdleColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbPublishDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPublishDate.LineThickness = 4;
            this.tbPublishDate.Location = new System.Drawing.Point(592, 289);
            this.tbPublishDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublishDate.Name = "tbPublishDate";
            this.tbPublishDate.Size = new System.Drawing.Size(262, 44);
            this.tbPublishDate.TabIndex = 4;
            this.tbPublishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::UI.Properties.Resources.book_PNG2118;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBookDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(891, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbPublishDate);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbBookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.FrmBookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCost;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbBookName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbAuthor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPublisher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPublishDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}