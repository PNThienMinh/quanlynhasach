using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IStockContractInformation
    {
        void DisplayView(int minImport, int maxInventory);

        void NotifyUpdateContractsSuccessful();
    }
}
