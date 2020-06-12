using System;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class ComponentMovementBindingModel
    {
        public int SupplierID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
