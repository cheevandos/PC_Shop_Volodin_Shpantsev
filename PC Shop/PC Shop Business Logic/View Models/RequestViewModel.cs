using PC_Shop_Business_Logic.Enums;
using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class RequestViewModel
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        [DisplayName("Поставщик")]
        public string SupplierName { get; set; }
        public int ComponentID { get; set; }
        [DisplayName("Комплектующее")]
        public string ComponentName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Статус")]
        public RequestStatus Status { get; set; }
    }
}
