using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Contract;
using DatabaseModel;

namespace Business
{
    public class LoginInfo : ILoginFormToLoginInfo, ILoginDbToLoginInfo
    {
        private ILoginDb _listenerLoginDb;
        private ILoginContract _loginView;

        public LoginInfo(ILoginContract loginView)
        {
            _listenerLoginDb = new LoginDb(this);
            _loginView = loginView;
        }

        public void ValidateUser(string username, string password)
        {
            _listenerLoginDb.GetUser(username, password);
        }

        public void OnGetUserFromDatabaseSuccess(User user)
        {
            _loginView.OnLoginSuccess(user);
        }

        public void OnGetUserFromDatabaseFailure(string error)
        {
            _loginView.OnLoginFail(error);
        }

      
    }
}
