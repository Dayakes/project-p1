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
        public string Store { get; set; }
        public OrderViewModel()
        {
            //this is where we access the db, placeholder data below
            Pizzas = new List<APizzaModel>(){
                new MeatPizza(),
                new VeggiePizza(),
                new HawaiianPizza()
            };
            Stores = new List<Store>(){
                new Store(),
                new Store(),
                new Store()
            };
            PizzaSelection = new List<APizzaModel>(){
                new MeatPizza(),
                new MeatPizza(),
                new MeatPizza()
            };
        }
        public OrderViewModel(string id)
        {
            //get the order needed to view by the id using the database
        }
    }
}