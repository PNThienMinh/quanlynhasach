﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Contract;
using DTO;

namespace GUI
{
    public partial class FrmStaffDetail : Form, IStaffDetail
    {
        private IStaffToStaffInfo _business;
        private User _user;

        public FrmStaffDetail()
        {
            InitializeComponent();
            InitBusiness();
        }

        public FrmStaffDetail(User user)
        {
            InitializeComponent();
            this._user = user;
            DisplayStaffInfo(user);
            InitBusiness();
        }

        public void InitBusiness()
        {
            _business = new StaffInfo(this);
            _business.GetListFunctions();
        }

        private void DisplayStaffInfo(User user)
        {
            tbName.Text = user.Name;
            tbEmail.Text = user.Email;
            cbFunc.Text = user.Funtion;
            tbPhoneNo.Text = user.PhoneNum;
            tbUID.Text = user.MId;
            tbSex.Text = user.Sex;
            datePicker.Value = user.BirthDate;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.FormatCustom = "dd/MM/yyyy";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void LoadListFunctionToUI(List<Function> functions)
        {
            functionBindingSource.DataSource = functions;
            cbFunc.Text = _user.Funtion;
        }

        public void HandleGetFunctionsFail(string error)
        {
            // TODO: Handle error when can't fetch
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
            btnUpdate.Enabled = true;
        }

        private void FrmStaffDetail_Load(object sender, EventArgs e)
        {
            Assign(this);
            btnUpdate.Enabled = false;
        }
    }
}
