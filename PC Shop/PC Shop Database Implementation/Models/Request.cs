using PC_Shop_Business_Logic.Enums;
using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class Request
    {
        public int ID { get; set; }
        [Required]
        public RequestStatus Status { get; set; }
        [Required]
        public int Count { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int ComponentID { get; set; }
        public virtual Component Component { get; set; }
    }
}
