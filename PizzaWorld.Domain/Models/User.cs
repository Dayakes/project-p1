using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class User : AModel
    {
        /*
        [required] must be able to view/list its order history
        [required] must be able to only order from 1 location in a 24-hour period with no reset
        [required] must be able to only order once every 2-hour period
        */
        public List<Order> Orders { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public Order Workingorder { get; set; }


        public User()
        {
            Orders = new List<Order>();
            Name = "";
        }
        public User(string name)
        {
            Orders = new List<Order>();
            Name = name;
        }
    }
}