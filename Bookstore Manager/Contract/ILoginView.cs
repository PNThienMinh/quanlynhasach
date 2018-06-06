using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface ILoginView
    {
        void OnLoginSuccess(User user);

        void OnLoginFail(string error);
    }
}
