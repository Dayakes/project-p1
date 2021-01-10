using System.Collections.Generic;

namespace PizzaWorld.Client.Models
{
    public class UserViewModel
    {
        public List<OrderViewModel> Orders { get; set; }
        public string Name { get; set; }
    }
}