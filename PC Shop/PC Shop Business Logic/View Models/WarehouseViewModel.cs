﻿using System.Collections.Generic;
using System.ComponentModel;

namespace PC_Shop_Business_Logic.View_Models
{
    public class WarehouseViewModel
    {
        public int ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        public int SupplierID { get; set; }
        [DisplayName("Поставщик")]
        public string SupplierName { get; set; }
        [DisplayName("Вместимость")]
        public int Capacity { get; set; }
        public Dictionary<int, (string, int, int)> Components { get; set; }
    }
}
