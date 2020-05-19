using PC_Shop_Business_Logic.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class Request
    {
        public int ID { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        [Required]
        public RequestStatus Status { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
