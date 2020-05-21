using System.Collections.Generic;

namespace PC_Shop_Business_Logic.Binding_Models
{
    public class ComputerBindingModel
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> Components { get; set; }
    }
}
