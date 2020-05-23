using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class SupplierViewModel
    {
        public int ID { get; set; }
        [DisplayName("Ф.И.О.")]
        public string FullName { get; set; }
        [DisplayName("Склад")]
        public string Warehouse { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
