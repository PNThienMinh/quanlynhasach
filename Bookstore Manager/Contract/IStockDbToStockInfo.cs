using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStockDbToStockInfo
    {
        void OnInsertBookToDbSuccessful();

        void OnInsertBookToDbFail(string error);

        void OnGetAllBookSuccess(List<Book> books);

        void OnGetAllBookFail(string error);

        void OnGetContractSuccess(int minImport, int maxInventory);

        void OnGetContractFailure(string error);

        void OnUpdateStockContractsSuccessful();

        void OnUpdateStockContractsFailure(string error);

        void OnAddBookToReceiptNoteSuccessful(string path);

        void OnAddBookToReceiptNoteFail(string msg);

        void OnUpdateBookInfoSuccessful();

        void OnUpdateBookInfoFailure(string msg);

    }
}
