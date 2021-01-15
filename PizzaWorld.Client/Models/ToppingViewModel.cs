using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class ToppingViewModel
    {
        // public List<Topping> Toppings { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ToppingViewModel()
        {
            // Toppings = new List<Topping>(){
            // new Topping("cheese"),
            // new Topping(""),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // new Topping(),
            // };
        }
    }
}