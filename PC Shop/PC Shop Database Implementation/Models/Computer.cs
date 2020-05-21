using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Shop_Database_Implementation.Models
{
    public class Computer
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("ComputerID")]
        public virtual List<ComputerComponent> ComputerComponents { get; set; }
        [ForeignKey("ComputerID")]
        public virtual List<Order> Orders { get; set; }
    }
}
