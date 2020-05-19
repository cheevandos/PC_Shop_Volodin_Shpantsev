using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Component
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("ComponentID")]
        public virtual List<WarehouseComponent> WarehouseComponents { get; set; }
        [ForeignKey("ComponentID")]
        public virtual List<RequestComponent> RequestComponents { get; set; }
    }
}
