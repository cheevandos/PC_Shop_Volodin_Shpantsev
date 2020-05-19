using PC_Shop_Business_Logic.Enums;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class RequestBindingModel
    {
        public int? ID { get; set; }
        public int SupplierID { get; set; }
        public int ComponentID { get; set; }
        public int Count { get; set; }
        public RequestStatus Status { get; set; }
    }
}
