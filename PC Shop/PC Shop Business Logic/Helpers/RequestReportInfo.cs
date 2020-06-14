using PC_Shop_Business_Logic.Enums;
using System;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Helpers
{
    public class RequestReportInfo
    {
        public ReportType ReportType { get; set; }
        public string FileName { get; set; }
        public int RequestID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public DateTime? CompletionDate { get; set; }
        public Dictionary<int, (string, int, bool)> RequestComponents { get; set; }
    }
}
