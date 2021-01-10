using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        [HttpGet("{storeid}")]
        public IActionResult Get()
        { //get all orders for one store
            var Order = new List<APizzaModel>();
            Order.Add(new MeatPizza());
            Order.Add(new VeggiePizza());
            Order.Add(new HawaiianPizza());

            ViewBag.Order = Order;
            return View("Order");
        }
        [HttpGet("{storeid},{orderid}")]
        public IActionResult Get(string StoreId, string OrderId)
        {
            //get all the information for one order
            return View();
        }
        public void Post()
        {

        }
        public void Set()
        {

        }
        public void Delete()
        {

        }
    }
}