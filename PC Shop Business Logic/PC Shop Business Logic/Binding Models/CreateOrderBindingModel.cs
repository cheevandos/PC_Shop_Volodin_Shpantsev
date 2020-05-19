namespace PC_Shop_Business_Logic.Binding_Models
{
    public class CreateOrderBindingModel
    {
        public int ComputerID { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }
    }
}
