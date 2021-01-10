using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<APizzaModel> Pizzas { get; set; }
        public decimal TotalPrice { get; set; }
    }
}