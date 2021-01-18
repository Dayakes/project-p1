using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public OrderViewModel Order { get; set; }
        public string SelectedStoreId { get; set; }
        public User CurrentUser { get; set; }
        public CustomerViewModel()
        {
            Order = new OrderViewModel();
        }
    }
}