﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IStockContractInfoView
    {
        void DisplayView(int minImport, int maxInventory);

        void NotifyUpdateContractsSuccessful();
    }
}
