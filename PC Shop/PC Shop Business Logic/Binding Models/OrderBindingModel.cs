using PC_Shop_Business_Logic.Enums;
using System;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class OrderBindingModel
    {
        public int? ID { get; set; }
        public int ComputerID { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
