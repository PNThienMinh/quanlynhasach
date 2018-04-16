using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ILoginContract
    {
        void OnLoginSuccess(User user);

        void OnLoginFail(string error);
    }
}
