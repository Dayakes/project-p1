using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust : AModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Crust()
        {
            Name = "";
            Price = 0;
        }
        public Crust(string name)
        {
            Name = name;
            if(Name.Equals("thin"))
            {
                Price = 5;
            }
            else if(Name.Equals("regular"))
            {
                Price = 6;
            }
            else if(Name.Equals("stuffed"))
            {
                Price = 8;
            }
        }
    }
}