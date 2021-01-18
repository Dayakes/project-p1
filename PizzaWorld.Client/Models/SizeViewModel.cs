using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class SizeViewModel
    {
        public string Name { get; set; }
        public SizeViewModel(string name)
        {
            Name = name;
        }
    }
}