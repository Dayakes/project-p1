namespace PizzaWorld.Client.Models
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public OrderViewModel Order { get; set; }
        public CustomerViewModel()
        {
            Order = new OrderViewModel();
        }
    }
}