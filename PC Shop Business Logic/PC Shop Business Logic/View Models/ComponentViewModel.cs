using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    class ComponentViewModel
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
