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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooksReceipt));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiExportBooksReceiptNote = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiContract = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClear = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pgbAdding = new DevExpress.XtraEditors.ProgressBarControl();
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
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colRemove = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ssmWaiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.WaitForm1), true, true);
            this.gridLookUpBook = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpBookView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbAdding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInDocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBookView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiExportBooksReceiptNote,
            this.bbiAdd,
            this.bbiContract,
            this.bbiDelete,
            this.bbiClear,
            this.barStaticItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(864, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiExportBooksReceiptNote
            // 
            this.bbiExportBooksReceiptNote.Caption = "Xuất phiếu nhập";
            this.bbiExportBooksReceiptNote.Id = 14;
            this.bbiExportBooksReceiptNote.ImageUri.Uri = "ExportFile";
            this.bbiExportBooksReceiptNote.Name = "bbiExportBooksReceiptNote";
            this.bbiExportBooksReceiptNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportBooksReceiptNote_ItemClick);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Thêm sách";
            this.bbiAdd.Id = 16;
            this.bbiAdd.ImageUri.Uri = "ExportToXLS";
            this.bbiAdd.Name = "bbiAdd";
            toolTipTitleItem1.Text = "Thêm sách từ file Excel";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.bbiAdd.SuperTip = superToolTip1;
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
            toolTipTitleItem2.Text = "Quy định về số lượng nhập sách";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.bbiContract.SuperTip = superToolTip2;
            this.bbiContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiContract_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClear
            // 
            this.bbiClear.Caption = "Xoá hết";
            this.bbiClear.Id = 19;
            this.bbiClear.ImageUri.Uri = "Delete";
            this.bbiClear.Name = "bbiClear";
            this.bbiClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClear_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClear);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExportBooksReceiptNote);
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
            this.pgbAdding.Location = new System.Drawing.Point(497, 574);
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
            this.tlBookInDocket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tlBookInDocket.DataSource = this.bookBindingSource;
            this.tlBookInDocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBookInDocket.Location = new System.Drawing.Point(0, 143);
            this.tlBookInDocket.Name = "tlBookInDocket";
            this.tlBookInDocket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnRemove,
            this.repositoryItemSpinEdit1});
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
            this.colName.Width = 192;
            // 
            // colType
            // 
            this.colType.Caption = "Thể loại";
            this.colType.FieldName = "Category";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.ReadOnly = true;
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
            this.colPublishedDate.Width = 81;
            // 
            // colCost
            // 
            this.colCost.Caption = "Giá nhập";
            this.colCost.FieldName = "Cost";
            this.colCost.Format.FormatString = "#,#";
            this.colCost.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 2;
            this.colCost.Width = 77;
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Tác giả";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.ReadOnly = true;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 3;
            this.colAuthor.Width = 101;
            // 
            // colPublisher
            // 
            this.colPublisher.Caption = "Nhà xuất bản";
            this.colPublisher.FieldName = "Publisher";
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.OptionsColumn.ReadOnly = true;
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 4;
            this.colPublisher.Width = 141;
            // 
            // colIdentifier
            // 
            this.colIdentifier.Caption = "Mã sách";
            this.colIdentifier.FieldName = "Identifier";
            this.colIdentifier.Name = "colIdentifier";
            this.colIdentifier.OptionsColumn.ReadOnly = true;
            this.colIdentifier.Visible = true;
            this.colIdentifier.VisibleIndex = 0;
            this.colIdentifier.Width = 87;
            // 
            // colInventory
            // 
            this.colInventory.Caption = "Số lượng tồn";
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            this.colInventory.OptionsColumn.ReadOnly = true;
            this.colInventory.Visible = true;
            this.colInventory.VisibleIndex = 5;
            this.colInventory.Width = 96;
            // 
            // colCount
            // 
            this.colCount.Caption = "Số lượng nhập";
            this.colCount.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colCount.FieldName = "Count";
            this.colCount.Format.FormatString = "#,#";
            this.colCount.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 6;
            this.colCount.Width = 108;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
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
            this.colRemove.VisibleIndex = 7;
            this.colRemove.Width = 44;
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Appearance.Image")));
            this.btnRemove.Appearance.Options.UseImage = true;
            this.btnRemove.AutoHeight = false;
            this.btnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnRemove.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnRemove.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnRemove_ButtonClick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DTO.Book);
            // 
            // ssmWaiting
            // 
            this.ssmWaiting.ClosingDelay = 500;
            // 
            // gridLookUpBook
            // 
            this.gridLookUpBook.EditValue = "Tìm sách";
            this.gridLookUpBook.Location = new System.Drawing.Point(314, 89);
            this.gridLookUpBook.MenuManager = this.ribbonControl;
            this.gridLookUpBook.Name = "gridLookUpBook";
            this.gridLookUpBook.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpBook.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpBook.Properties.AutoComplete = false;
            this.gridLookUpBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.gridLookUpBook.Properties.DataSource = this.bookBindingSource;
            this.gridLookUpBook.Properties.DisplayMember = "Name";
            this.gridLookUpBook.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpBook.Properties.ValueMember = "ID";
            this.gridLookUpBook.Properties.View = this.gridLookUpBookView;
            this.gridLookUpBook.Size = new System.Drawing.Size(311, 22);
            this.gridLookUpBook.TabIndex = 23;
            this.gridLookUpBook.EditValueChanged += new System.EventHandler(this.gridLookUpBook_EditValueChanged);
            // 
            // gridLookUpBookView
            // 
            this.gridLookUpBookView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.gridColumn1,
            this.colCategory,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridLookUpBookView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpBookView.Name = "gridLookUpBookView";
            this.gridLookUpBookView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpBookView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpBookView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sách";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 402;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "PublishedDate";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Cost";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Author";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Publisher";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã sách";
            this.gridColumn6.FieldName = "Identifier";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 152;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "Count";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 215;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số lượng tồn";
            this.gridColumn8.FieldName = "Inventory";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm sách";
            // 
            // FrmBooksReceipt
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridLookUpBook);
            this.Controls.Add(this.tlBookInDocket);
            this.Controls.Add(this.pgbAdding);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBooksReceipt";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phiếu nhập sách";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbAdding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInDocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBookView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiExportBooksReceiptNote;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiContract;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClear;
        private DevExpress.XtraEditors.ProgressBarControl pgbAdding;
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInventory;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmWaiting;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpBookView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label1;
    }
}