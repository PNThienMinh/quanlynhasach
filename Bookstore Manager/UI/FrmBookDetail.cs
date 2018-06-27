using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract;
using DTO;
using Services;

namespace UI
{
    public partial class FrmBookDetail : Form, IBookDetail
    {
        private Book _bookInEditer;

        private IStockService _stockInfo;

        public FrmBookDetail(Book book)
        {
            _bookInEditer = book;
            InitializeComponent();
            _stockInfo = new StockService(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // enable edit mode
            tbCost.Enabled = true;
            btnSave.Enabled = true;
        }

        private void FrmBookDetail_Load(object sender, EventArgs e)
        {
            tbBookName.Text = _bookInEditer.Name;
            tbCategory.Text = _bookInEditer.Category;
            tbCost.Text = _bookInEditer.Cost.ToString();
            tbAuthor.Text = _bookInEditer.Author;
            tbPublisher.Text = _bookInEditer.Publisher;
            tbPublishDate.Text = _bookInEditer.PublishedDate.ToString("dd/MM/yyyy");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ID = _bookInEditer.ID;
            book.Cost = Convert.ToInt32(tbCost.Text);
            _stockInfo.EditBookInfor(book);

        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void NotifyUpdateBookInfoSuccess()
        {
            MessageBox.Show("Cập nhật thành công", "Hoàn tất", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void ErrorOccurWhenUpdateBookInfo(string error)
        {
            // TODO:
        }
    }
}
