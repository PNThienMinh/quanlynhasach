using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IReportRepoListener
    {
        void OnGetInventoryReportSuccessful(List<InventoryReport> inventoryReports);

        void OnGetInventoryReportFailure(string error);

        void OnGetIndebtednessReportSuccessful(List<IndebtednessReport> indebtednessReports);

        void OnGetIndebtednessReportFailure(string error);
    }
}
