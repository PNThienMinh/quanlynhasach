using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IReportRepo
    {
        void GetInventoryReportOfDate(DateTime date);

        void GetIndebtednessReportOfDate(DateTime date);
    }
}
