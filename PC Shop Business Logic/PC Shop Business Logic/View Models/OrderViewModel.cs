using PC_Shop_Business_Logic.Enums;
using System.ComponentModel;
using System;

namespace PC_Shop_Business_Logic.View_Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public int ComputerID { get; set; }
        [DisplayName("Название компьютера")]
        public int ComputerName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма заказа")]
        public decimal Amount { get; set; }
        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Дата завершения")]
        public DateTime? CompletionDate { get; set; }
    }
}
