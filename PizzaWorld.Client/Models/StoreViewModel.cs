using System.Collections.Generic;

namespace PizzaWorld.Client.Models
{
    public class StoreViewModel
    {
        public List<Order> Orders { get; set; }
        public string Name { get; set; }
    }
}