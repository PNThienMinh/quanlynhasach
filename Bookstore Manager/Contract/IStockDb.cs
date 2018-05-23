using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStockDb
    {
        void InsertBook(Book book);

        void GetAllBookInDb();

        void GetStockContracts();

        void UpdateStockContracts(int newMinImport, int newMaxInventory);

        void InsertBooksReceipNote(string staffName, List<Book> books);

        void DeleteBookWithId(int idInDb);

        void UpdateBookInfo(Book newBookInfo);
    }
}
