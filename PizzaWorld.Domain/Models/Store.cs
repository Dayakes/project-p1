using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Store : AModel
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Store()
        {
            Name = "default";
            Orders = new List<Order>();
        }
        public void CreateOrder(List<APizzaModel> Pizzas)
        {
            Orders.Add(new Order(Pizzas));
            
        }
        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}