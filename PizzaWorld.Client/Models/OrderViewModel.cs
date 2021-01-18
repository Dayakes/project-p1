using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public string PizzaName { get; set; }
        public string PizzaSize { get; set; }
        public string PizzaCrust { get; set; }
        public List<PizzaViewModel> AllPizzas { get; set; }
        public List<Store> Stores { get; set; }
        public PizzaViewModel WorkingPizza { get; set; }
        public List<PizzaViewModel> WorkingPizzaList { get; set; }
        [Required]
        public string Store { get; set; }
        public OrderViewModel()
        {
            AllPizzas = new List<PizzaViewModel>(){
                new PizzaViewModel("MeatPizza"),
                new PizzaViewModel("VeggiePizza"),
                new PizzaViewModel("HawaiianPizza")
            };
            WorkingPizzaList = new List<PizzaViewModel>();
            WorkingPizza = new PizzaViewModel();
        }
    }
}