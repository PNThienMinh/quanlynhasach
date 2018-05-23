using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Contract;
using Business;
using DatabaseModel;
using DevExpress.XtraTreeList.Columns;
using DTO;

namespace UI
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm, IStaffView, IStockView, ICustomerView
    {
        // user for this session
        private User _user;

        // instances of business layer
        private IStaffInfo _iStaffInfo;
        private IStockInfo _iStockInfo;
        private ICustomerInfo _iCustomerInfo;

        // list Collection
        private List<Book> _booksStock = new List<Book>();
        private List<Customer> _customers = new List<Customer>();
        private List<User> _users = new List<User>();

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
        }

        // initial instances of business layer
        private void InitialzeInstances()
        {
            _iStaffInfo = new StaffInfo(this);
            _iStockInfo = new StockInfo(this);
            _iCustomerInfo = new CustomerInfo(this);

        }

        // tab animations
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            ssmLoading.ShowWaitForm();
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            ssmLoading.CloseWaitForm();

        }

        #region StaffTab

        private void LoadStaff(object sender, EventArgs e)
        {
            if (staffNavigationPage.IsControlLoaded)
                _iStaffInfo.GetListUsersExists();
        }

        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e){
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
            _iStaffInfo.GetListUsersExists();
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

        public void NotifyDeleteSuccessful()
        {
            throw new NotImplementedException();
        }

        public void ShowErrorDeleteFailure(string error)
        {
            throw new NotImplementedException();
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

        #region StockTab


        private void btnImport_Click(object sender, EventArgs e)
        {
            ssmLoading.ShowWaitForm();
            FrmBooksReceipt frmImport = new FrmBooksReceipt(_user);
            ssmLoading.CloseWaitForm();
            frmImport.ShowDialog();
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
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xoá cuốn sách này khỏi kho?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    Book book = (Book)tlBooksInStock.GetDataRecordByNode(tlBooksInStock.FocusedNode);
                    _iStockInfo.DeleteBookFromStock(book.ID);
                    tlBooksInStock.DataSource = null;
                    ReloaDataSourceStock();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void ReloaDataSourceStock()
        {
            _iStockInfo.LoadAllBooks();
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
                _iStockInfo.LoadAllBooks();
            }
        }

        public void DisplayBooksToUI(List<Book> books)
        {
            _booksStock = books;
            tlBooksInStock.DataSource = books;
        }

        #endregion

        #region CustomerTab
        private void LoadCustomers(object sender, EventArgs e)
        {
            if (customerNavigationPage.IsControlLoaded)
                _iCustomerInfo.LoadAllCustomers();
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

        private void btnDetailCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void btnDeleteCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắc muốn xoá khách hàng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Customer customer = (Customer)tlCustomer.GetDataRecordByNode(tlCustomer.FocusedNode);
                _iCustomerInfo.DeleteCustomerWithId(customer.ID);
            }

        }

        private void ReloaDataSourceCustomer()
        {
            _iCustomerInfo.LoadAllCustomers();
        }

        public void DislayCustomers(List<Customer> customers)
        {
            _customers = customers;
            tlCustomer.DataSource = customers;
        }

        public void ErrorOccurWhenLoadCustomers(string msg)
        {
            //TODO:
        }

        public void NotifyDeleteCustomerSuccessful()
        {
            ReloaDataSourceCustomer();
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