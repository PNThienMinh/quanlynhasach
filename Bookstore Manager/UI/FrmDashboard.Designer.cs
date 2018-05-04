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
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.employeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.customersTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.dashboardNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.bookstallNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customerNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.storeNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnImport = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.dashboardNavigationPage.SuspendLayout();
            this.bookstallNavigationPage.SuspendLayout();
            this.storeNavigationPage.SuspendLayout();
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
            this.tileBar.MaxId = 6;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.employeesTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(859, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.employeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.customersTileBarItem);
            this.tileBarGroupTables.Items.Add(this.tileBarItem1);
            this.tileBarGroupTables.Items.Add(this.tileBarItem2);
            this.tileBarGroupTables.Items.Add(this.tileBarItem3);
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
            tileItemElement11.Image = global::UI.Properties.Resources.gradientgreendatabar_32x32;
            tileItemElement11.ImageUri.Uri = "ListBullets";
            tileItemElement11.Text = "Bảng điều khiển";
            this.employeesTileBarItem.Elements.Add(tileItemElement11);
            this.employeesTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.employeesTileBarItem.Name = "employeesTileBarItem";
            // 
            // customersTileBarItem
            // 
            this.customersTileBarItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.customersTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customersTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.customersTileBarItem.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersTileBarItem.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.customersTileBarItem.AppearanceItem.Selected.Options.UseFont = true;
            this.customersTileBarItem.AppearanceItem.Selected.Options.UseImage = true;
            this.customersTileBarItem.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.customersTileBarItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.customersTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.Image = global::UI.Properties.Resources.morefunctions_32x32;
            tileItemElement12.ImageUri.Uri = "Copy";
            tileItemElement12.Text = "Quầy sách";
            this.customersTileBarItem.Elements.Add(tileItemElement12);
            this.customersTileBarItem.Id = 2;
            this.customersTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.customersTileBarItem.Name = "customersTileBarItem";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileBarItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem1.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem1.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBarItem1.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBarItem1.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.tileBarItem1.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement13.Image = global::UI.Properties.Resources.open_32x32;
            tileItemElement13.Text = "Kho";
            this.tileBarItem1.Elements.Add(tileItemElement13);
            this.tileBarItem1.Id = 3;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileBarItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileBarItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem2.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem2.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBarItem2.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBarItem2.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.Image = global::UI.Properties.Resources.bocustomer_32x32;
            tileItemElement14.Text = "Khách hàng";
            this.tileBarItem2.Elements.Add(tileItemElement14);
            this.tileBarItem2.Id = 4;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileBarItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.tileBarItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem3.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem3.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBarItem3.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBarItem3.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Always;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement15.Image = global::UI.Properties.Resources.bodepartment_32x32;
            tileItemElement15.Text = "Nhân viên";
            this.tileBarItem3.Elements.Add(tileItemElement15);
            this.tileBarItem3.Id = 5;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.dashboardNavigationPage);
            this.navigationFrame.Controls.Add(this.bookstallNavigationPage);
            this.navigationFrame.Controls.Add(this.customerNavigationPage);
            this.navigationFrame.Controls.Add(this.storeNavigationPage);
            this.navigationFrame.Controls.Add(this.staffNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.dashboardNavigationPage,
            this.bookstallNavigationPage,
            this.storeNavigationPage,
            this.customerNavigationPage,
            this.staffNavigationPage});
            this.navigationFrame.SelectedPage = this.dashboardNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(859, 451);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // dashboardNavigationPage
            // 
            this.dashboardNavigationPage.Caption = "dashboardNavigationPage";
            this.dashboardNavigationPage.Controls.Add(this.employeesLabelControl);
            this.dashboardNavigationPage.Name = "dashboardNavigationPage";
            this.dashboardNavigationPage.Size = new System.Drawing.Size(859, 451);
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
            this.employeesLabelControl.Size = new System.Drawing.Size(859, 451);
            this.employeesLabelControl.TabIndex = 2;
            this.employeesLabelControl.Text = "Bảng điều khiển";
            // 
            // bookstallNavigationPage
            // 
            this.bookstallNavigationPage.Caption = "bookstallNavigationPage";
            this.bookstallNavigationPage.Controls.Add(this.customersLabelControl);
            this.bookstallNavigationPage.Name = "bookstallNavigationPage";
            this.bookstallNavigationPage.Size = new System.Drawing.Size(859, 451);
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
            this.customersLabelControl.Size = new System.Drawing.Size(859, 451);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // customerNavigationPage
            // 
            this.customerNavigationPage.Caption = "customerNavigationPage";
            this.customerNavigationPage.Name = "customerNavigationPage";
            this.customerNavigationPage.Size = new System.Drawing.Size(859, 451);
            // 
            // storeNavigationPage
            // 
            this.storeNavigationPage.AllowTouchScroll = true;
            this.storeNavigationPage.Caption = "storeNavigationPage";
            this.storeNavigationPage.Controls.Add(this.btnImport);
            this.storeNavigationPage.Controls.Add(this.btnAdd);
            this.storeNavigationPage.Controls.Add(this.treeList1);
            this.storeNavigationPage.Name = "storeNavigationPage";
            this.storeNavigationPage.Size = new System.Drawing.Size(859, 451);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.Location = new System.Drawing.Point(731, 6);
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
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(634, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm sách";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.treeList1.Size = new System.Drawing.Size(859, 451);
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
            this.colType.FieldName = "Type";
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
            this.staffNavigationPage.Size = new System.Drawing.Size(859, 451);
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
            this.treeListStaff.Size = new System.Drawing.Size(859, 451);
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDetail.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetail_ButtonClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DTO.User);
            // 
            // FrmDashboard
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "FrmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.dashboardNavigationPage.ResumeLayout(false);
            this.bookstallNavigationPage.ResumeLayout(false);
            this.storeNavigationPage.ResumeLayout(false);
            this.storeNavigationPage.PerformLayout();
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
        private DevExpress.XtraBars.Navigation.TileBarItem customersTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage dashboardNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage bookstallNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.NavigationPage storeNavigationPage;
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
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
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
    }
}