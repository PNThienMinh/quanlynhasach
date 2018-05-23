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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.employeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.bookstallTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.stockTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.custommerTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.staffTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.statisticsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.dashboardNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.bookstallNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customerNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tlCustomer = new DevExpress.XtraTreeList.TreeList();
            this.colCustomerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerSex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerAdd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerEmail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerPhoneNo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIndebtedness = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCustomerDetail = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDetailCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCustomerDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDeleteCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchCustomer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnNewCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.colDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDeleteBook = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImport = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.tbSearchStaff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ssmLoading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.dashboardNavigationPage.SuspendLayout();
            this.bookstallNavigationPage.SuspendLayout();
            this.customerNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.stockNavigationPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlBooksInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.staffNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
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
            this.tileBar.MaxId = 7;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.employeesTileBarItem;
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
            this.tileBarGroupTables.Items.Add(this.employeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.bookstallTileBarItem);
            this.tileBarGroupTables.Items.Add(this.stockTileBarItem);
            this.tileBarGroupTables.Items.Add(this.custommerTileBarItem);
            this.tileBarGroupTables.Items.Add(this.staffTileBarItem);
            this.tileBarGroupTables.Items.Add(this.statisticsTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // employeesTileBarItem
            // 
            this.employeesTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.employeesTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.employeesTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.employeesTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.employeesTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.employeesTileBarItem.AppearanceItem.Selected.Options.UseImage = true;
            this.employeesTileBarItem.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.employeesTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.employeesTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::UI.Properties.Resources.gradientgreendatabar_32x32;
            tileItemElement1.ImageUri.Uri = "ListBullets";
            tileItemElement1.Text = "Bảng điều khiển";
            this.employeesTileBarItem.Elements.Add(tileItemElement1);
            this.employeesTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.employeesTileBarItem.Name = "employeesTileBarItem";
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
            tileItemElement2.Image = global::UI.Properties.Resources.morefunctions_32x32;
            tileItemElement2.ImageUri.Uri = "Copy";
            tileItemElement2.Text = "Quầy sách";
            this.bookstallTileBarItem.Elements.Add(tileItemElement2);
            this.bookstallTileBarItem.Id = 2;
            this.bookstallTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.bookstallTileBarItem.Name = "bookstallTileBarItem";
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
            tileItemElement4.Image = global::UI.Properties.Resources.bocustomer_32x32;
            tileItemElement4.Text = "Khách hàng";
            this.custommerTileBarItem.Elements.Add(tileItemElement4);
            this.custommerTileBarItem.Id = 4;
            this.custommerTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.custommerTileBarItem.Name = "custommerTileBarItem";
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
            this.staffTileBarItem.Id = 5;
            this.staffTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.staffTileBarItem.Name = "staffTileBarItem";
            // 
            // statisticsTileBarItem
            // 
            this.statisticsTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.statisticsTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statisticsTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.statisticsTileBarItem.AppearanceItem.Normal.Options.UseFont = true;
            this.statisticsTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statisticsTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.statisticsTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.statisticsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.Text = "Thống kê";
            this.statisticsTileBarItem.Elements.Add(tileItemElement6);
            this.statisticsTileBarItem.Id = 6;
            this.statisticsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.statisticsTileBarItem.Name = "statisticsTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.dashboardNavigationPage);
            this.navigationFrame.Controls.Add(this.bookstallNavigationPage);
            this.navigationFrame.Controls.Add(this.customerNavigationPage);
            this.navigationFrame.Controls.Add(this.stockNavigationPage);
            this.navigationFrame.Controls.Add(this.staffNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.dashboardNavigationPage,
            this.bookstallNavigationPage,
            this.stockNavigationPage,
            this.customerNavigationPage,
            this.staffNavigationPage,
            this.navigationPage1});
            this.navigationFrame.SelectedPage = this.dashboardNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1025, 451);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 500;
            this.navigationFrame.TransitionAnimationProperties.FrameInterval = 5000;
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // dashboardNavigationPage
            // 
            this.dashboardNavigationPage.Caption = "dashboardNavigationPage";
            this.dashboardNavigationPage.Controls.Add(this.employeesLabelControl);
            this.dashboardNavigationPage.Name = "dashboardNavigationPage";
            this.dashboardNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(1025, 451);
            this.employeesLabelControl.TabIndex = 2;
            // 
            // bookstallNavigationPage
            // 
            this.bookstallNavigationPage.Caption = "bookstallNavigationPage";
            this.bookstallNavigationPage.Controls.Add(this.customersLabelControl);
            this.bookstallNavigationPage.Name = "bookstallNavigationPage";
            this.bookstallNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(1025, 451);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // customerNavigationPage
            // 
            this.customerNavigationPage.Caption = "customerNavigationPage";
            this.customerNavigationPage.Controls.Add(this.tlCustomer);
            this.customerNavigationPage.Controls.Add(this.panel1);
            this.customerNavigationPage.Name = "customerNavigationPage";
            this.customerNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // tlCustomer
            // 
            this.tlCustomer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCustomerName,
            this.colCustomerSex,
            this.colCustomerAdd,
            this.colCustomerEmail,
            this.colCustomerPhoneNo,
            this.colIndebtedness,
            this.colCustomerDetail,
            this.colCustomerDelete});
            this.tlCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlCustomer.DataSource = this.customerBindingSource;
            this.tlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCustomer.Location = new System.Drawing.Point(0, 48);
            this.tlCustomer.Name = "tlCustomer";
            this.tlCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetailCustomer,
            this.btnDeleteCustomer});
            this.tlCustomer.Size = new System.Drawing.Size(1025, 403);
            this.tlCustomer.TabIndex = 1;
            this.tlCustomer.VisibleChanged += new System.EventHandler(this.LoadCustomers);
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Họ và tên";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 235;
            // 
            // colCustomerSex
            // 
            this.colCustomerSex.Caption = "Giới tính";
            this.colCustomerSex.FieldName = "Sex";
            this.colCustomerSex.Name = "colCustomerSex";
            this.colCustomerSex.OptionsColumn.AllowEdit = false;
            this.colCustomerSex.OptionsColumn.ReadOnly = true;
            this.colCustomerSex.Visible = true;
            this.colCustomerSex.VisibleIndex = 1;
            this.colCustomerSex.Width = 110;
            // 
            // colCustomerAdd
            // 
            this.colCustomerAdd.Caption = "Địa chỉ";
            this.colCustomerAdd.FieldName = "Address";
            this.colCustomerAdd.Name = "colCustomerAdd";
            this.colCustomerAdd.OptionsColumn.AllowEdit = false;
            this.colCustomerAdd.OptionsColumn.ReadOnly = true;
            this.colCustomerAdd.Visible = true;
            this.colCustomerAdd.VisibleIndex = 2;
            this.colCustomerAdd.Width = 175;
            // 
            // colCustomerEmail
            // 
            this.colCustomerEmail.Caption = "Email";
            this.colCustomerEmail.FieldName = "Email";
            this.colCustomerEmail.Name = "colCustomerEmail";
            this.colCustomerEmail.OptionsColumn.AllowEdit = false;
            this.colCustomerEmail.OptionsColumn.ReadOnly = true;
            this.colCustomerEmail.Visible = true;
            this.colCustomerEmail.VisibleIndex = 4;
            this.colCustomerEmail.Width = 156;
            // 
            // colCustomerPhoneNo
            // 
            this.colCustomerPhoneNo.Caption = "Số điện thoại";
            this.colCustomerPhoneNo.FieldName = "PhoneNum";
            this.colCustomerPhoneNo.Name = "colCustomerPhoneNo";
            this.colCustomerPhoneNo.OptionsColumn.AllowEdit = false;
            this.colCustomerPhoneNo.OptionsColumn.ReadOnly = true;
            this.colCustomerPhoneNo.Visible = true;
            this.colCustomerPhoneNo.VisibleIndex = 3;
            this.colCustomerPhoneNo.Width = 145;
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
            this.colIndebtedness.Width = 80;
            // 
            // colCustomerDetail
            // 
            this.colCustomerDetail.ColumnEdit = this.btnDetailCustomer;
            this.colCustomerDetail.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colCustomerDetail.Name = "colCustomerDetail";
            this.colCustomerDetail.OptionsColumn.FixedWidth = true;
            this.colCustomerDetail.Visible = true;
            this.colCustomerDetail.VisibleIndex = 6;
            this.colCustomerDetail.Width = 53;
            // 
            // btnDetailCustomer
            // 
            this.btnDetailCustomer.AutoHeight = false;
            this.btnDetailCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDetailCustomer.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDetailCustomer.Name = "btnDetailCustomer";
            this.btnDetailCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetailCustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetailCustomer_ButtonClick);
            // 
            // colCustomerDelete
            // 
            this.colCustomerDelete.ColumnEdit = this.btnDeleteCustomer;
            this.colCustomerDelete.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colCustomerDelete.Name = "colCustomerDelete";
            this.colCustomerDelete.OptionsColumn.FixedWidth = true;
            this.colCustomerDelete.Visible = true;
            this.colCustomerDelete.VisibleIndex = 7;
            this.colCustomerDelete.Width = 53;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.AutoHeight = false;
            this.btnDeleteCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteCustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteCustomer_ButtonClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DTO.Customer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearchCustomer);
            this.panel1.Controls.Add(this.btnNewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 48);
            this.panel1.TabIndex = 0;
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
            this.tbSearchCustomer.Location = new System.Drawing.Point(30, 7);
            this.tbSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCustomer.Name = "tbSearchCustomer";
            this.tbSearchCustomer.Size = new System.Drawing.Size(370, 35);
            this.tbSearchCustomer.TabIndex = 3;
            this.tbSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchCustomer.OnValueChanged += new System.EventHandler(this.tbSearchCustomer_OnValueChanged);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.ActiveBorderThickness = 1;
            this.btnNewCustomer.ActiveCornerRadius = 20;
            this.btnNewCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNewCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.BackgroundImage")));
            this.btnNewCustomer.ButtonText = "Thêm khách hàng";
            this.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNewCustomer.IdleBorderThickness = 1;
            this.btnNewCustomer.IdleCornerRadius = 20;
            this.btnNewCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnNewCustomer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNewCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewCustomer.Location = new System.Drawing.Point(806, 5);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(189, 33);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
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
            this.colInfo,
            this.colDelete});
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
            this.btnBookDetail,
            this.btnDeleteBook});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnBookDetail.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnBookDetail.Name = "btnBookDetail";
            this.btnBookDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnBookDetail.Click += new System.EventHandler(this.btnBookDetail_Click);
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeleteBook;
            this.colDelete.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colDelete.Name = "colDelete";
            this.colDelete.OptionsColumn.AllowMove = false;
            this.colDelete.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colDelete.OptionsColumn.AllowSize = false;
            this.colDelete.OptionsColumn.FixedWidth = true;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 9;
            this.colDelete.Width = 44;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.AutoHeight = false;
            this.btnDeleteBook.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DTO.Book);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.tbSearchBookInStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(874, 6);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = false;
            this.btnImport.Size = new System.Drawing.Size(89, 36);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Nhập sách";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnImport.UseCompatibleTextRendering = true;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
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
            this.tbSearchBookInStock.Location = new System.Drawing.Point(30, 7);
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
            this.colBirthDate.Format.FormatString = "d";
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
            this.colDetail.Caption = "#";
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDetail.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
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
            this.panel3.Controls.Add(this.tbSearchStaff);
            this.panel3.Controls.Add(this.btnNewStaff);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 48);
            this.panel3.TabIndex = 1;
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
            this.tbSearchStaff.Location = new System.Drawing.Point(30, 7);
            this.tbSearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchStaff.Name = "tbSearchStaff";
            this.tbSearchStaff.Size = new System.Drawing.Size(370, 35);
            this.tbSearchStaff.TabIndex = 4;
            this.tbSearchStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchStaff.OnValueChanged += new System.EventHandler(this.tbSearchStaff_OnValueChanged);
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.ActiveBorderThickness = 1;
            this.btnNewStaff.ActiveCornerRadius = 20;
            this.btnNewStaff.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNewStaff.ActiveForecolor = System.Drawing.Color.White;
            this.btnNewStaff.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnNewStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewStaff.BackgroundImage")));
            this.btnNewStaff.ButtonText = "Thêm nhân viên";
            this.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStaff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNewStaff.IdleBorderThickness = 1;
            this.btnNewStaff.IdleCornerRadius = 20;
            this.btnNewStaff.IdleFillColor = System.Drawing.Color.White;
            this.btnNewStaff.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNewStaff.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewStaff.Location = new System.Drawing.Point(830, 8);
            this.btnNewStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(154, 33);
            this.btnNewStaff.TabIndex = 1;
            this.btnNewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1025, 451);
            // 
            // ssmLoading
            // 
            this.ssmLoading.ClosingDelay = 500;
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
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.dashboardNavigationPage.ResumeLayout(false);
            this.bookstallNavigationPage.ResumeLayout(false);
            this.customerNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.stockNavigationPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlBooksInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.staffNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem employeesTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem bookstallTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage dashboardNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage bookstallNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.TileBarItem stockTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem custommerTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem staffTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage stockNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customerNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage staffNavigationPage;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewStaff;
        private DevExpress.XtraTreeList.TreeList tlBooksInStock;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBookInStockName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublishedDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCost;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAuthor;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPublisher;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdentifier;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private MaterialSkin.Controls.MaterialFlatButton btnImport;
        private DevExpress.XtraBars.Navigation.TileBarItem statisticsTileBarItem;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssmLoading;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInventory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnBookDetail;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteBook;
        private DevExpress.XtraTreeList.TreeList tlCustomer;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerSex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerEmail;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerPhoneNo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndebtedness;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetailCustomer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCustomerDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewCustomer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearchBookInStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearchCustomer;
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
    }
}