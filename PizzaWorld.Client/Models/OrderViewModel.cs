using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<APizzaModel> Pizzas { get; set; }
        public List<Store> Stores { get; set; }
        [Required]
        [Range(1,50)]
        public List<APizzaModel> PizzaSelection { get; set; }
        [Required]
        public string Store { get; set; }
        public OrderViewModel()
        {
            //this is where we access the db, placeholder data below

            PizzaSelection = new List<APizzaModel>();
        }
        public OrderViewModel(string id)
        {
            //get the order needed to view by the id using the database
        }
    }
}