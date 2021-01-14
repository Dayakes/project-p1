using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class OrderViewModel
    {
        public List<Store> Stores { get; set; }
        // [Required]
        // [Range(1,50)]
        // public List<APizzaModel> PizzaSelection { get; set; }
        [Required]
        public string Store { get; set; }
    }
}