using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class AvailableViewModel
    {
        [DisplayName("Склад")]
        public string WarehouseName { get; set; }
        public int WarehouseID { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}
