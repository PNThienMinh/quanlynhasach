using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStallRepo
    {
        bool CheckIfUserCanBuy(Customer customer, int total, int due);

        bool CheckIfAllBooksMeetRequirement(List<Book> books);

        void CreateBill(int staffId, int customerId, List<Book> booksInBill, int total, int due);

    }
}
