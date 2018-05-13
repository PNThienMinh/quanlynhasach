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
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm, IStaffContract
    {
        // user for this session
        private User _user;

        // instances of business layer
        private IStaffToStaffInfo _iStaffInfo;

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
        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            User user = (User)treeListStaff.GetDataRecordByNode(treeListStaff.FocusedNode);
            FrmStaffDetail frmStaffDetail = new FrmStaffDetail(user);
            frmStaffDetail.ShowMdiChildCaptionInParentTitle = true;
            frmStaffDetail.ShowDialog();
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

        #region StockTab


        private void btnImport_Click(object sender, EventArgs e)
        {
            ssmLoading.ShowWaitForm();
            FrmBooksReceipt frmImport = new FrmBooksReceipt(_user);
            ssmLoading.CloseWaitForm();
            frmImport.ShowDialog();
        }


        #endregion

        private void tileBarItem4_ItemClick(object sender, TileItemEventArgs e)
        {

        }

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