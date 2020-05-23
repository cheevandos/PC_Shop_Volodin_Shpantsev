using PC_Shop_Business_Logic.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Request
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        [Required]
        public RequestStatus Status { get; set; }
        [ForeignKey("RequestID")]
        public virtual List<RequestComponent> RequestComponents { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
