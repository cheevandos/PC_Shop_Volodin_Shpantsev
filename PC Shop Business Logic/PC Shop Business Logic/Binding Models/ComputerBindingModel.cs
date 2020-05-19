using System;
using System.Collections.Generic;
using System.Text;

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
