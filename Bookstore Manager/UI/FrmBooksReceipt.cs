using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraBars;
using DTO;
using Services;


namespace UI
{
    public partial class FrmBooksReceipt : DevExpress.XtraBars.Ribbon.RibbonForm, IStockImport
    {
        private User _user;

        private IStockService _business;

        private BackgroundWorker _workerImport;
        private string _filePath;

        private int _numberOfFailToAdd = 0;

        private List<Book> _booksLoaded;

        private List<Book> _booksInDocket = new List<Book>();

        private List<string> _booksNotMeetRequirement = new List<string>();

        private int minImport = 0, maxInventory = 0;

        public FrmBooksReceipt(User user)
        {
            InitializeComponent();
            InitWorkers();
            InitializeInstances();
            this._user = user;
            LoadData();
        }

        private void InitializeInstances()
        {
            _business = new StockService(this);
            tlBookInDocket.DataSource = _booksInDocket;
        }

        private void LoadData()
        {
            _business.LoadAllBooks();
        }

        private void InitWorkers()
        {
            _workerImport = new BackgroundWorker();
            _workerImport.WorkerReportsProgress = true;
            _workerImport.WorkerSupportsCancellation = true;
            _workerImport.DoWork += _workerImport_DoWork;
            _workerImport.ProgressChanged += _workerImport_ProgressChanged;
            _workerImport.RunWorkerCompleted += __workerImport_RunWorkerCompleted;
        }

        private void __workerImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Error occur!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                LoadData();
                MessageBox.Show("Đọc file hoàn tất với " + _numberOfFailToAdd + " lỗi", "Hoàn tất",
                    MessageBoxButtons.OK);
                pgbAdding.Visible = false;
            }
        }

        private void _workerImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbAdding.Position = e.ProgressPercentage;
        }

        private void _workerImport_DoWork(object sender, DoWorkEventArgs e)
        {

            ExcelRead(_filePath);
        }

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Excel File";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.InitialDirectory = @"E:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                pgbAdding.Visible = true;
                pgbAdding.Position = 0; _workerImport.RunWorkerAsync();

            }
        }

        private void ExcelRead(string filePath)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            for (int i = 1; i <= rowCount; i++)
            {

                Book book = new Book();

                book.Name = xlRange.Cells[i, 1].Value2.ToString();
                book.Category = xlRange.Cells[i, 2].Value2.ToString();
                string dateTimeTemp = xlRange.Cells[i, 3].Value2.ToString();
                double d = double.Parse(dateTimeTemp);
                book.PublishedDate = DateTime.FromOADate(d);
                book.Cost = Int32.Parse(xlRange.Cells[i, 4].Value2.ToString());
                book.Author = xlRange.Cells[i, 5].Value2.ToString();
                book.Publisher = xlRange.Cells[i, 6].Value2.ToString();
                book.Identifier = Convert.ToInt32(xlRange.Cells[i, 7].Value2.ToString());

                _business.AddBookToDb(book);

                _workerImport.ReportProgress((int)(i * 100 / rowCount));
                // Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");  

                //add useful things here!     
            }

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:  
            //  never use two dots, all COM objects must be referenced and released individually  
            //  ex: [somthing].[something].[something] is bad  

            //release com objects to fully kill excel process from running in the background  
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release  
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release  
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

        }

        public void DisplayPercentProgress()
        {
            // TODO:
        }

        public void ReportFailure(string error)
        {
            _numberOfFailToAdd++;
        }

        public void AllBooksLoaded(List<Book> books)
        {
            _booksLoaded = books;
            gridLookUpBook.Properties.DataSource = _booksLoaded;
        }

        public void GetListBooksFail(string error)
        {
            // TODO:
        }

        public void LoadStockContractsSuccessful(int minImport, int maxInventory)
        {
            this.minImport = minImport;
            this.maxInventory = maxInventory;

        }

        public void ShowReceiptPreview(string path)
        {
            ssmWaiting.CloseWaitForm();
            MessageBox.Show("File xuất đã lưu " + path, "Thành công!", MessageBoxButtons.OK);
        }

        private void btnRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            tlBookInDocket.DeleteSelectedNodes();
        }

        private void bbiContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool editableFlag;
            if (_user.IDFunc == 1)
                editableFlag = true;
            else
                editableFlag = false;

            FrmStockContractInformation frmStockContract = new FrmStockContractInformation(editableFlag);
            frmStockContract.ShowDialog();
        }

        private void ShowErrorDialog()
        {
            string booksNotMeetRequirement = null;
            foreach (string identifier in _booksNotMeetRequirement)
            {
                booksNotMeetRequirement += " | " + identifier;
            }

            MessageBox.Show(
                "Những sách sau không đủ điều kiện nhập: \n " + booksNotMeetRequirement,
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void bbiExportBooksReceiptNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_booksInDocket.Count == 0)
                return;

            ssmWaiting.ShowWaitForm();
            _business.LoadStockContractInformations();

            CheckIfDocketIsMeetRequirement();

            if (_booksNotMeetRequirement.Count > 0)
            {
                ssmWaiting.CloseWaitForm();
                ShowErrorDialog();
                return;
            }

            else
            {
                _business.AddBooksReceiptNote(_user.Name, _booksInDocket);
            }
        }

        private void bbiClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            _booksInDocket.Clear();
            tlBookInDocket.RefreshDataSource();
        }

        private void gridLookUpBook_EditValueChanged(object sender, EventArgs e)
        {
            Book book = (Book)gridLookUpBook.GetSelectedDataRow();
            if (book != null)
            {
                if (_booksInDocket.Count(b => b.Identifier == book.Identifier) == 0)
                {
                    _booksInDocket.Add(book);
                    tlBookInDocket.RefreshDataSource();
                }
            }
            gridLookUpBook.ResetText();
        }

        private void CheckIfDocketIsMeetRequirement()
        {
            _booksNotMeetRequirement.Clear();
            foreach (Book book in _booksInDocket)
            {
                if (book.Count < minImport || book.Inventory > maxInventory)
                    _booksNotMeetRequirement.Add(book.Identifier.ToString());
            }
        }
    }
}