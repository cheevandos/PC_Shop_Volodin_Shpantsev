using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Warehouse
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [DisplayName("Название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [DisplayName("Вместимость")]
        public int Capacity { get; set; }
        [ForeignKey("WarehouseID")]
        public virtual List<WarehouseComponent> WarehouseComponents { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
