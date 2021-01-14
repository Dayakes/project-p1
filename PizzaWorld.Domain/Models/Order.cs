using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order : AModel
    {
        /*
        [required] each order must be able to view/list/edit its collection of pizzas
        [required] each order must be able to compute its pricing                      pizza.cost in a for loop need to have a check in Order to see 
        [required] each order must be limited to a total pricing of no more than $250       if the total would go over $250
        [required] each order must be limited to a collection of pizzas of no more than 50
        */
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
        public Store store { get; set; }
        public List<APizzaModel> Pizzas { get; set; }
        public long StoreEntityId { get; set; }
        public DateTime DateModified { get; set; }
        public double TotalPrice { get; set; }
        // {
        //     get
        //     {
        //         double calc = 0;
        //         foreach (APizzaModel pizza in Pizzas)
        //         {
        //             calc = calc + pizza.Price;
        //         }
        //         return calc;
        //     }
        //     set
        //     {
        //         ComputePrice();
        //     }
        // }
        public Order()
        {
            // Pizzas = new List<APizzaModel>(){
            //     new MeatPizza(),
            //     new VeggiePizza(),
            //     new HawaiianPizza()
            // };
        }
        public Order(List<APizzaModel> pizzas)
        {
            // Pizzas = pizzas;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("::: START OF ORDER :::\n");
            sb.AppendLine("You ordered these pizzas:");
            foreach (var p in Pizzas)
            {
                sb.AppendLine(p.ToString());
            }
            sb.AppendLine($"Total price for this order: {TotalPrice}");
            sb.AppendLine("::: END OF ORDER :::\n");
            return sb.ToString();
        }
        public double ComputePrice()
        {
            double calc = 0;
            foreach (APizzaModel pizza in Pizzas)
            {
                calc = calc + pizza.Price;
            }
            return calc;
        }
    }
}