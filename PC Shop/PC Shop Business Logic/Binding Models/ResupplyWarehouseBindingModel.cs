using System;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class ResupplyWarehouseBindingModel
    {
        public int SupplierID { get; set; }
        public int WarehouseID { get; set; }
        public int ComponentID { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
    }
}
