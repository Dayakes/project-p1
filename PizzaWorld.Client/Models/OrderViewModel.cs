using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<PizzaViewModel> Pizzas { get; set; }
        public List<Store> Stores { get; set; }
        [Required]
        public string[] PizzaSelection { get; set; }
        [Required]
        public string Store { get; set; }
        public OrderViewModel()
        {
            Pizzas = new List<PizzaViewModel>(){
                new PizzaViewModel("MeatPizza"),
                new PizzaViewModel("VeggiePizza"),
                new PizzaViewModel("HawaiianPizza")
            };
        }
    }
}