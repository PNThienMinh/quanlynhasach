using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IStallView
    {
        void NotifyUserCantBuy();

        void NotifyListBooksNotMeetRequirement(List<int> listBooksError);

        void NotifyCreateBillSuccessful(string billPath);

        void NotifyCreateBillFailure(string error);
    }
}
