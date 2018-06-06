using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DevExpress.XtraEditors;
using Services;

namespace UI
{
    public partial class FrmStockContractInformation : DevExpress.XtraEditors.XtraForm, IStockContractInfoView
    {

        private bool _editPermission = false;

        private IStockService _business;

        public FrmStockContractInformation(bool editPermission)
        {
            InitializeComponent();
            this._editPermission = editPermission;
            SetViewMode();
            InitializeInstances();
            Assign(this);
        }

        private void InitializeInstances()
        {
            _business = new StockService(this);
        }

        private void SetViewMode()
        {
            if (!_editPermission)
            {
                tbMaxQuantityInventory.Enabled = false;
                tbMinQuantityImport.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void Assign(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.TextChanged += new EventHandler(UpdateInfo);
                }
                else
                {
                    Assign(ctrl);
                }
            }
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        public void DisplayView(int minImport, int maxInventory)
        {
            tbMaxQuantityInventory.Text = maxInventory.ToString();
            tbMinQuantityImport.Text = minImport.ToString();
        }

        public void NotifyUpdateContractsSuccessful()
        {
            MessageBox.Show("Cập nhật thành công!", "", MessageBoxButtons.OK);
            this.Close();
        }

        private void FrmStockContractInformation_Load(object sender, EventArgs e)
        {

            _business.LoadStockContractInformations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!tbMinQuantityImport.Text.Equals("") && !tbMaxQuantityInventory.Text.Equals(""))
                _business.ChangeStockContracts(Int32.Parse(tbMinQuantityImport.Text), Int32.Parse(tbMaxQuantityInventory.Text));
        }


        private void tbMinQuantityImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void tbMaxQuantityInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}