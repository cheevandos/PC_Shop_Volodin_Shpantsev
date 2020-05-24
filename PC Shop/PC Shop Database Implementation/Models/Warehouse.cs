using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Warehouse
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        [ForeignKey("WarehouseID")]
        public virtual List<WarehouseComponent> WarehouseComponents { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
