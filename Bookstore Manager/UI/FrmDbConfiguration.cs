using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Services;

namespace UI
{
    public partial class FrmDbConfiguration : DevExpress.XtraEditors.XtraForm
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private string _connectionString = "";

        public FrmDbConfiguration()
        {
            InitializeComponent();
            tbServerName.Focus();
        }

        private void btnCheckConn_Click(object sender, EventArgs e)
        {
            if (tbServerName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên server!", "Nhắc nhở", MessageBoxButtons.OK);
                return;
            }

            string tempConnStr = "Data Source=" + tbServerName.Text.Trim() + ";Initial Catalog=BM;Integrated Security=True";

            if (!ssmWaiting.IsSplashFormVisible)
                ssmWaiting.ShowWaitForm();

            if (Ultilities.IsValidConnection(tempConnStr))
            {
                btnOk.Enabled = true;
                ssmWaiting.CloseWaitForm();
                MessageBox.Show("Kiểm tra kết nối thành công!", "Thành công", MessageBoxButtons.OK);
            }
            else
            {
                ssmWaiting.CloseWaitForm();
                MessageBox.Show("Không tìm thấy server!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Ultilities.SaveConnectionInformation(tbServerName.Text.Trim());
            MessageBox.Show("Cấu hình cơ sở dữ liệu thành công!\nChương trình sẽ được khởi động lại!", "Thông báo", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            Application.Restart();
        }

        private void tbServerName_OnValueChanged(object sender, EventArgs e)
        {
            if (btnOk.Enabled == true)
                btnOk.Enabled = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!btnOk.Enabled)
            {
                var result = MessageBox.Show("Bạn chưa thiết lập kết nối cơ sở dữ liệu\nTiếp tục?", "Cảnh báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    Application.Exit();
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}