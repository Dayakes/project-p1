using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class CrustViewModel
    {
        public string Name { get; set; }

        public CrustViewModel(string name)
        {
            Name = name;
        }
    }
}