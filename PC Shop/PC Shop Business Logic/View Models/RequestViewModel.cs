using PC_Shop_Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class RequestViewModel
    {
        [DisplayName("Номер заявки")]
        public int ID { get; set; }
        public int SupplierID { get; set; }
        [DisplayName("Поставщик")]
        public string SupplierLogin { get; set; }
        [DisplayName("Статус")]
        public RequestStatus Status { get; set; }
        [DisplayName("Дата исполнения")]
        public DateTime? CompletionDate { get; set; }
        public Dictionary<int, (string, int, bool)> Components { get; set; }
    }
}
