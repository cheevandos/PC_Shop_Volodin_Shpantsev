namespace PC_Shop_Business_Logic.Binding_Models
{
    public class WarehouseBindingModel
    {
        public int? ID { get; set; }
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
