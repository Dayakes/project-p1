using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class CrustViewModel
    {
        public List<Crust> Crusts { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public CrustViewModel()
        {
            Crusts = new List<Crust>{
                new Crust("regular"),
                new Crust("thin"),
                new Crust("stuffed")
            };
        }
    }
}