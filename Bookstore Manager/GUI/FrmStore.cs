using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Contract;
using DatabaseModel;
using DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class FrmStore : Form
    {
        private static BackgroundWorker _backgroundWorker;
        private static string filePath;
        private User _user;

        public FrmStore(User user)
        {
            this._user = user;
            InitializeComponent();
            InitFields();
        }

       
        private static void InitFields()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
        }

        private static void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Thread stop by user!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Task completed!", "Success", MessageBoxButtons.OK);

            }
        }

        private static void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private static void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadExcelFile(filePath);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Excel File";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.InitialDirectory = @"E:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                _backgroundWorker.RunWorkerAsync();

            }

        }

        public static void ReadExcelFile(string dir)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(dir);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                Book book = new Book();

                book.Name = xlRange.Cells[i, 1].Value2.ToString();
                book.Type = xlRange.Cells[i, 2].Value2.ToString();
                string dateTimeTemp = xlRange.Cells[i, 3].Value2.ToString();
                double d = double.Parse(dateTimeTemp);
                book.PublishedDate = DateTime.FromOADate(d);
                book.Cost = Int32.Parse(xlRange.Cells[i, 4].Value2.ToString());
                book.Author = xlRange.Cells[i, 5].Value2.ToString();
                book.Publisher = xlRange.Cells[i, 6].Value2.ToString();
                book.Identifier = Convert.ToInt32(xlRange.Cells[i, 7].Value2.ToString());

                ExcelFileHandler.InsertBookToDb(book);
                _backgroundWorker.ReportProgress((int)(i / rowCount));

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

            _backgroundWorker.CancelAsync();
        }

        private void btnImportBook_Click(object sender, EventArgs e)
        {
            
        }
    }
}
