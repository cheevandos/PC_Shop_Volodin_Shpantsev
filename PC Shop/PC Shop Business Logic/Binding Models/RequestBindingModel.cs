using PC_Shop_Business_Logic.Enums;
using System;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class RequestBindingModel
    {
        public int? ID { get; set; }
        public int SupplierID { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime? CompletionDate { get; set; }
        public Dictionary<int, (string, int, bool)> Components { get; set; }
    }
}
