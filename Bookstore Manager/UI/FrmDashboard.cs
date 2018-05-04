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
using Excel = Microsoft.Office.Interop.Excel;

namespace UI
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm, IStaffContract
    {
        // user for this session
        private User _user;

        // instances of business layer
        private IStaffToStaffInfo _iStaffInfo;

        // variable for static part
        private static BackgroundWorker _workerImport;
        private static string _filePath;

        public FrmDashboard()
        {
            InitializeComponent();
            InitialzeInstances();
            InitWorkers();
        }

        public FrmDashboard(User user)
        {
            this._user = user;
            InitializeComponent();
            InitialzeInstances();
            InitWorkers();
        }

        // initial instances of business layer
        private void InitialzeInstances()
        {
            _iStaffInfo = new StaffInfo(this);

        }
        // tab animations
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        #region StaffTab

        private void LoadStaff(object sender, EventArgs e)
        {
            if (staffNavigationPage.IsControlLoaded)
                _iStaffInfo.GetListUsersExists();
        }
        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            User user = (User)treeListStaff.GetDataRecordByNode(treeListStaff.FocusedNode);
            FrmStaffDetail frmStaffDetail = new FrmStaffDetail(user);
            frmStaffDetail.ShowMdiChildCaptionInParentTitle = true;
            frmStaffDetail.Show();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            FrmNewStaff frmNewStaff = new FrmNewStaff();
            frmNewStaff.ShowMdiChildCaptionInParentTitle = true;
            frmNewStaff.Show();
        }
        public void DisplayListUsersToUI(List<User> users)
        {
            treeListStaff.DataSource = users;
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

        #endregion

        #region StoreTab
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Excel File";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.InitialDirectory = @"E:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;

                _workerImport.RunWorkerAsync();

            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }
        #region WorkerReadExcelFile
        // initial static worker for read excel file
        private void InitWorkers()
        {
            _workerImport = new BackgroundWorker();
            _workerImport.WorkerReportsProgress = true;
            _workerImport.WorkerSupportsCancellation = true;
            _workerImport.DoWork += _workerImport_DoWork;
            _workerImport.ProgressChanged += _workerImport_ProgressChanged;
            _workerImport.RunWorkerCompleted += __workerImport_RunWorkerCompleted;
        }

        private static void __workerImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        private static void _workerImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private static void _workerImport_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadExcelFile(_filePath);
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
                _workerImport.ReportProgress((int)(i / rowCount));

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

            _workerImport.CancelAsync();
        }

        #endregion

        #endregion

       
    }
}