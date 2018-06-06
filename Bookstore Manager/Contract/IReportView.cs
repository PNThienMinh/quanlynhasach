using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Contract
{
    public interface IReportView
    {
        void DisplayInventoryReportsData(List<InventoryReport> listReports);

        void NotifyFetchDataFailure(string error);

        void DisplayIndebtednessReportsData(List<IndebtednessReport> listReports);


    }
}
