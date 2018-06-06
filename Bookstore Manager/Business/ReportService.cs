using System;
using System.Collections.Generic;
using Contract;
using Data;
using DTO;

namespace Services
{
    public class ReportService: IReportService, IReportRepoListener
    {

        private IReportView _reportView;
        private IReportRepo _db;

        public ReportService(IReportView reportView)
        {
            this._reportView = reportView;
            _db = new ReportRepo(this);
        }

        public void LoadInventoryReport(DateTime date)
        {
            _db.GetInventoryReportOfDate(date);
        }

        public void LoadIndebtednessReport(DateTime date)
        {
            _db.GetIndebtednessReportOfDate(date);
        }

        public void OnGetInventoryReportSuccessful(List<InventoryReport> inventoryReports)
        {
            _reportView.DisplayInventoryReportsData(inventoryReports);
        }

        public void OnGetInventoryReportFailure(string error)
        {
            _reportView.NotifyFetchDataFailure(error);
        }

        public void OnGetIndebtednessReportSuccessful(List<IndebtednessReport> indebtednessReports)
        {
            _reportView.DisplayIndebtednessReportsData(indebtednessReports);
        }

        public void OnGetIndebtednessReportFailure(string error)
        {
            _reportView.NotifyFetchDataFailure(error);
        }
    }
}
