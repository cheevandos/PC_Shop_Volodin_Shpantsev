using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class WarehouseComponent
    {
        public int ID { get; set; }
        public int WarehouseID { get; set; }
        public int ComponentID { get; set; }
        [Required]
        public int Free { get; set; }
        [Required]
        public int Reserved { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Component Component { get; set; }
    }
}
