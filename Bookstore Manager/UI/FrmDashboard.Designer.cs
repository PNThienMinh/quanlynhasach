namespace UI
{
    partial class FrmDashboard
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ssmLoading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.FrmWaiting), true, true);
            this.btnDeleteCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.bookstallTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.custommerTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.stockTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.reportTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.staffTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.adminTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.bookstallNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tlBookInBill = new DevExpress.XtraTreeList.TreeList();
            this.colBookNameInBill = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublishedDate1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCost1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAuthor1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublisher1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdentifier1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDeleteBookInBill = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBackToEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowBillInfo = new Bunifu.Framework.UI.BunifuImageButton();
            this.gridLookUpBook = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelBillInfo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomerPaid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChange = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIndebtedness = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelCustomerSearch = new System.Windows.Forms.Panel();
            this.gridLookUpCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.btnCheckout = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.customerNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tlCustomer = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSex1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAddress1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEmail1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhoneNum1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIndebtedness = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colReceive = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnReceive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCustomerDetail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDetailCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnNewCustomer = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbSearchCustomer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stockNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tlBooksInStock = new DevExpress.XtraTreeList.TreeList();
            this.colBookInStockName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublishedDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCost = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAuthor = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublisher = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdentifier = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInventory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnBookDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnImport = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbSearchBookInStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.staffNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tlStaff = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBirthDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEmail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhoneNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFuntion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUsername = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDetail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbSearchStaff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reportNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tlIndebtednessReport = new DevExpress.XtraTreeList.TreeList();
            this.colCustomerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTime1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInEarly1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOnArise1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInLast1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.indebtednessReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlInventoryReport = new DevExpress.XtraTreeList.TreeList();
            this.colBookID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBookName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTime = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInEarly = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOnArise = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInLast = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.inventoryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnShowReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.datePickerReport = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIndebtednessReport = new System.Windows.Forms.RadioButton();
            this.rbInventoryReport = new System.Windows.Forms.RadioButton();
            this.adminNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.lbNumBookSold = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.lbNumBookImport = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.lbNumBookInStock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tbMaxIndebtedness = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbMinLastInventory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbMaxInventory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbMinImport = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.bookstallNavigationPage.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBookInBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelBillInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panelCheckout.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.customerNavigationPage.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewCustomer)).BeginInit();
            this.panel11.SuspendLayout();
            this.stockNavigationPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlBooksInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            this.panel12.SuspendLayout();
            this.staffNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStaff)).BeginInit();
            this.panel14.SuspendLayout();
            this.reportNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlIndebtednessReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indebtednessReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReportBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.adminNavigationPage.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssmLoading
            // 
            this.ssmLoading.ClosingDelay = 500;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.AutoHeight = false;
            this.btnDeleteCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.AppearanceItem.Normal.BackColor = System.Drawing.Color.DodgerBlue;
            this.tileBar.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBar.AppearanceItem.Pressed.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileBar.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 9;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1025, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.bookstallTileBarItem);
            this.tileBarGroupTables.Items.Add(this.custommerTileBarItem);
            this.tileBarGroupTables.Items.Add(this.stockTileBarItem);
            this.tileBarGroupTables.Items.Add(this.reportTileBarItem);
            this.tileBarGroupTables.Items.Add(this.staffTileBarItem);
            this.tileBarGroupTables.Items.Add(this.adminTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // bookstallTileBarItem
            // 
            this.bookstallTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bookstallTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bookstallTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.bookstallTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookstallTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.bookstallTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.bookstallTileBarItem.AppearanceItem.Selected.Options.UseImage = true;
            this.bookstallTileBarItem.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.bookstallTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.bookstallTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::UI.Properties.Resources.morefunctions_32x32;
            tileItemElement1.ImageUri.Uri = "Copy";
            tileItemElement1.Text = "Quầy sách";
            this.bookstallTileBarItem.Elements.Add(tileItemElement1);
            this.bookstallTileBarItem.Id = 1;
            this.bookstallTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.bookstallTileBarItem.Name = "bookstallTileBarItem";
            // 
            // custommerTileBarItem
            // 
            this.custommerTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.custommerTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.custommerTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.custommerTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custommerTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.custommerTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.custommerTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.custommerTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = global::UI.Properties.Resources.bocustomer_32x32;
            tileItemElement2.Text = "Khách hàng";
            this.custommerTileBarItem.Elements.Add(tileItemElement2);
            this.custommerTileBarItem.Id = 2;
            this.custommerTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.custommerTileBarItem.Name = "custommerTileBarItem";
            // 
            // stockTileBarItem
            // 
            this.stockTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.stockTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.stockTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.stockTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.stockTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.stockTileBarItem.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.stockTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.stockTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::UI.Properties.Resources.open_32x32;
            tileItemElement3.Text = "Kho";
            this.stockTileBarItem.Elements.Add(tileItemElement3);
            this.stockTileBarItem.Id = 3;
            this.stockTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.stockTileBarItem.Name = "stockTileBarItem";
            // 
            // reportTileBarItem
            // 
            this.reportTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.reportTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reportTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.reportTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.reportTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.reportTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.reportTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.reportTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.Text = "Báo cáo tháng";
            this.reportTileBarItem.Elements.Add(tileItemElement4);
            this.reportTileBarItem.Id = 4;
            this.reportTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.reportTileBarItem.Name = "reportTileBarItem";
            // 
            // staffTileBarItem
            // 
            this.staffTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.staffTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.staffTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.staffTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.staffTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.staffTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.staffTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = global::UI.Properties.Resources.bodepartment_32x32;
            tileItemElement5.Text = "Nhân viên";
            this.staffTileBarItem.Elements.Add(tileItemElement5);
            this.staffTileBarItem.Id = 6;
            this.staffTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.staffTileBarItem.Name = "staffTileBarItem";
            // 
            // adminTileBarItem
            // 
            this.adminTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.adminTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.DodgerBlue;
            this.adminTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.adminTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.adminTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.adminTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.Text = "Quản trị";
            this.adminTileBarItem.Elements.Add(tileItemElement6);
            this.adminTileBarItem.Id = 8;
            this.adminTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.adminTileBarItem.Name = "adminTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.bookstallNavigationPage);
            this.navigationFrame.Controls.Add(this.customerNavigationPage);
            this.navigationFrame.Controls.Add(this.stockNavigationPage);
            this.navigationFrame.Controls.Add(this.staffNavigationPage);
            this.navigationFrame.Controls.Add(this.reportNavigationPage);
            this.navigationFrame.Controls.Add(this.adminNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.bookstallNavigationPage,
            this.customerNavigationPage,
            this.stockNavigationPage,
            this.reportNavigationPage,
            this.staffNavigationPage,
            this.adminNavigationPage});
            this.navigationFrame.SelectedPage = this.bookstallNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1025, 451);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 500;
            this.navigationFrame.TransitionAnimationProperties.FrameInterval = 5000;
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // bookstallNavigationPage
            // 
            this.bookstallNavigationPage.Caption = "bookstallNavigationPage";
            this.bookstallNavigationPage.Controls.Add(this.panel7);
            this.bookstallNavigationPage.Controls.Add(this.panel6);
            this.bookstallNavigationPage.Controls.Add(this.panel5);
            this.bookstallNavigationPage.Name = "bookstallNavigationPage";
            this.bookstallNavigationPage.Size = new System.Drawing.Size(1025, 451);
            this.bookstallNavigationPage.VisibleChanged += new System.EventHandler(this.bookstallNavigationPage_VisibleChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tlBookInBill);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 92);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(649, 359);
            this.panel7.TabIndex = 2;
            // 
            // tlBookInBill
            // 
            this.tlBookInBill.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colBookNameInBill,
            this.colCategory,
            this.colPublishedDate1,
            this.colCost1,
            this.colAuthor1,
            this.colPublisher1,
            this.colIdentifier1,
            this.colCount,
            this.treeListColumn1});
            this.tlBookInBill.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tlBookInBill.DataSource = this.bookBindingSource;
            this.tlBookInBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBookInBill.Location = new System.Drawing.Point(0, 0);
            this.tlBookInBill.Name = "tlBookInBill";
            this.tlBookInBill.OptionsBehavior.PopulateServiceColumns = true;
            this.tlBookInBill.OptionsView.ShowSummaryFooter = true;
            this.tlBookInBill.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.btnDeleteBookInBill});
            this.tlBookInBill.RowHeight = 30;
            this.tlBookInBill.Size = new System.Drawing.Size(649, 359);
            this.tlBookInBill.TabIndex = 0;
            // 
            // colBookNameInBill
            // 
            this.colBookNameInBill.Caption = "Tên sách";
            this.colBookNameInBill.FieldName = "Name";
            this.colBookNameInBill.Name = "colBookNameInBill";
            this.colBookNameInBill.OptionsColumn.AllowEdit = false;
            this.colBookNameInBill.OptionsColumn.AllowSize = false;
            this.colBookNameInBill.OptionsColumn.ReadOnly = true;
            this.colBookNameInBill.Visible = true;
            this.colBookNameInBill.VisibleIndex = 1;
            this.colBookNameInBill.Width = 262;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 102;
            // 
            // colPublishedDate1
            // 
            this.colPublishedDate1.FieldName = "PublishedDate";
            this.colPublishedDate1.Name = "colPublishedDate1";
            this.colPublishedDate1.Width = 102;
            // 
            // colCost1
            // 
            this.colCost1.Caption = "Đơn giá";
            this.colCost1.FieldName = "Cost";
            this.colCost1.Format.FormatString = "#,#";
            this.colCost1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCost1.Name = "colCost1";
            this.colCost1.OptionsColumn.AllowEdit = false;
            this.colCost1.OptionsColumn.AllowSize = false;
            this.colCost1.OptionsColumn.ReadOnly = true;
            this.colCost1.Visible = true;
            this.colCost1.VisibleIndex = 3;
            this.colCost1.Width = 106;
            // 
            // colAuthor1
            // 
            this.colAuthor1.Caption = "Tác giả";
            this.colAuthor1.FieldName = "Author";
            this.colAuthor1.Name = "colAuthor1";
            this.colAuthor1.OptionsColumn.AllowEdit = false;
            this.colAuthor1.OptionsColumn.AllowSize = false;
            this.colAuthor1.OptionsColumn.ReadOnly = true;
            this.colAuthor1.Visible = true;
            this.colAuthor1.VisibleIndex = 2;
            this.colAuthor1.Width = 92;
            // 
            // colPublisher1
            // 
            this.colPublisher1.FieldName = "Publisher";
            this.colPublisher1.Name = "colPublisher1";
            this.colPublisher1.Width = 85;
            // 
            // colIdentifier1
            // 
            this.colIdentifier1.Caption = "Mã sách";
            this.colIdentifier1.FieldName = "Identifier";
            this.colIdentifier1.Name = "colIdentifier1";
            this.colIdentifier1.OptionsColumn.AllowEdit = false;
            this.colIdentifier1.OptionsColumn.AllowSize = false;
            this.colIdentifier1.OptionsColumn.ReadOnly = true;
            this.colIdentifier1.Visible = true;
            this.colIdentifier1.VisibleIndex = 0;
            this.colIdentifier1.Width = 67;
            // 
            // colCount
            // 
            this.colCount.Caption = "Số lượng";
            this.colCount.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.AllowSize = false;
            this.colCount.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colCount.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.colCount.SummaryFooterStrFormat = "Số lượng: {00}";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 4;
            this.colCount.Width = 125;
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
            // treeListColumn1
            // 
            this.treeListColumn1.ColumnEdit = this.btnDeleteBookInBill;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.FixedWidth = true;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 5;
            this.treeListColumn1.Width = 33;
            // 
            // btnDeleteBookInBill
            // 
            this.btnDeleteBookInBill.AutoHeight = false;
            this.btnDeleteBookInBill.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.btnDeleteBookInBill.Name = "btnDeleteBookInBill";
            this.btnDeleteBookInBill.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteBookInBill.Click += new System.EventHandler(this.btnDeleteBookInBill_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DTO.Book);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.btnBackToEdit);
            this.panel6.Controls.Add(this.btnShowBillInfo);
            this.panel6.Controls.Add(this.gridLookUpBook);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(649, 92);
            this.panel6.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tìm sách";
            // 
            // btnBackToEdit
            // 
            this.btnBackToEdit.BackColor = System.Drawing.Color.White;
            this.btnBackToEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBackToEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToEdit.Image")));
            this.btnBackToEdit.ImageActive = null;
            this.btnBackToEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackToEdit.InitialImage")));
            this.btnBackToEdit.Location = new System.Drawing.Point(567, 0);
            this.btnBackToEdit.Name = "btnBackToEdit";
            this.btnBackToEdit.Size = new System.Drawing.Size(41, 92);
            this.btnBackToEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBackToEdit.TabIndex = 6;
            this.btnBackToEdit.TabStop = false;
            this.btnBackToEdit.Visible = false;
            this.btnBackToEdit.Zoom = 10;
            this.btnBackToEdit.Click += new System.EventHandler(this.btnBackToEdit_Click);
            // 
            // btnShowBillInfo
            // 
            this.btnShowBillInfo.BackColor = System.Drawing.Color.White;
            this.btnShowBillInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowBillInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowBillInfo.Image")));
            this.btnShowBillInfo.ImageActive = null;
            this.btnShowBillInfo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnShowBillInfo.InitialImage")));
            this.btnShowBillInfo.Location = new System.Drawing.Point(608, 0);
            this.btnShowBillInfo.Name = "btnShowBillInfo";
            this.btnShowBillInfo.Size = new System.Drawing.Size(41, 92);
            this.btnShowBillInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShowBillInfo.TabIndex = 5;
            this.btnShowBillInfo.TabStop = false;
            this.btnShowBillInfo.Zoom = 10;
            this.btnShowBillInfo.Click += new System.EventHandler(this.btnShowBillInfo_Click);
            // 
            // gridLookUpBook
            // 
            this.gridLookUpBook.EditValue = "Tìm kiếm";
            this.gridLookUpBook.Location = new System.Drawing.Point(46, 38);
            this.gridLookUpBook.Name = "gridLookUpBook";
            this.gridLookUpBook.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpBook.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpBook.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridLookUpBook.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpBook.Properties.Appearance.Options.UseForeColor = true;
            this.gridLookUpBook.Properties.AutoComplete = false;
            this.gridLookUpBook.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.gridLookUpBook.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridLookUpBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gridLookUpBook.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridLookUpBook.Properties.DataSource = this.bookBindingSource;
            this.gridLookUpBook.Properties.DisplayMember = "Name";
            this.gridLookUpBook.Properties.NullText = "Tìm kiếm";
            this.gridLookUpBook.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpBook.Properties.ValueMember = "ID";
            this.gridLookUpBook.Properties.View = this.gridLookUpView;
            this.gridLookUpBook.Size = new System.Drawing.Size(276, 24);
            this.gridLookUpBook.TabIndex = 0;
            this.gridLookUpBook.EditValueChanged += new System.EventHandler(this.gridLookUpBook_EditValueChanged);
            // 
            // gridLookUpView
            // 
            this.gridLookUpView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridLookUpView.FixedLineWidth = 3;
            this.gridLookUpView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpView.Name = "gridLookUpView";
            this.gridLookUpView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpView.OptionsCustomization.AllowColumnMoving = false;
            this.gridLookUpView.OptionsCustomization.AllowColumnResizing = false;
            this.gridLookUpView.OptionsCustomization.AllowRowSizing = true;
            this.gridLookUpView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpView.OptionsView.RowAutoHeight = true;
            this.gridLookUpView.OptionsView.ShowGroupPanel = false;
            this.gridLookUpView.PreviewLineCount = 5;
            this.gridLookUpView.RowHeight = 40;
            this.gridLookUpView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 389;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Category";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "PublishedDate";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Cost";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tác giả";
            this.gridColumn5.FieldName = "Author";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 230;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Publisher";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã sách";
            this.gridColumn7.FieldName = "Identifier";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 155;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "Count";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Hiện còn";
            this.gridColumn9.FieldName = "Inventory";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 152;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panelStatus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(649, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 451);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panelBillInfo);
            this.panel9.Controls.Add(this.panelCustomerSearch);
            this.panel9.Controls.Add(this.panelCheckout);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(376, 389);
            this.panel9.TabIndex = 1;
            // 
            // panelBillInfo
            // 
            this.panelBillInfo.Controls.Add(this.groupBox3);
            this.panelBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillInfo.Location = new System.Drawing.Point(0, 50);
            this.panelBillInfo.Name = "panelBillInfo";
            this.panelBillInfo.Size = new System.Drawing.Size(376, 290);
            this.panelBillInfo.TabIndex = 3;
            this.panelBillInfo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbCustomerPaid);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbChange);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbIndebtedness);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 290);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hoá đơn";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbTotal.BorderThickness = 2;
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTotal.isPassword = false;
            this.tbTotal.Location = new System.Drawing.Point(169, 32);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(175, 31);
            this.tbTotal.TabIndex = 1;
            this.tbTotal.Text = "0";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "đ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tính vào công nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "đ";
            // 
            // tbCustomerPaid
            // 
            this.tbCustomerPaid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbCustomerPaid.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbCustomerPaid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomerPaid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbCustomerPaid.BorderThickness = 2;
            this.tbCustomerPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomerPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCustomerPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCustomerPaid.isPassword = false;
            this.tbCustomerPaid.Location = new System.Drawing.Point(169, 93);
            this.tbCustomerPaid.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerPaid.Name = "tbCustomerPaid";
            this.tbCustomerPaid.Size = new System.Drawing.Size(175, 31);
            this.tbCustomerPaid.TabIndex = 1;
            this.tbCustomerPaid.Text = "0";
            this.tbCustomerPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCustomerPaid.OnValueChanged += new System.EventHandler(this.tbCustomerPaid_OnValueChanged);
            this.tbCustomerPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerPaid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền thừa trả khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "đ";
            // 
            // tbChange
            // 
            this.tbChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbChange.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbChange.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbChange.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbChange.BorderThickness = 2;
            this.tbChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbChange.Enabled = false;
            this.tbChange.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbChange.isPassword = false;
            this.tbChange.Location = new System.Drawing.Point(169, 160);
            this.tbChange.Margin = new System.Windows.Forms.Padding(4);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(175, 31);
            this.tbChange.TabIndex = 1;
            this.tbChange.Text = "0";
            this.tbChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khách thanh toán";
            // 
            // tbIndebtedness
            // 
            this.tbIndebtedness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbIndebtedness.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbIndebtedness.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIndebtedness.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbIndebtedness.BorderThickness = 2;
            this.tbIndebtedness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIndebtedness.Enabled = false;
            this.tbIndebtedness.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbIndebtedness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIndebtedness.isPassword = false;
            this.tbIndebtedness.Location = new System.Drawing.Point(169, 227);
            this.tbIndebtedness.Margin = new System.Windows.Forms.Padding(4);
            this.tbIndebtedness.Name = "tbIndebtedness";
            this.tbIndebtedness.Size = new System.Drawing.Size(175, 31);
            this.tbIndebtedness.TabIndex = 1;
            this.tbIndebtedness.Text = "0";
            this.tbIndebtedness.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelCustomerSearch
            // 
            this.panelCustomerSearch.Controls.Add(this.gridLookUpCustomer);
            this.panelCustomerSearch.Controls.Add(this.label8);
            this.panelCustomerSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerSearch.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerSearch.Name = "panelCustomerSearch";
            this.panelCustomerSearch.Size = new System.Drawing.Size(376, 50);
            this.panelCustomerSearch.TabIndex = 2;
            this.panelCustomerSearch.Visible = false;
            // 
            // gridLookUpCustomer
            // 
            this.gridLookUpCustomer.EditValue = "[Tên khách hàng]";
            this.gridLookUpCustomer.Location = new System.Drawing.Point(124, 12);
            this.gridLookUpCustomer.Name = "gridLookUpCustomer";
            this.gridLookUpCustomer.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpCustomer.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpCustomer.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpCustomer.Properties.AutoComplete = false;
            this.gridLookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.gridLookUpCustomer.Properties.DataSource = this.customerBindingSource;
            this.gridLookUpCustomer.Properties.DisplayMember = "Name";
            this.gridLookUpCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpCustomer.Properties.ValueMember = "ID";
            this.gridLookUpCustomer.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpCustomer.Size = new System.Drawing.Size(239, 22);
            this.gridLookUpCustomer.TabIndex = 0;
            this.gridLookUpCustomer.EditValueChanged += new System.EventHandler(this.gridLookUpCustomer_EditValueChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DTO.Customer);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.colAddress,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.RowHeight = 30;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã khách hàng";
            this.gridColumn10.FieldName = "ID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 131;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên khách hàng";
            this.gridColumn11.FieldName = "Name";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 565;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "Sex";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "Email";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "PhoneNum";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "Indebtedness";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khách hàng";
            // 
            // panelCheckout
            // 
            this.panelCheckout.Controls.Add(this.btnCheckout);
            this.panelCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCheckout.Location = new System.Drawing.Point(0, 340);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(376, 49);
            this.panelCheckout.TabIndex = 1;
            this.panelCheckout.Visible = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckout.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckout.Depth = 0;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckout.ForeColor = System.Drawing.Color.Yellow;
            this.btnCheckout.Location = new System.Drawing.Point(0, 0);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Primary = false;
            this.btnCheckout.Size = new System.Drawing.Size(376, 49);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "THANH TOÁN";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.groupBox2);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(376, 62);
            this.panelStatus.TabIndex = 0;
            this.panelStatus.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStaff);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giao dịch";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.Blue;
            this.lblStaff.Location = new System.Drawing.Point(20, 30);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(69, 14);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Nhân viên: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(289, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 14);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "22/12/2017";
            // 
            // customerNavigationPage
            // 
            this.customerNavigationPage.Caption = "customerNavigationPage";
            this.customerNavigationPage.Controls.Add(this.panel10);
            this.customerNavigationPage.Controls.Add(this.panel1);
            this.customerNavigationPage.Name = "customerNavigationPage";
            this.customerNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tlCustomer);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1025, 403);
            this.panel10.TabIndex = 1;
            // 
            // tlCustomer
            // 
            this.tlCustomer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1,
            this.colSex1,
            this.colAddress1,
            this.colEmail1,
            this.colPhoneNum1,
            this.colIndebtedness,
            this.colReceive,
            this.colCustomerDetail});
            this.tlCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlCustomer.DataSource = this.customerBindingSource;
            this.tlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCustomer.Location = new System.Drawing.Point(0, 0);
            this.tlCustomer.Name = "tlCustomer";
            this.tlCustomer.OptionsBehavior.PopulateServiceColumns = true;
            this.tlCustomer.OptionsNavigation.AutoMoveRowFocus = true;
            this.tlCustomer.OptionsNavigation.UseTabKey = true;
            this.tlCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnReceive,
            this.btnDetailCustomer});
            this.tlCustomer.RowHeight = 30;
            this.tlCustomer.Size = new System.Drawing.Size(1025, 403);
            this.tlCustomer.TabIndex = 0;
            this.tlCustomer.VisibleChanged += new System.EventHandler(this.LoadCustomers);
            // 
            // colName1
            // 
            this.colName1.Caption = "Tên khách hàng";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowEdit = false;
            this.colName1.OptionsColumn.ReadOnly = true;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 231;
            // 
            // colSex1
            // 
            this.colSex1.Caption = "Giới tính";
            this.colSex1.FieldName = "Sex";
            this.colSex1.Name = "colSex1";
            this.colSex1.OptionsColumn.AllowEdit = false;
            this.colSex1.OptionsColumn.ReadOnly = true;
            this.colSex1.Visible = true;
            this.colSex1.VisibleIndex = 1;
            this.colSex1.Width = 74;
            // 
            // colAddress1
            // 
            this.colAddress1.Caption = "Địa Chỉ";
            this.colAddress1.FieldName = "Address";
            this.colAddress1.Name = "colAddress1";
            this.colAddress1.OptionsColumn.AllowEdit = false;
            this.colAddress1.OptionsColumn.ReadOnly = true;
            this.colAddress1.Visible = true;
            this.colAddress1.VisibleIndex = 2;
            this.colAddress1.Width = 145;
            // 
            // colEmail1
            // 
            this.colEmail1.Caption = "Email";
            this.colEmail1.FieldName = "Email";
            this.colEmail1.Name = "colEmail1";
            this.colEmail1.OptionsColumn.AllowEdit = false;
            this.colEmail1.OptionsColumn.ReadOnly = true;
            this.colEmail1.Visible = true;
            this.colEmail1.VisibleIndex = 3;
            this.colEmail1.Width = 195;
            // 
            // colPhoneNum1
            // 
            this.colPhoneNum1.Caption = "Số điện thoại";
            this.colPhoneNum1.FieldName = "PhoneNum";
            this.colPhoneNum1.Name = "colPhoneNum1";
            this.colPhoneNum1.OptionsColumn.AllowEdit = false;
            this.colPhoneNum1.OptionsColumn.ReadOnly = true;
            this.colPhoneNum1.Visible = true;
            this.colPhoneNum1.VisibleIndex = 4;
            this.colPhoneNum1.Width = 154;
            // 
            // colIndebtedness
            // 
            this.colIndebtedness.Caption = "Số tiền nợ";
            this.colIndebtedness.FieldName = "Indebtedness";
            this.colIndebtedness.Name = "colIndebtedness";
            this.colIndebtedness.OptionsColumn.AllowEdit = false;
            this.colIndebtedness.OptionsColumn.ReadOnly = true;
            this.colIndebtedness.Visible = true;
            this.colIndebtedness.VisibleIndex = 5;
            this.colIndebtedness.Width = 107;
            // 
            // colReceive
            // 
            this.colReceive.ColumnEdit = this.btnReceive;
            this.colReceive.Name = "colReceive";
            this.colReceive.OptionsColumn.AllowMove = false;
            this.colReceive.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colReceive.OptionsColumn.AllowSize = false;
            this.colReceive.OptionsColumn.FixedWidth = true;
            this.colReceive.ToolTip = "Thu tiền nợ";
            this.colReceive.Visible = true;
            this.colReceive.VisibleIndex = 6;
            this.colReceive.Width = 49;
            // 
            // btnReceive
            // 
            this.btnReceive.AutoHeight = false;
            this.btnReceive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnReceive.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // colCustomerDetail
            // 
            this.colCustomerDetail.ColumnEdit = this.btnDetailCustomer;
            this.colCustomerDetail.Name = "colCustomerDetail";
            this.colCustomerDetail.OptionsColumn.AllowMove = false;
            this.colCustomerDetail.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colCustomerDetail.OptionsColumn.AllowSize = false;
            this.colCustomerDetail.OptionsColumn.FixedWidth = true;
            this.colCustomerDetail.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.colCustomerDetail.ToolTip = "Chi tiết";
            this.colCustomerDetail.Visible = true;
            this.colCustomerDetail.VisibleIndex = 7;
            this.colCustomerDetail.Width = 52;
            // 
            // btnDetailCustomer
            // 
            this.btnDetailCustomer.AutoHeight = false;
            this.btnDetailCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDetailCustomer.Name = "btnDetailCustomer";
            this.btnDetailCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetailCustomer.Click += new System.EventHandler(this.btnDetailCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel30);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Transparent;
            this.panel30.Controls.Add(this.materialLabel4);
            this.panel30.Controls.Add(this.btnNewCustomer);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel30.Location = new System.Drawing.Point(811, 0);
            this.panel30.Name = "panel30";
            this.panel30.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel30.Size = new System.Drawing.Size(214, 48);
            this.panel30.TabIndex = 1;
            this.panel30.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(81, 16);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(126, 18);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Thêm khách hàng";
            this.materialLabel4.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageActive = null;
            this.btnNewCustomer.Location = new System.Drawing.Point(18, 5);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(61, 39);
            this.btnNewCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.TabStop = false;
            this.btnNewCustomer.Zoom = 10;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbSearchCustomer);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(423, 48);
            this.panel11.TabIndex = 0;
            // 
            // tbSearchCustomer
            // 
            this.tbSearchCustomer.BackColor = System.Drawing.Color.White;
            this.tbSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.tbSearchCustomer.HintForeColor = System.Drawing.Color.DimGray;
            this.tbSearchCustomer.HintText = "Tìm kiếm";
            this.tbSearchCustomer.isPassword = false;
            this.tbSearchCustomer.LineFocusedColor = System.Drawing.Color.DimGray;
            this.tbSearchCustomer.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tbSearchCustomer.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.tbSearchCustomer.LineThickness = 3;
            this.tbSearchCustomer.Location = new System.Drawing.Point(35, 9);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(370, 35);
            this.tbSearchCustomer.TabIndex = 3;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchCustomer.OnValueChanged += new System.EventHandler(this.tbSearchCustomer_OnValueChanged);
            // 
            // stockNavigationPage
            // 
            this.stockNavigationPage.AllowTouchScroll = true;
            this.stockNavigationPage.Caption = "stockNavigationPage";
            this.stockNavigationPage.Controls.Add(this.panel4);
            this.stockNavigationPage.Controls.Add(this.panel2);
            this.stockNavigationPage.Name = "stockNavigationPage";
            this.stockNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tlBooksInStock);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 403);
            this.panel4.TabIndex = 2;
            // 
            // tlBooksInStock
            // 
            this.tlBooksInStock.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colBookInStockName,
            this.colType,
            this.colPublishedDate,
            this.colCost,
            this.colAuthor,
            this.colPublisher,
            this.colIdentifier,
            this.colInventory,
            this.colInfo});
            this.tlBooksInStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlBooksInStock.DataSource = this.bookBindingSource;
            this.tlBooksInStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBooksInStock.Location = new System.Drawing.Point(0, 0);
            this.tlBooksInStock.Name = "tlBooksInStock";
            this.tlBooksInStock.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.tlBooksInStock.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.tlBooksInStock.OptionsFilter.ShowAllValuesInFilterPopup = true;
            this.tlBooksInStock.OptionsFind.FindDelay = 500;
            this.tlBooksInStock.OptionsFind.FindMode = DevExpress.XtraTreeList.FindMode.Always;
            this.tlBooksInStock.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.tlBooksInStock.OptionsFind.ShowClearButton = false;
            this.tlBooksInStock.OptionsFind.ShowCloseButton = false;
            this.tlBooksInStock.OptionsFind.ShowFindButton = false;
            this.tlBooksInStock.OptionsNavigation.AutoMoveRowFocus = true;
            this.tlBooksInStock.OptionsNavigation.UseTabKey = true;
            this.tlBooksInStock.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.False;
            this.tlBooksInStock.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnBookDetail});
            this.tlBooksInStock.RowHeight = 30;
            this.tlBooksInStock.Size = new System.Drawing.Size(1025, 403);
            this.tlBooksInStock.TabIndex = 0;
            this.tlBooksInStock.VisibleChanged += new System.EventHandler(this.LoadBooksInStock);
            // 
            // colBookInStockName
            // 
            this.colBookInStockName.Caption = "Tên sách";
            this.colBookInStockName.FieldName = "Name";
            this.colBookInStockName.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colBookInStockName.Name = "colBookInStockName";
            this.colBookInStockName.OptionsColumn.AllowEdit = false;
            this.colBookInStockName.OptionsColumn.AllowMove = false;
            this.colBookInStockName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colBookInStockName.OptionsColumn.ReadOnly = true;
            this.colBookInStockName.Visible = true;
            this.colBookInStockName.VisibleIndex = 1;
            this.colBookInStockName.Width = 230;
            // 
            // colType
            // 
            this.colType.Caption = "Thể loại";
            this.colType.FieldName = "Category";
            this.colType.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.OptionsColumn.AllowMove = false;
            this.colType.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 98;
            // 
            // colPublishedDate
            // 
            this.colPublishedDate.Caption = "Ngày xuất bản";
            this.colPublishedDate.FieldName = "PublishedDate";
            this.colPublishedDate.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colPublishedDate.Format.FormatString = "dd-MM-yyyy";
            this.colPublishedDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPublishedDate.Name = "colPublishedDate";
            this.colPublishedDate.OptionsColumn.AllowEdit = false;
            this.colPublishedDate.OptionsColumn.AllowMove = false;
            this.colPublishedDate.OptionsColumn.AllowSize = false;
            this.colPublishedDate.OptionsColumn.ReadOnly = true;
            this.colPublishedDate.Visible = true;
            this.colPublishedDate.VisibleIndex = 3;
            this.colPublishedDate.Width = 86;
            // 
            // colCost
            // 
            this.colCost.Caption = "Giá nhập";
            this.colCost.FieldName = "Cost";
            this.colCost.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colCost.Name = "colCost";
            this.colCost.OptionsColumn.AllowEdit = false;
            this.colCost.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colCost.OptionsColumn.AllowSize = false;
            this.colCost.OptionsColumn.ReadOnly = true;
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 115;
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Tác giả";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.AllowEdit = false;
            this.colAuthor.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colAuthor.OptionsColumn.AllowSize = false;
            this.colAuthor.OptionsColumn.ReadOnly = true;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 5;
            this.colAuthor.Width = 156;
            // 
            // colPublisher
            // 
            this.colPublisher.Caption = "Nhà xuất bản";
            this.colPublisher.FieldName = "Publisher";
            this.colPublisher.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.OptionsColumn.AllowEdit = false;
            this.colPublisher.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colPublisher.OptionsColumn.AllowSize = false;
            this.colPublisher.OptionsColumn.ReadOnly = true;
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 6;
            this.colPublisher.Width = 97;
            // 
            // colIdentifier
            // 
            this.colIdentifier.Caption = "Mã sách";
            this.colIdentifier.FieldName = "Identifier";
            this.colIdentifier.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colIdentifier.Name = "colIdentifier";
            this.colIdentifier.OptionsColumn.AllowEdit = false;
            this.colIdentifier.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colIdentifier.OptionsColumn.AllowSize = false;
            this.colIdentifier.OptionsColumn.ReadOnly = true;
            this.colIdentifier.Visible = true;
            this.colIdentifier.VisibleIndex = 0;
            this.colIdentifier.Width = 65;
            // 
            // colInventory
            // 
            this.colInventory.Caption = "Số lượng tồn";
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.colInventory.Name = "colInventory";
            this.colInventory.OptionsColumn.AllowEdit = false;
            this.colInventory.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colInventory.OptionsColumn.AllowSize = false;
            this.colInventory.OptionsColumn.ReadOnly = true;
            this.colInventory.Visible = true;
            this.colInventory.VisibleIndex = 7;
            this.colInventory.Width = 67;
            // 
            // colInfo
            // 
            this.colInfo.ColumnEdit = this.btnBookDetail;
            this.colInfo.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colInfo.Name = "colInfo";
            this.colInfo.OptionsColumn.AllowMove = false;
            this.colInfo.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colInfo.OptionsColumn.AllowSize = false;
            this.colInfo.OptionsColumn.FixedWidth = true;
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 8;
            this.colInfo.Width = 49;
            // 
            // btnBookDetail
            // 
            this.btnBookDetail.AutoHeight = false;
            this.btnBookDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBookDetail.Name = "btnBookDetail";
            this.btnBookDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnBookDetail.Click += new System.EventHandler(this.btnBookDetail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.materialLabel5);
            this.panel13.Controls.Add(this.btnImport);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(811, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(214, 48);
            this.panel13.TabIndex = 4;
            this.panel13.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(74, 16);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(79, 18);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Nhập sách";
            this.materialLabel5.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageActive = null;
            this.btnImport.Location = new System.Drawing.Point(11, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(46, 39);
            this.btnImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImport.TabIndex = 5;
            this.btnImport.TabStop = false;
            this.btnImport.Zoom = 10;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tbSearchBookInStock);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(438, 48);
            this.panel12.TabIndex = 3;
            // 
            // tbSearchBookInStock
            // 
            this.tbSearchBookInStock.BackColor = System.Drawing.Color.White;
            this.tbSearchBookInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSearchBookInStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchBookInStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchBookInStock.ForeColor = System.Drawing.Color.DimGray;
            this.tbSearchBookInStock.HintForeColor = System.Drawing.Color.DimGray;
            this.tbSearchBookInStock.HintText = "Tìm kiếm";
            this.tbSearchBookInStock.isPassword = false;
            this.tbSearchBookInStock.LineFocusedColor = System.Drawing.Color.DimGray;
            this.tbSearchBookInStock.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tbSearchBookInStock.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.tbSearchBookInStock.LineThickness = 3;
            this.tbSearchBookInStock.Location = new System.Drawing.Point(35, 9);
            this.tbSearchBookInStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchBookInStock.Name = "tbSearchBookInStock";
            this.tbSearchBookInStock.Size = new System.Drawing.Size(370, 35);
            this.tbSearchBookInStock.TabIndex = 2;
            this.tbSearchBookInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchBookInStock.OnValueChanged += new System.EventHandler(this.tbSearchBookInStock_OnTextChange);
            // 
            // staffNavigationPage
            // 
            this.staffNavigationPage.Caption = "staffNavigationPage";
            this.staffNavigationPage.Controls.Add(this.tlStaff);
            this.staffNavigationPage.Controls.Add(this.panel3);
            this.staffNavigationPage.Name = "staffNavigationPage";
            this.staffNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // tlStaff
            // 
            this.tlStaff.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colSex,
            this.colBirthDate,
            this.colEmail,
            this.colPhoneNum,
            this.colFuntion,
            this.colUsername,
            this.colDetail});
            this.tlStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlStaff.DataSource = this.userBindingSource;
            this.tlStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlStaff.Location = new System.Drawing.Point(0, 48);
            this.tlStaff.Name = "tlStaff";
            this.tlStaff.OptionsBehavior.EnableFiltering = true;
            this.tlStaff.OptionsBehavior.ExpandNodesOnFiltering = true;
            this.tlStaff.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.tlStaff.OptionsBehavior.ReadOnly = true;
            this.tlStaff.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.tlStaff.OptionsCustomization.AllowBandMoving = false;
            this.tlStaff.OptionsCustomization.AllowColumnMoving = false;
            this.tlStaff.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.tlStaff.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.tlStaff.OptionsFind.FindDelay = 500;
            this.tlStaff.OptionsFind.ShowClearButton = false;
            this.tlStaff.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tlStaff.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.tlStaff.RowHeight = 30;
            this.tlStaff.Size = new System.Drawing.Size(1025, 403);
            this.tlStaff.TabIndex = 0;
            this.tlStaff.VisibleChanged += new System.EventHandler(this.LoadStaff);
            // 
            // colName
            // 
            this.colName.Caption = "Họ và tên";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 140;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.OptionsColumn.AllowEdit = false;
            this.colSex.OptionsColumn.ReadOnly = true;
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 1;
            this.colSex.Width = 66;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "Ngày sinh";
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Format.FormatString = "dd/MM/yyyy";
            this.colBirthDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowEdit = false;
            this.colBirthDate.OptionsColumn.ReadOnly = true;
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 3;
            this.colBirthDate.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 165;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Caption = "Số điện thoại";
            this.colPhoneNum.FieldName = "PhoneNum";
            this.colPhoneNum.Name = "colPhoneNum";
            this.colPhoneNum.OptionsColumn.AllowEdit = false;
            this.colPhoneNum.OptionsColumn.ReadOnly = true;
            this.colPhoneNum.Visible = true;
            this.colPhoneNum.VisibleIndex = 6;
            this.colPhoneNum.Width = 99;
            // 
            // colFuntion
            // 
            this.colFuntion.Caption = "Chức vụ";
            this.colFuntion.FieldName = "Funtion";
            this.colFuntion.Name = "colFuntion";
            this.colFuntion.OptionsColumn.AllowEdit = false;
            this.colFuntion.OptionsColumn.ReadOnly = true;
            this.colFuntion.Visible = true;
            this.colFuntion.VisibleIndex = 4;
            this.colFuntion.Width = 130;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Tài khoản";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.AllowEdit = false;
            this.colUsername.OptionsColumn.ReadOnly = true;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 2;
            this.colUsername.Width = 113;
            // 
            // colDetail
            // 
            this.colDetail.ColumnEdit = this.btnDetail;
            this.colDetail.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colDetail.Name = "colDetail";
            this.colDetail.OptionsColumn.FixedWidth = true;
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 7;
            this.colDetail.Width = 43;
            // 
            // btnDetail
            // 
            this.btnDetail.AutoHeight = false;
            this.btnDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetail_ButtonClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DTO.User);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnNewStaff);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(961, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(64, 48);
            this.panel15.TabIndex = 7;
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnNewStaff.Image")));
            this.btnNewStaff.ImageActive = null;
            this.btnNewStaff.Location = new System.Drawing.Point(12, 4);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(42, 39);
            this.btnNewStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewStaff.TabIndex = 6;
            this.btnNewStaff.TabStop = false;
            this.btnNewStaff.Zoom = 10;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbSearchStaff);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(426, 48);
            this.panel14.TabIndex = 5;
            // 
            // tbSearchStaff
            // 
            this.tbSearchStaff.BackColor = System.Drawing.Color.White;
            this.tbSearchStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbSearchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearchStaff.ForeColor = System.Drawing.Color.DimGray;
            this.tbSearchStaff.HintForeColor = System.Drawing.Color.DimGray;
            this.tbSearchStaff.HintText = "Tìm kiếm";
            this.tbSearchStaff.isPassword = false;
            this.tbSearchStaff.LineFocusedColor = System.Drawing.Color.DimGray;
            this.tbSearchStaff.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tbSearchStaff.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.tbSearchStaff.LineThickness = 3;
            this.tbSearchStaff.Location = new System.Drawing.Point(35, 9);
            this.tbSearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchStaff.Name = "tbSearchStaff";
            this.tbSearchStaff.Size = new System.Drawing.Size(370, 35);
            this.tbSearchStaff.TabIndex = 4;
            this.tbSearchStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchStaff.OnValueChanged += new System.EventHandler(this.tbSearchStaff_OnValueChanged);
            // 
            // reportNavigationPage
            // 
            this.reportNavigationPage.Caption = "reportNavigationPage";
            this.reportNavigationPage.Controls.Add(this.tlIndebtednessReport);
            this.reportNavigationPage.Controls.Add(this.tlInventoryReport);
            this.reportNavigationPage.Controls.Add(this.panel8);
            this.reportNavigationPage.Name = "reportNavigationPage";
            this.reportNavigationPage.Size = new System.Drawing.Size(1025, 451);
            this.reportNavigationPage.VisibleChanged += new System.EventHandler(this.statisticsNavigationPage_VisibleChanged);
            // 
            // tlIndebtednessReport
            // 
            this.tlIndebtednessReport.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCustomerID,
            this.colCustomerName1,
            this.colTime1,
            this.colInEarly1,
            this.colOnArise1,
            this.colInLast1});
            this.tlIndebtednessReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlIndebtednessReport.DataSource = this.indebtednessReportBindingSource;
            this.tlIndebtednessReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlIndebtednessReport.Location = new System.Drawing.Point(0, 72);
            this.tlIndebtednessReport.Name = "tlIndebtednessReport";
            this.tlIndebtednessReport.OptionsBehavior.ResizeNodes = false;
            this.tlIndebtednessReport.Size = new System.Drawing.Size(1025, 379);
            this.tlIndebtednessReport.TabIndex = 4;
            this.tlIndebtednessReport.Visible = false;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "Mã KH";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsColumn.AllowEdit = false;
            this.colCustomerID.OptionsColumn.ReadOnly = true;
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            this.colCustomerID.Width = 109;
            // 
            // colCustomerName1
            // 
            this.colCustomerName1.Caption = "Tên khách hàng";
            this.colCustomerName1.FieldName = "CustomerName";
            this.colCustomerName1.Name = "colCustomerName1";
            this.colCustomerName1.OptionsColumn.AllowEdit = false;
            this.colCustomerName1.OptionsColumn.ReadOnly = true;
            this.colCustomerName1.Visible = true;
            this.colCustomerName1.VisibleIndex = 1;
            this.colCustomerName1.Width = 307;
            // 
            // colTime1
            // 
            this.colTime1.FieldName = "Time";
            this.colTime1.Name = "colTime1";
            this.colTime1.OptionsColumn.AllowEdit = false;
            this.colTime1.OptionsColumn.ReadOnly = true;
            this.colTime1.Width = 168;
            // 
            // colInEarly1
            // 
            this.colInEarly1.Caption = "Nợ đầu";
            this.colInEarly1.FieldName = "InEarly";
            this.colInEarly1.Name = "colInEarly1";
            this.colInEarly1.OptionsColumn.AllowEdit = false;
            this.colInEarly1.OptionsColumn.ReadOnly = true;
            this.colInEarly1.Visible = true;
            this.colInEarly1.VisibleIndex = 2;
            this.colInEarly1.Width = 198;
            // 
            // colOnArise1
            // 
            this.colOnArise1.Caption = "Nợ phát sinh";
            this.colOnArise1.FieldName = "OnArise";
            this.colOnArise1.Name = "colOnArise1";
            this.colOnArise1.OptionsColumn.AllowEdit = false;
            this.colOnArise1.OptionsColumn.ReadOnly = true;
            this.colOnArise1.Visible = true;
            this.colOnArise1.VisibleIndex = 3;
            this.colOnArise1.Width = 197;
            // 
            // colInLast1
            // 
            this.colInLast1.Caption = "Nợ cuối";
            this.colInLast1.FieldName = "InLast";
            this.colInLast1.Name = "colInLast1";
            this.colInLast1.OptionsColumn.AllowEdit = false;
            this.colInLast1.OptionsColumn.ReadOnly = true;
            this.colInLast1.Visible = true;
            this.colInLast1.VisibleIndex = 4;
            this.colInLast1.Width = 196;
            // 
            // indebtednessReportBindingSource
            // 
            this.indebtednessReportBindingSource.DataSource = typeof(DTO.IndebtednessReport);
            // 
            // tlInventoryReport
            // 
            this.tlInventoryReport.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colBookID,
            this.colBookName,
            this.colTime,
            this.colInEarly,
            this.colOnArise,
            this.colInLast});
            this.tlInventoryReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlInventoryReport.DataSource = this.inventoryReportBindingSource;
            this.tlInventoryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInventoryReport.Location = new System.Drawing.Point(0, 72);
            this.tlInventoryReport.Name = "tlInventoryReport";
            this.tlInventoryReport.OptionsBehavior.ResizeNodes = false;
            this.tlInventoryReport.Size = new System.Drawing.Size(1025, 379);
            this.tlInventoryReport.TabIndex = 3;
            // 
            // colBookID
            // 
            this.colBookID.Caption = "Mã sách";
            this.colBookID.FieldName = "BookID";
            this.colBookID.Name = "colBookID";
            this.colBookID.OptionsColumn.AllowEdit = false;
            this.colBookID.OptionsColumn.ReadOnly = true;
            this.colBookID.Visible = true;
            this.colBookID.VisibleIndex = 0;
            this.colBookID.Width = 110;
            // 
            // colBookName
            // 
            this.colBookName.Caption = "Tên sách";
            this.colBookName.FieldName = "BookName";
            this.colBookName.Name = "colBookName";
            this.colBookName.OptionsColumn.AllowEdit = false;
            this.colBookName.OptionsColumn.ReadOnly = true;
            this.colBookName.Visible = true;
            this.colBookName.VisibleIndex = 1;
            this.colBookName.Width = 306;
            // 
            // colTime
            // 
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.OptionsColumn.AllowEdit = false;
            this.colTime.OptionsColumn.ReadOnly = true;
            this.colTime.Width = 168;
            // 
            // colInEarly
            // 
            this.colInEarly.Caption = "Tồn đầu";
            this.colInEarly.FieldName = "InEarly";
            this.colInEarly.Name = "colInEarly";
            this.colInEarly.OptionsColumn.AllowEdit = false;
            this.colInEarly.OptionsColumn.ReadOnly = true;
            this.colInEarly.Visible = true;
            this.colInEarly.VisibleIndex = 2;
            this.colInEarly.Width = 198;
            // 
            // colOnArise
            // 
            this.colOnArise.Caption = "Tồn phát sinh";
            this.colOnArise.FieldName = "OnArise";
            this.colOnArise.Name = "colOnArise";
            this.colOnArise.OptionsColumn.AllowEdit = false;
            this.colOnArise.OptionsColumn.ReadOnly = true;
            this.colOnArise.Visible = true;
            this.colOnArise.VisibleIndex = 3;
            this.colOnArise.Width = 197;
            // 
            // colInLast
            // 
            this.colInLast.Caption = "Tồn cuối";
            this.colInLast.FieldName = "InLast";
            this.colInLast.Name = "colInLast";
            this.colInLast.OptionsColumn.AllowEdit = false;
            this.colInLast.OptionsColumn.ReadOnly = true;
            this.colInLast.Visible = true;
            this.colInLast.VisibleIndex = 4;
            this.colInLast.Width = 196;
            // 
            // inventoryReportBindingSource
            // 
            this.inventoryReportBindingSource.DataSource = typeof(DTO.InventoryReport);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1025, 72);
            this.panel8.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnShowReport);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(852, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(173, 72);
            this.panel17.TabIndex = 5;
            // 
            // btnShowReport
            // 
            this.btnShowReport.AutoSize = true;
            this.btnShowReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowReport.Depth = 0;
            this.btnShowReport.Location = new System.Drawing.Point(15, 20);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Primary = false;
            this.btnShowReport.Size = new System.Drawing.Size(102, 36);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Xem báo cáo";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.datePickerReport);
            this.panel16.Controls.Add(this.label10);
            this.panel16.Controls.Add(this.groupBox1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(672, 72);
            this.panel16.TabIndex = 4;
            // 
            // datePickerReport
            // 
            this.datePickerReport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerReport.Location = new System.Drawing.Point(79, 20);
            this.datePickerReport.Name = "datePickerReport";
            this.datePickerReport.Size = new System.Drawing.Size(141, 26);
            this.datePickerReport.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIndebtednessReport);
            this.groupBox1.Controls.Add(this.rbInventoryReport);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại báo cáo";
            // 
            // rbIndebtednessReport
            // 
            this.rbIndebtednessReport.AutoSize = true;
            this.rbIndebtednessReport.Location = new System.Drawing.Point(146, 28);
            this.rbIndebtednessReport.Name = "rbIndebtednessReport";
            this.rbIndebtednessReport.Size = new System.Drawing.Size(89, 20);
            this.rbIndebtednessReport.TabIndex = 1;
            this.rbIndebtednessReport.Text = "Báo cáo nợ";
            this.rbIndebtednessReport.UseVisualStyleBackColor = true;
            // 
            // rbInventoryReport
            // 
            this.rbInventoryReport.AutoSize = true;
            this.rbInventoryReport.Checked = true;
            this.rbInventoryReport.Location = new System.Drawing.Point(18, 28);
            this.rbInventoryReport.Name = "rbInventoryReport";
            this.rbInventoryReport.Size = new System.Drawing.Size(117, 20);
            this.rbInventoryReport.TabIndex = 1;
            this.rbInventoryReport.TabStop = true;
            this.rbInventoryReport.Text = "Báo cáo tồn kho";
            this.rbInventoryReport.UseVisualStyleBackColor = true;
            this.rbInventoryReport.CheckedChanged += new System.EventHandler(this.rbInventoryReport_CheckedChanged);
            // 
            // adminNavigationPage
            // 
            this.adminNavigationPage.Caption = "adminNavigationPage";
            this.adminNavigationPage.Controls.Add(this.panel18);
            this.adminNavigationPage.Controls.Add(this.groupBox4);
            this.adminNavigationPage.Name = "adminNavigationPage";
            this.adminNavigationPage.Size = new System.Drawing.Size(1025, 451);
            this.adminNavigationPage.VisibleChanged += new System.EventHandler(this.adminNavigationPage_VisibleChanged);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.panel25);
            this.panel18.Controls.Add(this.panel23);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(606, 451);
            this.panel18.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.AutoScroll = true;
            this.panel25.AutoSize = true;
            this.panel25.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(0, 451);
            this.panel25.TabIndex = 3;
            // 
            // panel23
            // 
            this.panel23.AutoSize = true;
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(606, 451);
            this.panel23.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.panel19);
            this.panel24.Controls.Add(this.panel21);
            this.panel24.Controls.Add(this.panel22);
            this.panel24.Controls.Add(this.panel20);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(606, 451);
            this.panel24.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.AutoSize = true;
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.panel19.Controls.Add(this.panel26);
            this.panel19.Controls.Add(this.pictureBox1);
            this.panel19.Controls.Add(this.label17);
            this.panel19.Location = new System.Drawing.Point(11, 300);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(270, 87);
            this.panel19.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.lbRevenue);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel26.Location = new System.Drawing.Point(0, 59);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(270, 28);
            this.panel26.TabIndex = 2;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.ForeColor = System.Drawing.Color.White;
            this.lbRevenue.Location = new System.Drawing.Point(219, 0);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(51, 25);
            this.lbRevenue.TabIndex = 1;
            this.lbRevenue.Text = "500";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(124, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 19);
            this.label17.TabIndex = 1;
            this.label17.Text = "Doanh thu tháng này";
            // 
            // panel21
            // 
            this.panel21.AutoScroll = true;
            this.panel21.AutoSize = true;
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.panel21.Controls.Add(this.panel29);
            this.panel21.Controls.Add(this.label11);
            this.panel21.Controls.Add(this.pictureBox3);
            this.panel21.Location = new System.Drawing.Point(330, 300);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(270, 87);
            this.panel21.TabIndex = 0;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.lbNumBookSold);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel29.Location = new System.Drawing.Point(0, 59);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(270, 28);
            this.panel29.TabIndex = 4;
            // 
            // lbNumBookSold
            // 
            this.lbNumBookSold.AutoSize = true;
            this.lbNumBookSold.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNumBookSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumBookSold.ForeColor = System.Drawing.Color.White;
            this.lbNumBookSold.Location = new System.Drawing.Point(219, 0);
            this.lbNumBookSold.Name = "lbNumBookSold";
            this.lbNumBookSold.Size = new System.Drawing.Size(51, 25);
            this.lbNumBookSold.TabIndex = 5;
            this.lbNumBookSold.Text = "500";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(83, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số sách bán được tháng này";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 42);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.AutoSize = true;
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel22.Controls.Add(this.panel27);
            this.panel22.Controls.Add(this.pictureBox4);
            this.panel22.Controls.Add(this.label15);
            this.panel22.Location = new System.Drawing.Point(11, 75);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(270, 87);
            this.panel22.TabIndex = 0;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.lbNumBookImport);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel27.Location = new System.Drawing.Point(0, 59);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(270, 28);
            this.panel27.TabIndex = 3;
            // 
            // lbNumBookImport
            // 
            this.lbNumBookImport.AutoSize = true;
            this.lbNumBookImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNumBookImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumBookImport.ForeColor = System.Drawing.Color.White;
            this.lbNumBookImport.Location = new System.Drawing.Point(219, 0);
            this.lbNumBookImport.Name = "lbNumBookImport";
            this.lbNumBookImport.Size = new System.Drawing.Size(51, 25);
            this.lbNumBookImport.TabIndex = 1;
            this.lbNumBookImport.Text = "500";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 42);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(83, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 19);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số sách nhập vào tháng này";
            // 
            // panel20
            // 
            this.panel20.AutoSize = true;
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(77)))), ((int)(((byte)(81)))));
            this.panel20.Controls.Add(this.panel28);
            this.panel20.Controls.Add(this.pictureBox2);
            this.panel20.Controls.Add(this.label13);
            this.panel20.Location = new System.Drawing.Point(330, 75);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(270, 87);
            this.panel20.TabIndex = 0;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.lbNumBookInStock);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel28.Location = new System.Drawing.Point(0, 59);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(270, 28);
            this.panel28.TabIndex = 3;
            // 
            // lbNumBookInStock
            // 
            this.lbNumBookInStock.AutoSize = true;
            this.lbNumBookInStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNumBookInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumBookInStock.ForeColor = System.Drawing.Color.White;
            this.lbNumBookInStock.Location = new System.Drawing.Point(219, 0);
            this.lbNumBookInStock.Name = "lbNumBookInStock";
            this.lbNumBookInStock.Size = new System.Drawing.Size(51, 25);
            this.lbNumBookInStock.TabIndex = 1;
            this.lbNumBookInStock.Text = "500";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(111, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Số sách còn trong kho";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.materialLabel3);
            this.groupBox4.Controls.Add(this.materialLabel2);
            this.groupBox4.Controls.Add(this.materialLabel1);
            this.groupBox4.Controls.Add(this.materialLabel6);
            this.groupBox4.Controls.Add(this.tbMaxIndebtedness);
            this.groupBox4.Controls.Add(this.tbMinLastInventory);
            this.groupBox4.Controls.Add(this.tbMaxInventory);
            this.groupBox4.Controls.Add(this.tbMinImport);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(606, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(419, 451);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quy định nhà sách";
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
            this.btnUpdate.Location = new System.Drawing.Point(327, 400);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = false;
            this.btnUpdate.Size = new System.Drawing.Size(79, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Depth = 0;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Location = new System.Drawing.Point(245, 400);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(39, 36);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 318);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(160, 18);
            this.materialLabel3.TabIndex = 67;
            this.materialLabel3.Text = "Số tiền nợ tối đa (VND)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 238);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(175, 18);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "Số lượng tồn sau tối thiểu";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 158);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 18);
            this.materialLabel1.TabIndex = 67;
            this.materialLabel1.Text = "Số lượng tồn tối đa";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 83);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(146, 18);
            this.materialLabel6.TabIndex = 67;
            this.materialLabel6.Text = "Số lượng nhập ít nhất";
            // 
            // tbMaxIndebtedness
            // 
            this.tbMaxIndebtedness.BackColor = System.Drawing.Color.White;
            this.tbMaxIndebtedness.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaxIndebtedness.Enabled = false;
            this.tbMaxIndebtedness.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxIndebtedness.ForeColor = System.Drawing.Color.Black;
            this.tbMaxIndebtedness.HintForeColor = System.Drawing.Color.Transparent;
            this.tbMaxIndebtedness.HintText = "";
            this.tbMaxIndebtedness.isPassword = false;
            this.tbMaxIndebtedness.LineFocusedColor = System.Drawing.Color.Gray;
            this.tbMaxIndebtedness.LineIdleColor = System.Drawing.Color.White;
            this.tbMaxIndebtedness.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.tbMaxIndebtedness.LineThickness = 2;
            this.tbMaxIndebtedness.Location = new System.Drawing.Point(208, 293);
            this.tbMaxIndebtedness.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxIndebtedness.Name = "tbMaxIndebtedness";
            this.tbMaxIndebtedness.Size = new System.Drawing.Size(198, 44);
            this.tbMaxIndebtedness.TabIndex = 3;
            this.tbMaxIndebtedness.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMaxIndebtedness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // tbMinLastInventory
            // 
            this.tbMinLastInventory.BackColor = System.Drawing.Color.White;
            this.tbMinLastInventory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMinLastInventory.Enabled = false;
            this.tbMinLastInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinLastInventory.ForeColor = System.Drawing.Color.Black;
            this.tbMinLastInventory.HintForeColor = System.Drawing.Color.Transparent;
            this.tbMinLastInventory.HintText = "";
            this.tbMinLastInventory.isPassword = false;
            this.tbMinLastInventory.LineFocusedColor = System.Drawing.Color.Gray;
            this.tbMinLastInventory.LineIdleColor = System.Drawing.Color.White;
            this.tbMinLastInventory.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.tbMinLastInventory.LineThickness = 2;
            this.tbMinLastInventory.Location = new System.Drawing.Point(208, 213);
            this.tbMinLastInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbMinLastInventory.Name = "tbMinLastInventory";
            this.tbMinLastInventory.Size = new System.Drawing.Size(198, 44);
            this.tbMinLastInventory.TabIndex = 2;
            this.tbMinLastInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMinLastInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // tbMaxInventory
            // 
            this.tbMaxInventory.BackColor = System.Drawing.Color.White;
            this.tbMaxInventory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaxInventory.Enabled = false;
            this.tbMaxInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxInventory.ForeColor = System.Drawing.Color.Black;
            this.tbMaxInventory.HintForeColor = System.Drawing.Color.Transparent;
            this.tbMaxInventory.HintText = "";
            this.tbMaxInventory.isPassword = false;
            this.tbMaxInventory.LineFocusedColor = System.Drawing.Color.Gray;
            this.tbMaxInventory.LineIdleColor = System.Drawing.Color.White;
            this.tbMaxInventory.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.tbMaxInventory.LineThickness = 2;
            this.tbMaxInventory.Location = new System.Drawing.Point(208, 133);
            this.tbMaxInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxInventory.Name = "tbMaxInventory";
            this.tbMaxInventory.Size = new System.Drawing.Size(198, 44);
            this.tbMaxInventory.TabIndex = 1;
            this.tbMaxInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMaxInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // tbMinImport
            // 
            this.tbMinImport.BackColor = System.Drawing.Color.White;
            this.tbMinImport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMinImport.Enabled = false;
            this.tbMinImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinImport.ForeColor = System.Drawing.Color.Black;
            this.tbMinImport.HintForeColor = System.Drawing.Color.Transparent;
            this.tbMinImport.HintText = "";
            this.tbMinImport.isPassword = false;
            this.tbMinImport.LineFocusedColor = System.Drawing.Color.Gray;
            this.tbMinImport.LineIdleColor = System.Drawing.Color.White;
            this.tbMinImport.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.tbMinImport.LineThickness = 2;
            this.tbMinImport.Location = new System.Drawing.Point(208, 58);
            this.tbMinImport.Margin = new System.Windows.Forms.Padding(4);
            this.tbMinImport.Name = "tbMinImport";
            this.tbMinImport.Size = new System.Drawing.Size(198, 44);
            this.tbMinImport.TabIndex = 0;
            this.tbMinImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMinImport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // FrmDashboard
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 561);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.bookstallNavigationPage.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlBookInBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBookInBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpBook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panelBillInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelCustomerSearch.ResumeLayout(false);
            this.panelCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.customerNavigationPage.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewCustomer)).EndInit();
            this.panel11.ResumeLayout(false);
            this.stockNavigationPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlBooksInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            this.panel12.ResumeLayout(false);
            this.staffNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStaff)).EndInit();
            this.panel14.ResumeLayout(false);
            this.reportNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlIndebtednessReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indebtednessReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlInventoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReportBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.adminNavigationPage.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem bookstallTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage bookstallNavigationPage;
        private DevExpress.XtraBars.Navigation.TileBarItem stockTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem custommerTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem staffTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage stockNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customerNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage staffNavigationPage;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraTreeList.TreeList tlBooksInStock;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBookInStockName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublishedDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCost;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAuthor;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublisher;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdentifier;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DevExpress.XtraBars.Navigation.TileBarItem reportTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage reportNavigationPage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInventory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBookDetail;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearchBookInStock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearchStaff;
        private DevExpress.XtraTreeList.TreeList tlStaff;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBirthDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmail;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhoneNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFuntion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUsername;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraTreeList.TreeList tlBookInBill;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBookNameInBill;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublishedDate1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCost1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAuthor1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublisher1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdentifier1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCount;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelCheckout;
        private MaterialSkin.Controls.MaterialFlatButton btnCheckout;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbIndebtedness;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbChange;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCustomerPaid;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelBillInfo;
        private System.Windows.Forms.Panel panelCustomerSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteBookInBill;
        private DevExpress.XtraBars.Navigation.NavigationPage adminNavigationPage;
        private System.Windows.Forms.DateTimePicker datePickerReport;
        private System.Windows.Forms.BindingSource indebtednessReportBindingSource;
        private System.Windows.Forms.BindingSource inventoryReportBindingSource;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIndebtednessReport;
        private System.Windows.Forms.RadioButton rbInventoryReport;
        private DevExpress.XtraTreeList.TreeList tlInventoryReport;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBookID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBookName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInEarly;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOnArise;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInLast;
        private DevExpress.XtraTreeList.TreeList tlIndebtednessReport;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTime1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInEarly1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOnArise1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInLast1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnShowBillInfo;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuImageButton btnImport;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private Bunifu.Framework.UI.BunifuImageButton btnNewStaff;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private MaterialSkin.Controls.MaterialFlatButton btnShowReport;
        private System.Windows.Forms.Panel panel16;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteCustomer;
        private DevExpress.XtraBars.Navigation.TileBarItem adminTileBarItem;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMaxIndebtedness;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMinLastInventory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMaxInventory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbMinImport;
        private MaterialSkin.Controls.MaterialFlatButton btnUpdate;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNumBookInStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbNumBookImport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label lbNumBookSold;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private Bunifu.Framework.UI.BunifuImageButton btnBackToEdit;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearchCustomer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraTreeList.TreeList tlCustomer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSex1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAddress1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmail1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhoneNum1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndebtedness;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colReceive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnReceive;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetailCustomer;
        private System.Windows.Forms.Panel panel30;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btnNewCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmLoading;
    }
}