using PC_Shop_Business_Logic.Enums;
using System;

namespace PC_Shop_Business_Logic.View_Models
{
    public class ReportOrderViewModel
    {
        public string ComputerName { get; set; }
        public int Count { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
