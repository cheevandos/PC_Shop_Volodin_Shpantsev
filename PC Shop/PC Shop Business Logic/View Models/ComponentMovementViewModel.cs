using PC_Shop_Business_Logic.Enums;
using System;
using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class ComponentMovementViewModel
    {
        public int ID { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Комплектующее")]
        public string ComponentName { get; set; }
        [DisplayName("Статус")]
        public ComponentStatus Status { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
    }
}
