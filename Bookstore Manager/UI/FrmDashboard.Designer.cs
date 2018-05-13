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
            this.stockNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnImport = new MaterialSkin.Controls.MaterialFlatButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublishedDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCost = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAuthor = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPublisher = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdentifier = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.treeListStaff = new DevExpress.XtraTreeList.TreeList();
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
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ssmLoading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::UI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.dashboardNavigationPage.SuspendLayout();
            this.bookstallNavigationPage.SuspendLayout();
            this.stockNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.staffNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.navigationFrame.Text = "navigationFrame";
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
            this.customerNavigationPage.Name = "customerNavigationPage";
            this.customerNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // stockNavigationPage
            // 
            this.stockNavigationPage.AllowTouchScroll = true;
            this.stockNavigationPage.Caption = "stockNavigationPage";
            this.stockNavigationPage.Controls.Add(this.btnImport);
            this.stockNavigationPage.Controls.Add(this.treeList1);
            this.stockNavigationPage.Name = "stockNavigationPage";
            this.stockNavigationPage.Size = new System.Drawing.Size(1025, 451);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImport.Location = new System.Drawing.Point(923, 6);
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
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1,
            this.colType,
            this.colPublishedDate,
            this.colCost,
            this.colAuthor,
            this.colPublisher,
            this.colIdentifier});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.bookBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsFind.AllowFindPanel = true;
            this.treeList1.OptionsFind.AlwaysVisible = true;
            this.treeList1.Size = new System.Drawing.Size(1025, 451);
            this.treeList1.TabIndex = 0;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 121;
            // 
            // colType
            // 
            this.colType.FieldName = "Category";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 120;
            // 
            // colPublishedDate
            // 
            this.colPublishedDate.FieldName = "PublishedDate";
            this.colPublishedDate.Name = "colPublishedDate";
            this.colPublishedDate.Visible = true;
            this.colPublishedDate.VisibleIndex = 2;
            this.colPublishedDate.Width = 120;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            this.colCost.Width = 120;
            // 
            // colAuthor
            // 
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 4;
            this.colAuthor.Width = 120;
            // 
            // colPublisher
            // 
            this.colPublisher.FieldName = "Publisher";
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 5;
            this.colPublisher.Width = 120;
            // 
            // colIdentifier
            // 
            this.colIdentifier.FieldName = "Identifier";
            this.colIdentifier.Name = "colIdentifier";
            this.colIdentifier.Visible = true;
            this.colIdentifier.VisibleIndex = 6;
            this.colIdentifier.Width = 120;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DTO.Book);
            // 
            // staffNavigationPage
            // 
            this.staffNavigationPage.Caption = "staffNavigationPage";
            this.staffNavigationPage.Controls.Add(this.btnNewStaff);
            this.staffNavigationPage.Controls.Add(this.treeListStaff);
            this.staffNavigationPage.Name = "staffNavigationPage";
            this.staffNavigationPage.Size = new System.Drawing.Size(1025, 451);
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
            this.btnNewStaff.Location = new System.Drawing.Point(692, 9);
            this.btnNewStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(154, 33);
            this.btnNewStaff.TabIndex = 1;
            this.btnNewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // treeListStaff
            // 
            this.treeListStaff.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colSex,
            this.colBirthDate,
            this.colEmail,
            this.colPhoneNum,
            this.colFuntion,
            this.colUsername,
            this.colDetail});
            this.treeListStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListStaff.DataSource = this.userBindingSource;
            this.treeListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListStaff.Location = new System.Drawing.Point(0, 0);
            this.treeListStaff.Name = "treeListStaff";
            this.treeListStaff.OptionsBehavior.EnableFiltering = true;
            this.treeListStaff.OptionsBehavior.ExpandNodesOnFiltering = true;
            this.treeListStaff.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.treeListStaff.OptionsBehavior.ReadOnly = true;
            this.treeListStaff.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListStaff.OptionsCustomization.AllowBandMoving = false;
            this.treeListStaff.OptionsCustomization.AllowColumnMoving = false;
            this.treeListStaff.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.treeListStaff.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treeListStaff.OptionsFind.AllowFindPanel = true;
            this.treeListStaff.OptionsFind.AlwaysVisible = true;
            this.treeListStaff.OptionsFind.FindDelay = 500;
            this.treeListStaff.OptionsFind.ShowClearButton = false;
            this.treeListStaff.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeListStaff.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.treeListStaff.Size = new System.Drawing.Size(1025, 451);
            this.treeListStaff.TabIndex = 0;
            this.treeListStaff.VisibleChanged += new System.EventHandler(this.LoadStaff);
            // 
            // colName
            // 
            this.colName.Caption = "Họ và tên";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 140;
            // 
            // colSex
            // 
            this.colSex.Caption = "Giới tính";
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
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
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            this.colBirthDate.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 165;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Caption = "Số điện thoại";
            this.colPhoneNum.FieldName = "PhoneNum";
            this.colPhoneNum.Name = "colPhoneNum";
            this.colPhoneNum.Visible = true;
            this.colPhoneNum.VisibleIndex = 4;
            this.colPhoneNum.Width = 99;
            // 
            // colFuntion
            // 
            this.colFuntion.Caption = "Chức vụ";
            this.colFuntion.FieldName = "Funtion";
            this.colFuntion.Name = "colFuntion";
            this.colFuntion.Visible = true;
            this.colFuntion.VisibleIndex = 5;
            this.colFuntion.Width = 130;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Tài khoản";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 6;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDetail.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetail_ButtonClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DTO.User);
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
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.dashboardNavigationPage.ResumeLayout(false);
            this.bookstallNavigationPage.ResumeLayout(false);
            this.stockNavigationPage.ResumeLayout(false);
            this.stockNavigationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.staffNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private DevExpress.XtraTreeList.TreeList treeListStaff;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBirthDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmail;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhoneNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFuntion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUsername;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewStaff;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
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
    }
}