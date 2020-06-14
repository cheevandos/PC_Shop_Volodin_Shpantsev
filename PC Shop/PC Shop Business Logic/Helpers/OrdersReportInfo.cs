using PC_Shop_Business_Logic.View_Models;
using System;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Helpers
{
    public class OrdersReportInfo
    {
        public string RecipientEmail { get; set; }
        public string FileName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ReportOrderViewModel> Orders { get; set; }
    }
}
