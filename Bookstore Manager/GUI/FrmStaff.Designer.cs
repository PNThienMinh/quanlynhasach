namespace GUI
{
    partial class FrmStaff
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.tbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgvListStaffs = new System.Windows.Forms.DataGridView();
            this.rowOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemDetail = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.itemDelete = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funtionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaffs)).BeginInit();
            this.rowOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(25, 12);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 27);
            this.tbSearch.TabIndex = 0;
            // 
            // dgvListStaffs
            // 
            this.dgvListStaffs.AllowUserToAddRows = false;
            this.dgvListStaffs.AllowUserToDeleteRows = false;
            this.dgvListStaffs.AllowUserToResizeColumns = false;
            this.dgvListStaffs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvListStaffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListStaffs.AutoGenerateColumns = false;
            this.dgvListStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dgvListStaffs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListStaffs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListStaffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListStaffs.ColumnHeadersHeight = 50;
            this.dgvListStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.nameDataGridViewTextBoxColumn,
            this.BirthDate,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.funtionDataGridViewTextBoxColumn});
            this.dgvListStaffs.ContextMenuStrip = this.rowOption;
            this.dgvListStaffs.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListStaffs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListStaffs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListStaffs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListStaffs.GridColor = System.Drawing.Color.White;
            this.dgvListStaffs.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvListStaffs.Location = new System.Drawing.Point(0, 61);
            this.dgvListStaffs.Margin = new System.Windows.Forms.Padding(10);
            this.dgvListStaffs.MultiSelect = false;
            this.dgvListStaffs.Name = "dgvListStaffs";
            this.dgvListStaffs.ReadOnly = true;
            this.dgvListStaffs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListStaffs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListStaffs.RowHeadersVisible = false;
            this.dgvListStaffs.RowHeadersWidth = 90;
            this.dgvListStaffs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvListStaffs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListStaffs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListStaffs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvListStaffs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvListStaffs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvListStaffs.RowTemplate.DividerHeight = 1;
            this.dgvListStaffs.RowTemplate.Height = 50;
            this.dgvListStaffs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListStaffs.Size = new System.Drawing.Size(633, 469);
            this.dgvListStaffs.StandardTab = true;
            this.dgvListStaffs.TabIndex = 1;
            this.dgvListStaffs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListStaffs_MouseDown);
            // 
            // rowOption
            // 
            this.rowOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDetail,
            this.itemDelete});
            this.rowOption.Name = "rowOption";
            this.rowOption.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.rowOption.Size = new System.Drawing.Size(108, 64);
            this.rowOption.Text = "Detail";
            // 
            // itemDetail
            // 
            this.itemDetail.AutoSize = false;
            this.itemDetail.Image = global::GUI.Properties.Resources.Menu_2_48px;
            this.itemDetail.Name = "itemDetail";
            this.itemDetail.Size = new System.Drawing.Size(120, 30);
            this.itemDetail.Text = "Detail";
            this.itemDetail.Click += new System.EventHandler(this.itemDetail_Click);
            // 
            // itemDelete
            // 
            this.itemDelete.AutoSize = false;
            this.itemDelete.Image = global::GUI.Properties.Resources.Close_Window_48px;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(120, 30);
            this.itemDelete.Text = "Delete";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DTO.User);
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btnNewStaff.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewStaff.BorderRadius = 0;
            this.btnNewStaff.ButtonText = "        New";
            this.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewStaff.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewStaff.Iconimage")));
            this.btnNewStaff.Iconimage_right = null;
            this.btnNewStaff.Iconimage_right_Selected = null;
            this.btnNewStaff.Iconimage_Selected = null;
            this.btnNewStaff.IconMarginLeft = 5;
            this.btnNewStaff.IconMarginRight = 0;
            this.btnNewStaff.IconRightVisible = false;
            this.btnNewStaff.IconRightZoom = 0D;
            this.btnNewStaff.IconVisible = true;
            this.btnNewStaff.IconZoom = 50D;
            this.btnNewStaff.IsTab = false;
            this.btnNewStaff.Location = new System.Drawing.Point(459, 12);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Normalcolor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewStaff.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btnNewStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewStaff.selected = false;
            this.btnNewStaff.Size = new System.Drawing.Size(81, 29);
            this.btnNewStaff.TabIndex = 1;
            this.btnNewStaff.Text = "        New";
            this.btnNewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewStaff.Textcolor = System.Drawing.Color.White;
            this.btnNewStaff.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            this.Username.Width = 102;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 90;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumDataGridViewTextBoxColumn.Width = 90;
            // 
            // funtionDataGridViewTextBoxColumn
            // 
            this.funtionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.funtionDataGridViewTextBoxColumn.DataPropertyName = "Funtion";
            this.funtionDataGridViewTextBoxColumn.HeaderText = "Funtion";
            this.funtionDataGridViewTextBoxColumn.Name = "funtionDataGridViewTextBoxColumn";
            this.funtionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 530);
            this.Controls.Add(this.dgvListStaffs);
            this.Controls.Add(this.btnNewStaff);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaffs)).EndInit();
            this.rowOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewStaff;
        private System.Windows.Forms.DataGridView dgvListStaffs;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip rowOption;
        private MaterialSkin.Controls.MaterialToolStripMenuItem itemDetail;
        private MaterialSkin.Controls.MaterialToolStripMenuItem itemDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funtionDataGridViewTextBoxColumn;
    }
}