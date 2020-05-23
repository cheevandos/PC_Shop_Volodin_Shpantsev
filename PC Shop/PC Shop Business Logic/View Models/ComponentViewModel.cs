using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class ComponentViewModel
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
