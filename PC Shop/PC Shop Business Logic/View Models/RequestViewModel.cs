using PC_Shop_Business_Logic.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class RequestViewModel
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        [DisplayName("Поставщик")]
        public string SupplierName { get; set; }
        public int Count { get; set; }
        [DisplayName("Статус")]
        public RequestStatus Status { get; set; }
        public Dictionary<int, (string, int)> Components { get; set; }
    }
}
