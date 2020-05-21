using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class ComputerComponent
    {
        public int ID { get; set; }
        public int ComponentID { get; set; }
        public int ComputerID { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual Computer Computer { get; set; }
    }
}
