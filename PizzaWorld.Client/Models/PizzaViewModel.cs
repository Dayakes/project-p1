using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class PizzaViewModel
    {
        public string Name { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }
        public List<ToppingViewModel> Toppings { get; set; }
        public decimal Price { get; set; }
        public PizzaViewModel()
        {

        }
        public PizzaViewModel(string name)
        {
            Name = name;
        }
    }
}