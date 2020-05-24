using PC_Shop_Business_Logic.Enums;
using System.ComponentModel;
using System;

namespace PC_Shop_Business_Logic.View_Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public int ComputerID { get; set; }
        [DisplayName("Название ПК")]
        public string ComputerName { get; set; }
        [DisplayName("Кол-во")]
        public int Count { get; set; }
        [DisplayName("Сумма заказа")]
        public decimal Amount { get; set; }
        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }
        [DisplayName("Создан")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Завершен")]
        public DateTime? CompletionDate { get; set; }
    }
}
