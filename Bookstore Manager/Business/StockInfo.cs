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
        private IStockContract _stockContract;
        private IStockDb _db;
        private IStockContractInformation _stockContractInformation;

        public StockInfo(IStockContract stockContract)
        {
            this._stockContract = stockContract;
            _db = new StockDb(this);
        }

        public StockInfo(IStockContractInformation stockContractInformation)
        {
            this._stockContractInformation = stockContractInformation;
            _db = new StockDb(this);
        }

        public void AddBookToDb(Book book)
        {
            _db.InsertBook(book);
        }

        public void LoadAllBooks()
        {
           _db.GetAllBookInDb();}

        public void LoadStockContractInformations()
        {
            _db.GetStockContracts();
        }

        public void ChangeStockContracts(int newMinImport, int newMaxInventory)
        {
            _db.UpdateStockContracts(newMinImport, newMaxInventory);   
        }

        public void OnInsertBookToDbSuccessful()
        {
            _stockContract.DisplayPercentProgress();
        }

        public void OnInsertBookToDbFail(string error)
        {
            _stockContract.ReportFailure(error);
        }

        public void OnGetAllBookSuccess(List<Book> books)
        {
            _stockContract.AllBooksLoaded(books);
        }

        public void OnGetAllBookFail(string error)
        {
            _stockContract.GetListBooksFail(error);
        }

        public void OnGetContractSuccess(int minImport, int maxInventory)
        {
            _stockContractInformation.DisplayView(minImport, maxInventory);
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
    }
}
