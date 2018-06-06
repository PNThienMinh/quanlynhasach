using System.Collections.Generic;
using Contract;
using Data;
using DTO;

namespace Services
{
    public class StallService : IStallService, IStallRepoListener
    {
        private IStallView _stallView;
        private IStallRepo _db;

        public StallService(IStallView view)
        {
            this._stallView = view;
            _db = new StallRepo(this);
        }


        public void ExportBill(int staffId, Customer customer, List<Book> books, int total, int due)
        {
            if (!_db.CheckIfUserCanBuy(customer, total, due))
            {
                _stallView.NotifyUserCantBuy();
                return;
            }

            if (_db.CheckIfAllBooksMeetRequirement(books))
                _db.CreateBill(staffId, customer.ID, books, total, due);

        }

        public void OnListBookNotMeetRequirement(List<int> listBooksError)
        {
            _stallView.NotifyListBooksNotMeetRequirement(listBooksError);
        }

        public void OnCreateBillSuccessful(string path)
        {
            _stallView.NotifyCreateBillSuccessful(path);
        }

        public void OnCreateBillFailure(string error)
        {
            _stallView.NotifyCreateBillFailure(error);
        }
    }
}
