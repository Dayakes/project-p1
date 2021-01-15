using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class SizeViewModel
    {
        public SizeViewModel()
        {
            Sizes = new List<Size>(){
                new Size("small"),
                new Size("medium"),
                new Size("large")
            };
        }
        public List<Size> Sizes { get; set; }
        public string Name { get; set; }
    }
}