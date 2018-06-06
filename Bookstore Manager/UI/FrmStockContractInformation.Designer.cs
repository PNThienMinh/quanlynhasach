namespace UI
{
    partial class FrmStockContractInformation
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
            this.tbMinQuantityImport = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbMaxQuantityInventory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // tbMinQuantityImport
            // 
            this.tbMinQuantityImport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMinQuantityImport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbMinQuantityImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMinQuantityImport.HintForeColor = System.Drawing.Color.Empty;
            this.tbMinQuantityImport.HintText = "0";
            this.tbMinQuantityImport.isPassword = false;
            this.tbMinQuantityImport.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbMinQuantityImport.LineIdleColor = System.Drawing.Color.Gray;
            this.tbMinQuantityImport.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbMinQuantityImport.LineThickness = 3;
            this.tbMinQuantityImport.Location = new System.Drawing.Point(236, 0);
            this.tbMinQuantityImport.Margin = new System.Windows.Forms.Padding(4);
            this.tbMinQuantityImport.Name = "tbMinQuantityImport";
            this.tbMinQuantityImport.Size = new System.Drawing.Size(136, 44);
            this.tbMinQuantityImport.TabIndex = 0;
            this.tbMinQuantityImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMinQuantityImport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinQuantityImport_KeyPress);
            // 
            // tbMaxQuantityInventory
            // 
            this.tbMaxQuantityInventory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaxQuantityInventory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbMaxQuantityInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaxQuantityInventory.HintForeColor = System.Drawing.Color.Empty;
            this.tbMaxQuantityInventory.HintText = "0";
            this.tbMaxQuantityInventory.isPassword = false;
            this.tbMaxQuantityInventory.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbMaxQuantityInventory.LineIdleColor = System.Drawing.Color.Gray;
            this.tbMaxQuantityInventory.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbMaxQuantityInventory.LineThickness = 3;
            this.tbMaxQuantityInventory.Location = new System.Drawing.Point(236, 71);
            this.tbMaxQuantityInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxQuantityInventory.Name = "tbMaxQuantityInventory";
            this.tbMaxQuantityInventory.Size = new System.Drawing.Size(136, 44);
            this.tbMaxQuantityInventory.TabIndex = 1;
            this.tbMaxQuantityInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMaxQuantityInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxQuantityInventory_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Số lượng nhập tối thiểu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(214, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Số lượng tồn tối đa trước nhập";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(334, 125);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(38, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmStockContractInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 163);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbMaxQuantityInventory);
            this.Controls.Add(this.tbMinQuantityImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.Name = "FrmStockContractInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định nhập sách";
            this.Load += new System.EventHandler(this.FrmStockContractInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMinQuantityImport;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMaxQuantityInventory;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
    }
}