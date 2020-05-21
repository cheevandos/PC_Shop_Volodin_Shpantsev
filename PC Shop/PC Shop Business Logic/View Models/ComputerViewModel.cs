using System.ComponentModel;
using System.Collections.Generic;

namespace PC_Shop_Business_Logic.View_Models
{
    public class ComputerViewModel
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int , (string, int)> Components { get; set; }
    }
}
