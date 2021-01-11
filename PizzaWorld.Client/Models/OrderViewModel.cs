using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<APizzaModel> Pizzas { get; set; }
        public List<Store> Stores { get; set; }
        public List<APizzaModel> PizzaSelection { get; set; }
        public Store Store { get; set; }
    }
}