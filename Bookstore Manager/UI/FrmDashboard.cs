using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Contract;
using DTO;
using Services;

namespace UI
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm, IStaffView, IStockView, ICustomerView, IStallView, IReportView, IAdminView
    {
        // user for this session
        private User _user;

        // instances of business layer
        private IStaffService _staffService;
        private IStockService _stockService;
        private ICustomerService _customerService;
        private IStallService _stallService;
        private IReportService _reportService;
        private IAdminService _adminService;

        // list Collection
        private List<Book> _booksStock = new List<Book>();
        private List<Customer> _customers = new List<Customer>();
        private List<User> _users = new List<User>();
        private List<Book> _booksAvailable = new List<Book>();
        private List<Book> _booksInBill = new List<Book>();


        public FrmDashboard()
        {
            InitializeComponent();
            InitialzeInstances();
        }

        public FrmDashboard(User user)
        {
            this._user = user;
            InitializeComponent();
            InitialzeInstances();
            if (_user.IDFunc != 1)
            {
                adminTileBarItem.Visible = false;
                staffTileBarItem.Visible = false;}
        }

        // initial instances of business layer
        private void InitialzeInstances()
        {
            _staffService = new StaffService(this);
            _stockService = new StockService(this);
            _customerService = new CustomerService(this);
            _stallService = new StallService(this);
            _reportService = new ReportService(this);
            _adminService = new AdminService(this);
        }

        // tab animations
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            ssmLoading.ShowWaitForm();
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            ssmLoading.CloseWaitForm();

        }

        #region StallTab
        private void bookstallNavigationPage_VisibleChanged(object sender, EventArgs e)
        {
            ResetStoreTab();
            if (bookstallNavigationPage.IsControlLoaded)
            {
                _stockService.LoadAllBooks();
                _customerService.LoadAllCustomers();
            }
        }
        private void ResetStoreTab()
        {
            if (_booksInBill.Count != 0)
                _booksInBill.Clear();

            tlBookInBill.DataSource = _booksInBill;
            tlBookInBill.RefreshDataSource();

            if (gridLookUpBook.Enabled == false)
                gridLookUpBook.Enabled = true;
            if (tlBookInBill.OptionsBehavior.Editable == false)
                tlBookInBill.OptionsBehavior.Editable = true;
            if (btnShowBillInfo.Visible == false)
                btnShowBillInfo.Visible = true;

            if (btnShowBillInfo.Visible == false)
                btnShowBillInfo.Visible = true;
            if (panelCustomerSearch.Visible == true)
                panelCustomerSearch.Visible = false;
            if (panelBillInfo.Visible == true)
                panelBillInfo.Visible = false;
            if (panelStatus.Visible == true)
                panelStatus.Visible = false;
            if (panelCheckout.Visible == true)
                panelCheckout.Visible = false;

            tbCustomerPaid.ResetText();
            tbTotal.ResetText();
            tbChange.ResetText();
            tbTotal.ResetText();
            tbIndebtedness.ResetText();

            gridLookUpCustomer.ResetText();


        }
        private void gridLookUpBook_EditValueChanged(object sender, EventArgs e)
        {
            Book book = (Book)gridLookUpBook.GetSelectedDataRow();
            if (book != null)
            {
                if (_booksInBill.Count(b => b.Identifier == book.Identifier) == 0)
                {
                    _booksInBill.Add(book);
                    tlBookInBill.RefreshDataSource();
                }
            }
            gridLookUpBook.ResetText();
        }
        private void btnShowBillInfo_Click(object sender, EventArgs e)
        {

            if (_booksInBill.Count < 1)
                return;

            foreach (var book in _booksInBill)
            {
                if (book.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", "Nhắc nhở", MessageBoxButtons.OK);
                    return;
                }
            }
            if (btnBackToEdit.Visible == false)
                btnBackToEdit.Visible = true;

            btnShowBillInfo.Visible = false;

            lblStaff.Text = "Nhân viên: " + _user.Name;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");

            panelStatus.Visible = true;
            panelBillInfo.Visible = true;
            panelCustomerSearch.Visible = true;
            panelCheckout.Visible = true;

            gridLookUpBook.Enabled = false;
            tlBookInBill.OptionsBehavior.Editable = false;
            btnShowBillInfo.Visible = false;

            int total = 0;
            foreach (var book in _booksInBill)
            {
                total += book.Cost * book.Count;
            }

            tbTotal.Text = total.ToString();
            tbCustomerPaid.Focus();

        }
        private void btnBackToEdit_Click(object sender, EventArgs e)
        {
            gridLookUpBook.Enabled = true;
            tlBookInBill.OptionsBehavior.Editable = true;
            btnShowBillInfo.Visible = true;

            if (panelCustomerSearch.Visible == true)
                panelCustomerSearch.Visible = false;
            if (panelBillInfo.Visible == true)
                panelBillInfo.Visible = false;
            if (panelStatus.Visible == true)
                panelStatus.Visible = false;
            if (panelCheckout.Visible == true)
                panelCheckout.Visible = false;

            if (btnBackToEdit.Visible == true)
                btnBackToEdit.Visible = false;
        }
        private void btnDeleteBookInBill_Click(object sender, EventArgs e)
        {
            tlBookInBill.DeleteSelectedNodes();
        }
        private void tbCustomerPaid_OnValueChanged(object sender, EventArgs e)
        {
            if (!tbCustomerPaid.Text.Trim().Equals("") && Regex.Matches(tbCustomerPaid.Text.Trim(), @"[a-zA-Z]").Count < 1 && Ultilities.IsDigitsOnly(tbCustomerPaid.Text.Trim()))
            {
                int change = Convert.ToInt32(tbCustomerPaid.Text.Trim()) - Convert.ToInt32(tbTotal.Text.Trim());

                if (change > 0)
                {
                    tbChange.Text = change.ToString();
                    tbIndebtedness.Text = "0";
                }
                else
                {
                    tbChange.Text = "0";
                    tbIndebtedness.Text = change.ToString();
                }
            }
        }
        private void tbCustomerPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar == '.'
                && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (gridLookUpCustomer.GetSelectedDataRow() == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            if (tbCustomerPaid.Text.Trim().Equals("") || Regex.Matches(tbCustomerPaid.Text.Trim(), @"[a-zA-Z]").Count > 0 || !Ultilities.IsDigitsOnly(tbCustomerPaid.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách hàng thanh toán!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show("Xuất hoá đơn?", "Xác nhận giao dịch", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            ssmLoading.ShowWaitForm();
            var customer = ((Customer)gridLookUpCustomer.GetSelectedDataRow());
            _stallService.ExportBill(_user.ID, customer, _booksInBill, Convert.ToInt32(tbTotal.Text.Trim()), Convert.ToInt32(tbIndebtedness.Text.Trim()));
        }
        private void gridLookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void NotifyUserCantBuy()
        {
            if (ssmLoading.IsSplashFormVisible)
                ssmLoading.CloseWaitForm();
            MessageBox.Show("Số tiền khách hàng này đang nợ vượt quá quy định!", "Nhắc nhở", MessageBoxButtons.OK);
        }
        public void NotifyListBooksNotMeetRequirement(List<int> listBooksError)
        {
            ssmLoading.CloseWaitForm(); string list = "";
            foreach (var book in listBooksError)
            {
                list += book + " |";
            }

            MessageBox.Show("Đầu sách: " + list + " không thoả điều kiện tồn sau tối thiểu!", "Nhắc nhở",
                MessageBoxButtons.OK);
        }
        public void NotifyCreateBillSuccessful(string billPath)
        {
            ssmLoading.CloseWaitForm();
            MessageBox.Show("Tạo hoá đơn thành công!\nHoá đơn được lưu vào " + billPath, "Hoàn tất",
                MessageBoxButtons.OK);
            ResetStoreTab();
        }
        public void NotifyCreateBillFailure(string error)
        {
            // TODO Handle error occur
            MessageBox.Show("Xuất hoá đơn thất bại!", "Lỗi", MessageBoxButtons.OK);
        }
        #endregion
        #region StockTab
        private void btnImport_Click(object sender, EventArgs e)
        {
            ssmLoading.ShowWaitForm();
            using (var form = new FrmBooksReceipt(_user))
            {
                ssmLoading.CloseWaitForm();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceStock();
                }
            }
        }
        private void tbSearchBookInStock_OnTextChange(object sender, EventArgs e)
        {
            string keyword = tbSearchBookInStock.Text.Trim().ToLower();
            if (keyword.Equals(""))
            {
                tlBooksInStock.DataSource = _booksStock;
                tlBooksInStock.RefreshDataSource();
                return;
            }

            var matchValue = _booksStock.Where(x => x.Name.ToLower().Contains(keyword)).ToList(); tlBooksInStock.DataSource = matchValue;
            tlBooksInStock.RefreshDataSource();

        }
        private void ReloaDataSourceStock()
        {
            _stockService.LoadAllBooks();
        }
        private void btnBookDetail_Click(object sender, EventArgs e)
        {
            Book book = (Book)tlBooksInStock.GetDataRecordByNode(tlBooksInStock.FocusedNode);
            using (var form = new FrmBookDetail(book))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceStock();
                }
            }
        }
        private void LoadBooksInStock(object sender, EventArgs e)
        {
            if (stockNavigationPage.IsControlLoaded)
            {
                _stockService.LoadAllBooks();
            }
        }
        public void FillDataSource(List<Book> books)
        {
            _booksStock = books;
            var bookAvailable = books.Where(b => b.Inventory > 0).ToList();
            foreach (var book in bookAvailable)
            {
                book.Cost = (int)(book.Cost * Constant.PRICE_RATIO);
            }

            _booksAvailable = bookAvailable;
            gridLookUpBook.Properties.DataSource = _booksAvailable;
            tlBooksInStock.DataSource = books;
        }
        #endregion
        #region StaffTab
        private void LoadStaff(object sender, EventArgs e)
        {
            if (staffNavigationPage.IsControlLoaded)
                _staffService.GetListUsersExists();
        }
        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            User user = (User)tlStaff.GetDataRecordByNode(tlStaff.FocusedNode);
            using (var form = new FrmStaffDetail(user))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceStaff();
                }
            }
        }
        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            using (var form = new FrmNewStaff())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceStaff();
                }
            }
        }
        private void ReloaDataSourceStaff()
        {
            _staffService.GetListUsersExists();
        }
        public void DisplayListUsersToUI(List<User> users)
        {
            _users = users;
            tlStaff.DataSource = users;
        }
        public void OnFetchDataFailure(string error)
        {
            MessageBox.Show(error, "Error occur!", MessageBoxButtons.OK);
        }
        private void tbSearchStaff_OnValueChanged(object sender, EventArgs e)
        {
            string keyword = tbSearchStaff.Text.Trim().ToLower();
            if (keyword.Equals(""))
            {
                tlStaff.DataSource = _users;
                tlStaff.RefreshDataSource();
                return;
            }
            var matchValue = _users.Where(x => x.Name.ToLower().Contains(keyword)).ToList();
            tlStaff.DataSource = matchValue;
            tlStaff.RefreshDataSource();
        }
        #endregion
        #region CustomerTab
        private void LoadCustomers(object sender, EventArgs e)
        {
            if (customerNavigationPage.IsControlLoaded)
                _customerService.LoadAllCustomers();
        }
        private void tbSearchCustomer_OnValueChanged(object sender, EventArgs e)
        {
            string keyword = tbSearchCustomer.Text.Trim().ToLower();
            if (keyword.Equals(""))
            {
                tlCustomer.DataSource = _customers;
                tlCustomer.RefreshDataSource();
                return;
            }

            var matchValue = _customers.Where(x => x.Name.ToLower().Contains(keyword)).ToList();
            tlCustomer.DataSource = matchValue;
            tlCustomer.RefreshDataSource();
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new FrmNewCustomer())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceCustomer();
                }
            }
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)tlCustomer.GetDataRecordByNode(tlCustomer.FocusedNode);
            if (customer.Indebtedness == 0)
                return;
            using (var form = new FrmReceive(customer))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceCustomer();
                }
            }
        }
        private void btnDetailCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)tlCustomer.GetDataRecordByNode(tlCustomer.FocusedNode);
            using (var form = new FrmNewCustomer(customer))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReloaDataSourceCustomer();
                }
            }
        }
        private void ReloaDataSourceCustomer()
        {
            _customerService.LoadAllCustomers();
        }
        public void DislayCustomers(List<Customer> customers)
        {
            _customers = customers;
            gridLookUpCustomer.Properties.DataSource = customers;
            tlCustomer.DataSource = customers;
        }
        public void ErrorOccurWhenLoadCustomers(string msg)
        {
            //TODO: Handle error occur
        }
        #endregion
        #region ReportTab
        private void statisticsNavigationPage_VisibleChanged(object sender, EventArgs e)
        {
            datePickerReport.Format = DateTimePickerFormat.Custom;
            datePickerReport.CustomFormat = "MM - yyyy";
            datePickerReport.ShowUpDown = true;
        }
        private void rbInventoryReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInventoryReport.Checked)
            {
                tlInventoryReport.Visible = true;
                tlIndebtednessReport.Visible = false;
            }
            else
            {
                tlInventoryReport.Visible = false;
                tlIndebtednessReport.Visible = true;
            }
        }
        public void DisplayInventoryReportsData(List<InventoryReport> listReports)
        {
            tlInventoryReport.DataSource = listReports;
            tlInventoryReport.RefreshDataSource();
        }
        public void NotifyFetchDataFailure(string error)
        {
            tlInventoryReport.DataSource = null;
            tlInventoryReport.RefreshDataSource();
            tlIndebtednessReport.DataSource = null;
            tlIndebtednessReport.RefreshDataSource();
            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK);
        }
        public void DisplayIndebtednessReportsData(List<IndebtednessReport> listReports)
        {
            tlIndebtednessReport.DataSource = listReports;
            tlIndebtednessReport.RefreshDataSource();
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (rbInventoryReport.Checked)
                _reportService.LoadInventoryReport(datePickerReport.Value);
            else if (rbIndebtednessReport.Checked)
                _reportService.LoadIndebtednessReport(datePickerReport.Value);
        }
        #endregion
        #region AdminTab
        private void adminNavigationPage_VisibleChanged(object sender, EventArgs e)
        {
            if (adminNavigationPage.IsControlLoaded)
            {
                _adminService.LoadData();
            }
        }
        public void DisplayDataToUI(Rule rule, StoreReport report)
        {
            lbNumBookImport.Text = report.NumBookImport.ToString();
            lbNumBookInStock.Text = report.NumBookInStock.ToString();
            lbRevenue.Text = report.Revenue.ToString();
            lbNumBookSold.Text = report.NumBookSold.ToString();

            tbMinImport.Text = rule.MinImport.ToString();
            tbMaxInventory.Text = rule.MaxInventory.ToString();
            tbMinLastInventory.Text = rule.MinInventory.ToString();
            tbMaxIndebtedness.Text = rule.MaxIndebtedness.ToString();
        }

        public void NotifyUpdateRuleSuccess()
        {
            MessageBox.Show("Cập nhật thành công!", "Hoàn tất!", MessageBoxButtons.OK);
            ResetAdminPage();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbMinImport.Enabled = true;
            tbMaxInventory.Enabled = true;
            tbMinLastInventory.Enabled = true;
            tbMaxIndebtedness.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                )
            {
                e.Handled = true;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e){
            if (tbMinImport.Text.Trim().Equals("") || tbMaxInventory.Text.Trim().Equals("") ||
                tbMinLastInventory.Text.Trim().Equals("")
                || tbMaxIndebtedness.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các quy định!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            Rule rule = new Rule();

            rule.MinImport = Int32.Parse(tbMinImport.Text.Trim());
            rule.MaxInventory = Int32.Parse(tbMaxInventory.Text.Trim());
            rule.MinInventory = Int32.Parse(tbMinLastInventory.Text.Trim());
            rule.MaxIndebtedness = Int32.Parse(tbMaxIndebtedness.Text.Trim());

            _adminService.ChangeRule(rule);
        }

        void ResetAdminPage()
        {
            tbMinImport.Enabled = false;
            tbMaxInventory.Enabled = false;
            tbMinLastInventory.Enabled = false;
            tbMaxIndebtedness.Enabled = false;
            btnUpdate.Enabled = false;
        }

        #endregion
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //// Confirm user wants to close
            //switch (MessageBox.Show(this, "Đóng chương trình?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    case DialogResult.Yes:
            //        e.Cancel = false;Application.Exit();
            //        break;
            //    case DialogResult.No:
            //        e.Cancel = true;
            //        break;
            //}

            Application.Exit();
        }

    }
}