using System.ComponentModel.DataAnnotations;

namespace PC_Shop_Database_Implementation.Models
{
    public class RequestComponent
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public int ComponentID { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public bool InReserve { get; set; }
        public virtual Request Request { get; set; }
        public virtual Component Component { get; set; }
    }
}
