namespace PizzaWorld.Client.Models
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public OrderViewModel Order { get; set; }
        public CustomerViewModel()
        {
            Name = "darren";
            Order = new OrderViewModel();
        }
    }
}