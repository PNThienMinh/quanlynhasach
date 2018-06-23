using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Data;
using DTO;

namespace Services
{
    public class AdminService : IAdminService, IAdminRepoListener
    {

        private IAdminView _adminView;
        private IAdminRepo _db;

        public AdminService(IAdminView view)
        {
            this._adminView = view;
            _db = new AdminRepo(this);
        }

        public void LoadData()
        {
            _db.LoadData();
        }

        public void ChangeRule(Rule newRule)
        {
            _db.ChangeRule(newRule);
        }

        public void OnGetDataSuccess(Rule rule, StoreReport report)
        {
            _adminView.DisplayDataToUI(rule, report);
        }

        public void OnChangeRuleSuccess()
        {
            _adminView.NotifyUpdateRuleSuccess();
        }
    }
}
