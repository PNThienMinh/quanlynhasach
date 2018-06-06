using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStockService
    {

        void AddBookToDb(Book book);

        void LoadAllBooks();

        void LoadStockContractInformations();

        void ChangeStockContracts(int newMinImport, int newMaxInventory);

        void AddBooksReceiptNote(string staffName, List<Book> books);

       
        void EditBookInfor(Book newBookInfo);


    }
}
