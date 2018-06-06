using System;
using System.Collections.Generic;
using Contract;
using Data;
using DTO;

namespace Services
{
    public class StockService : IStockService, IStockDbToStockInfo
    {
        private IStockRepo _db;
        private IStockImport _stockImport;
        private IStockContractInfoView _stockContractInformation;
        private IStockView _stockView;
        private IBookDetail _bookDetail;

        public StockService(IStockImport stockImport)
        {
            this._stockImport = stockImport;
            _db = new StockRepo(this);
        }

        public StockService(IStockContractInfoView stockContractInformation)
        {
            this._stockContractInformation = stockContractInformation;
            _db = new StockRepo(this);
        }

        public StockService(IStockView _stockView)
        {
            this._stockView = _stockView;
            _db = new StockRepo(this);
        }

        public StockService(IBookDetail _bookDetail)
        {
            this._bookDetail = _bookDetail;
            _db = new StockRepo(this);
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
                _stockView.FillDataSource(books);
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
