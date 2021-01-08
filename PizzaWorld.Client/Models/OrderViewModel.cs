using System.Collections.Generic;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<Pizza> Pizzas { get; set; }
        public decimal TotalPrice { get; set; }
    }
}