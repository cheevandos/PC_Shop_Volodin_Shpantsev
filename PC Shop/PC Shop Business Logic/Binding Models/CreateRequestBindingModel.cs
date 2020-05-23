using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class CreateRequestBindingModel
    {
        public int SupplierID { get; set; }
        public Dictionary<int, (string, int)> Components { get; set; }
    }
}
