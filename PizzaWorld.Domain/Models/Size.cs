using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size : AModel
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Size() 
        {
            Name = "";
            Price = 0;
        }
        public Size(string name)
        {
            Name = name;
            if(Name.Equals("small"))
            {
                Price = 5;
            }
            else if(Name.Equals("medium"))
            {
                Price = 6;
            }
            else if(Name.Equals("large"))
            {
                Price = 7;
            }
        }
    }
}