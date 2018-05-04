namespace GUI
{
    partial class FrmStore
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnImportBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImport.Location = new System.Drawing.Point(91, 29);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(163, 60);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import From Excel";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImportBook
            // 
            this.btnImportBook.Location = new System.Drawing.Point(355, 148);
            this.btnImportBook.Name = "btnImportBook";
            this.btnImportBook.Size = new System.Drawing.Size(75, 23);
            this.btnImportBook.TabIndex = 1;
            this.btnImportBook.Text = "Nhập sách";
            this.btnImportBook.UseVisualStyleBackColor = true;
            this.btnImportBook.Click += new System.EventHandler(this.btnImportBook_Click);
            // 
            // FrmStore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 530);
            this.Controls.Add(this.btnImportBook);
            this.Controls.Add(this.btnImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStore";
            this.Text = "FrmStore";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnImportBook;
    }
}