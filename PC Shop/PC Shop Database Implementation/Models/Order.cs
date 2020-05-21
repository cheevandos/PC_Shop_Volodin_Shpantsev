using System;
using System.ComponentModel.DataAnnotations;
using PC_Shop_Business_Logic.Enums;

namespace PC_Shop_Database_Implementation.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        public int ComputerID { get; set; }
        public virtual Computer Computer { get; set; }
    }
}
