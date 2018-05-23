using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStockImport
    {
        void DisplayPercentProgress();

        void ReportFailure(string error);

        void AllBooksLoaded(List<Book> books);

        void GetListBooksFail(string error);

        void LoadStockContractsSuccessful(int minImport, int maxInventory);

        void ShowReceiptPreview(string path);
    }
}
