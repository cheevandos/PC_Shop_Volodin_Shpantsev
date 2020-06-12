using PC_Shop_Business_Logic.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class ComponentMovement
    {
        public int ID { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public ComponentStatus Status { get; set; }
        public int SupplierID { get; set; }
        public int ComponentID { get; set; }
        public virtual Component Component { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
