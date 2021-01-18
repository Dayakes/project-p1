using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class SizeViewModel
    {
        public string PizzaName { get; set; }
        public List<Size> Sizes { get; set; }
        public SizeViewModel()
        {
            Sizes = new List<Size>(){
                new Size("small"),
                new Size("medium"),
                new Size("large")
            };
        }
    }
}