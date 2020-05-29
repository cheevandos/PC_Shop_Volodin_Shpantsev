using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        [DisplayName("Ф.И.О.")]
        [Required(ErrorMessage = "Заполните поле")]
        public string FullName { get; set; }
        [DisplayName("Электронная почта")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [ForeignKey("SupplierID")]
        public virtual List<Warehouse> Warehouses { get; set; }
        [ForeignKey("SupplierID")]
        public virtual List<Request> Requests { get; set; }
    }
}
