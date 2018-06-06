using Contract;
using Data;
using DTO;

namespace Services
{
    public class LoginService : ILoginService, ILoginRepoListener
    {
        private ILoginRepo _listenerLoginDb;
        private ILoginView _loginView;

        public LoginService(ILoginView loginView)
        {
            _listenerLoginDb = new LoginRepo(this);
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
