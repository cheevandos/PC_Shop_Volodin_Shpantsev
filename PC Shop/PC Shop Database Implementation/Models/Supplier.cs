using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [ForeignKey("SupplierID")]
        public virtual List<Request> Requests { get; set; }
    }
}
