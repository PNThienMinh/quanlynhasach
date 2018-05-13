using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Contract;
using DatabaseModel;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DTO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FrmBooksReceipt : DevExpress.XtraBars.Ribbon.RibbonForm, IStockContract
    {
        private User _user;

        private IStockInfo _business;

        private BackgroundWorker _workerImport;
        private string _filePath;

        private int _numberOfFailToAdd = 0;

        private List<Book> _booksLoaded;

        private List<Book> _booksInDocket = new List<Book>();

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
            _business = new StockInfo(this);
            tlBookInDocket.DataSource = _booksInDocket;
        }

        private void LoadData()
        {
            _business.LoadAllBooks();
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            tlBookInDocket.ShowRibbonPrintPreview();
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
                pgbAdding.Position = 0;_workerImport.RunWorkerAsync();

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
        }

        public void GetListBooksFail(string error)
        {
            // TODO:
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!tbSearch.Text.Equals(""))
            {
                int id = 0;
                if (Int32.TryParse(tbSearch.Text, out id))
                    AddBookToDocket(id);
                tbSearch.Text = "";
                tbSearch.Focus();
            }
            else
            {
                tbSearch.Refresh();
            }
        }
        private void AddBookToDocket(int id)
        {
            var book = _booksLoaded.Select(b => b).Where(b => b.Identifier == id);
            if (book.Count() != 0)
            {
                if (_booksInDocket.Select(b => b).Count(b => b.Identifier == book.ElementAt(0).Identifier) == 0)
                {
                    _booksInDocket.Add(book.ElementAt(0));
                    tlBookInDocket.RefreshDataSource();
                }
            }

        }

        private void btnRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            tlBookInDocket.DeleteSelectedNodes();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void bbiContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool editableFlag;
            if (_user.Funtion.Equals("Quản lý"))
                editableFlag = true;
            else
                editableFlag = false;

            FrmStockContractInformation frmStockContract = new FrmStockContractInformation(editableFlag);
            frmStockContract.ShowDialog();

        }
    }
}