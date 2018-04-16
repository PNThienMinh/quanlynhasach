using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ILoginDbToLoginInfo
    {
        void OnGetUserFromDatabaseSuccess(User user);

        void OnGetUserFromDatabaseFailure(string error);

    }
}
