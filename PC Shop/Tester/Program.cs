using PC_Shop_Business_Logic.Business_Logic;
using PC_Shop_Business_Logic.Helpers;
using System;
using System.Collections.Generic;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEcxel();
        }

        public static void TestEcxel()
        {
            Dictionary<int, (string, int, bool)> dictionary = new Dictionary<int, (string, int, bool)>
            {
                { 1, ("Процессор", 4, true) },
                { 2, ("Процессор", 4, true) },
                { 3, ("Процессор", 4, true) }
            };
            RequestReportInfo reportInfo = new RequestReportInfo()
            {
                FileName = @"D:\dualshock\testExcelReport.xlsx",
                SupplierName = "Петров А.А.",
                RequestID = 5,
                CompletionDate = DateTime.Now,
                RequestComponents = dictionary
            };
            ExcelService.CreatePackage(reportInfo);
        }
    }
}
