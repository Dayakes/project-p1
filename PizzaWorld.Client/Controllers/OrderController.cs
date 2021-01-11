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
        [HttpGet]
        public IActionResult Get()
        { 
            return View("Order");
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return View("Order", new OrderViewModel(id));
        }
        [HttpPost]
        public IActionResult Post(OrderViewModel order)
        {
            if(ModelState.IsValid)
            {
                return View("OrderPass");
            }
            return View("OrderFail");
        }
        // public void Set()
        // {

        // }
        // public void Delete()
        // {

        // }
    }
}