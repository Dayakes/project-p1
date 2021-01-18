using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class PizzaViewModel
    {
        public string Name { get; set; }
        public CrustViewModel Crust { get; set; }
        public SizeViewModel Size { get; set; }
        public List<ToppingViewModel> Toppings { get; set; }
        public decimal Price { get; set; }
        public PizzaViewModel()
        {

        }
        public PizzaViewModel(string name)
        {
            Name = name;
            Size = new SizeViewModel();
            Crust = new CrustViewModel();
        }
    }
}