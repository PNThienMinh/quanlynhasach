using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStallRepoListener
    {
        
        void OnListBookNotMeetRequirement(List<int> listBooksError);

        void OnCreateBillSuccessful(string path);

        void OnCreateBillFailure(string error);

    }
}
