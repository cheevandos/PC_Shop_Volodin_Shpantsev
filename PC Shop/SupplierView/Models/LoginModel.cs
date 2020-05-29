using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SupplierView.Models
{
    public class LoginModel
    {
        [DisplayName("Электронная почта")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Password { get; set; }
    }
}
