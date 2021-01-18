using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class StoreViewModel
    {
        public Store CurrentStore { get; set; }
        public string Name { get; set; }
        public string StoreId { get; set; }
        public double TotalRevenue { get; set; }
    }
}