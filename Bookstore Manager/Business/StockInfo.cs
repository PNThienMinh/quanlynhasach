using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using DatabaseModel;
using DTO;

namespace Business
{
    public class StockInfo : IStockInfo, IStockDbToStockInfo
    {
        private IStockDb _db;
        private IStockImport _stockImport;
        private IStockContractInformation _stockContractInformation;
        private IStockView _stockView;
        private IBookDetail _bookDetail;

        public StockInfo(IStockImport stockImport)
        {
            this._stockImport = stockImport;
            _db = new StockDb(this);
        }

        public StockInfo(IStockContractInformation stockContractInformation)
        {
            this._stockContractInformation = stockContractInformation;
            _db = new StockDb(this);
        }

        public StockInfo(IStockView _stockView)
        {
            this._stockView = _stockView;
            _db = new StockDb(this);
        }

        public StockInfo(IBookDetail _bookDetail)
        {
            this._bookDetail = _bookDetail;
            _db = new StockDb(this);
        }

        public void AddBookToDb(Book book)
        {
            _db.InsertBook(book);
        }

        public void LoadAllBooks()
        {
            _db.GetAllBookInDb();
        }

        public void LoadStockContractInformations()
        {
            _db.GetStockContracts();
        }

        public void ChangeStockContracts(int newMinImport, int newMaxInventory)
        {
            _db.UpdateStockContracts(newMinImport, newMaxInventory);
        }

        public void AddBooksReceiptNote(string staffName, List<Book> books)
        {
            _db.InsertBooksReceipNote(staffName, books);
        }

        public void DeleteBookFromStock(int idInDb)
        {
            _db.DeleteBookWithId(idInDb);
        }

        public void EditBookInfor(Book newBookInfo)
        {
            _db.UpdateBookInfo(newBookInfo);
        }


        public void OnInsertBookToDbSuccessful()
        {
            _stockImport.DisplayPercentProgress();
        }

        public void OnInsertBookToDbFail(string error)
        {
            _stockImport.ReportFailure(error);
        }

        public void OnGetAllBookSuccess(List<Book> books)
        {
            if (_stockImport != null)
                _stockImport.AllBooksLoaded(books);
            else if (_stockView != null)
                _stockView.DisplayBooksToUI(books);
        }

        public void OnGetAllBookFail(string error)
        {
            _stockImport.GetListBooksFail(error);
        }

        public void OnGetContractSuccess(int minImport, int maxInventory)
        {
            if (_stockContractInformation != null)
                _stockContractInformation.DisplayView(minImport, maxInventory);
            else if (_stockImport != null)
                _stockImport.LoadStockContractsSuccessful(minImport, maxInventory);
        }

        public void OnGetContractFailure(string error)
        {
            // TODO:
        }

        public void OnUpdateStockContractsSuccessful()
        {
            _stockContractInformation.NotifyUpdateContractsSuccessful();
        }

        public void OnUpdateStockContractsFailure(string error)
        {
            //TODO
        }

        public void OnAddBookToReceiptNoteSuccessful(string path)
        {
            _stockImport.ShowReceiptPreview(path);
        }

        public void OnAddBookToReceiptNoteFail(string msg)
        {
            throw new NotImplementedException();
        }

        public void OnUpdateBookInfoSuccessful()
        {
            _bookDetail.NotifyUpdateBookInfoSuccess();
        }

        public void OnUpdateBookInfoFailure(string msg)
        {
            //TODO:
        }
    }
}
