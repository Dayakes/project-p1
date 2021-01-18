using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class PizzaViewModel
    {
        public string Name { get; set; }
        public List<CrustViewModel> AllCrusts = new List<CrustViewModel>(){
            new CrustViewModel("thin"),
            new CrustViewModel("regular"),
            new CrustViewModel("stuffed")
        };
        public List<SizeViewModel> AllSizes = new List<SizeViewModel>(){
            new SizeViewModel("small"),
            new SizeViewModel("medium"),
            new SizeViewModel("large")
        };


        public string Crust { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public PizzaViewModel()
        {

        }
        public PizzaViewModel(string name)
        {
            Name = name;
        }
        public PizzaViewModel(string name, string size, string crust)
        {
            Name = name;
            Size = size;
            Crust = crust;
            if (size.Equals("small"))
            {
                Price = "5";
            }
            else if (size.Equals("medium"))
            {
                Price = "7";
            }
            else if (size.Equals("large"))
            {
                Price = "9";
            }
        }
    }
}