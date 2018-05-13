namespace UI
{
    partial class FrmBooksReceipt
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooksReceipt));
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiContract = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pgbAdding = new DevExpress.XtraEditors.ProgressBarControl();
            this.tbSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tlBookInDocket = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublishedDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCost = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAuthor = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublisher = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdentifier = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInventory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemove = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbAdding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInDocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiAdd,
            this.bbiContract,
            this.bbiDelete,
            this.bbiRefresh,
            this.barStaticItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(864, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Xem trước";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Thêm sách";
            this.bbiAdd.Id = 16;
            this.bbiAdd.ImageUri.Uri = "ExportToXLS";
            this.bbiAdd.Name = "bbiAdd";
            toolTipTitleItem3.Text = "Thêm sách từ file Excel";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.bbiAdd.SuperTip = superToolTip3;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiContract
            // 
            this.bbiContract.Caption = "Quy định";
            this.bbiContract.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiContract.Glyph")));
            this.bbiContract.Id = 17;
            this.bbiContract.ImageUri.Uri = "Paste";
            this.bbiContract.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiContract.LargeGlyph")));
            this.bbiContract.Name = "bbiContract";
            toolTipTitleItem4.Text = "Quy định về số lượng nhập sách";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.bbiContract.SuperTip = superToolTip4;
            this.bbiContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiContract_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Làm mới";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 20;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nhập sách";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiContract);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(864, 31);
            // 
            // pgbAdding
            // 
            this.pgbAdding.Location = new System.Drawing.Point(440, 575);
            this.pgbAdding.MenuManager = this.ribbonControl;
            this.pgbAdding.Name = "pgbAdding";
            this.pgbAdding.Properties.EndColor = System.Drawing.Color.Lime;
            this.pgbAdding.Properties.ShowTitle = true;
            this.pgbAdding.Properties.StartColor = System.Drawing.Color.Lime;
            this.pgbAdding.Properties.Step = 1;
            this.pgbAdding.Size = new System.Drawing.Size(237, 18);
            this.pgbAdding.TabIndex = 4;
            this.pgbAdding.Visible = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearch.HintText = "Nhập mã sách";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(303, 68);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(298, 44);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // tlBookInDocket
            // 
            this.tlBookInDocket.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colType,
            this.colPublishedDate,
            this.colCost,
            this.colAuthor,
            this.colPublisher,
            this.colIdentifier,
            this.colInventory,
            this.colCount,
            this.colRemove});
            this.tlBookInDocket.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlBookInDocket.DataSource = this.bookBindingSource;
            this.tlBookInDocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBookInDocket.Location = new System.Drawing.Point(0, 143);
            this.tlBookInDocket.Name = "tlBookInDocket";
            this.tlBookInDocket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnRemove});
            this.tlBookInDocket.Size = new System.Drawing.Size(864, 425);
            this.tlBookInDocket.TabIndex = 11;
            // 
            // colName
            // 
            this.colName.Caption = "Tên sách";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 139;
            // 
            // colType
            // 
            this.colType.Caption = "Thể loại";
            this.colType.FieldName = "Category";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 93;
            // 
            // colPublishedDate
            // 
            this.colPublishedDate.Caption = "Ngày xuất bản";
            this.colPublishedDate.FieldName = "PublishedDate";
            this.colPublishedDate.Format.FormatString = "dd/MM/yyyy";
            this.colPublishedDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPublishedDate.Name = "colPublishedDate";
            this.colPublishedDate.OptionsColumn.ReadOnly = true;
            this.colPublishedDate.Visible = true;
            this.colPublishedDate.VisibleIndex = 3;
            this.colPublishedDate.Width = 81;
            // 
            // colCost
            // 
            this.colCost.Caption = "Giá nhập";
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 58;
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Tác giả";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.ReadOnly = true;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 5;
            this.colAuthor.Width = 82;
            // 
            // colPublisher
            // 
            this.colPublisher.Caption = "Nhà xuất bản";
            this.colPublisher.FieldName = "Publisher";
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.OptionsColumn.ReadOnly = true;
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 6;
            this.colPublisher.Width = 121;
            // 
            // colIdentifier
            // 
            this.colIdentifier.Caption = "Mã sách";
            this.colIdentifier.FieldName = "Identifier";
            this.colIdentifier.Name = "colIdentifier";
            this.colIdentifier.OptionsColumn.ReadOnly = true;
            this.colIdentifier.Visible = true;
            this.colIdentifier.VisibleIndex = 0;
            this.colIdentifier.Width = 63;
            // 
            // colInventory
            // 
            this.colInventory.Caption = "Số lượng tồn";
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            this.colInventory.OptionsColumn.ReadOnly = true;
            this.colInventory.Visible = true;
            this.colInventory.VisibleIndex = 7;
            this.colInventory.Width = 76;
            // 
            // colCount
            // 
            this.colCount.Caption = "Số lượng nhập";
            this.colCount.FieldName = "Count";
            this.colCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 8;
            this.colCount.Width = 89;
            // 
            // colRemove
            // 
            this.colRemove.ColumnEdit = this.btnRemove;
            this.colRemove.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colRemove.Name = "colRemove";
            this.colRemove.OptionsColumn.AllowSize = false;
            this.colRemove.OptionsColumn.FixedWidth = true;
            this.colRemove.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
            this.colRemove.Visible = true;
            this.colRemove.VisibleIndex = 9;
            this.colRemove.Width = 44;
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Appearance.Image")));
            this.btnRemove.Appearance.Options.UseImage = true;
            this.btnRemove.AutoHeight = false;
            this.btnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnRemove.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnRemove.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnRemove_ButtonClick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DTO.Book);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(636, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 31);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmBooksReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 599);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tlBookInDocket);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pgbAdding);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FrmBooksReceipt";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phiếu nhập sách";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbAdding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInDocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiContract;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.ProgressBarControl pgbAdding;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearch;
        private DevExpress.XtraTreeList.TreeList tlBookInDocket;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublishedDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCost;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAuthor;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublisher;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdentifier;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnRemove;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInventory;
        private System.Windows.Forms.BindingSource bookBindingSource;
    }
}