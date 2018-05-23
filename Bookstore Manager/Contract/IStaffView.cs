using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IStaffView
    {
        void DisplayListUsersToUI(List<User> users);

        void OnFetchDataFailure(string error);

        void NotifyDeleteSuccessful();

        void ShowErrorDeleteFailure(string error);
    }
}
