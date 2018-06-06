using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IReportService
    {
        void LoadInventoryReport(DateTime date);

        void LoadIndebtednessReport(DateTime date);
    }
}
