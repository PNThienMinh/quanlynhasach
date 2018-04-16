using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffTab_Click(object sender, EventArgs e)
        {
            DisplayStaffTab();
        }

        private void DisplayStaffTab()
        {
            Container.Controls.Clear();
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.TopLevel = false;
            frmStaff.AutoScroll = true;
            Container.Controls.Add(frmStaff);
            frmStaff.Show();
        }


    }
}
