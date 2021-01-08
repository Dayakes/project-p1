using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;

namespace PizzaWorld.Client.Controllers{
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        [HttpGet]
        public IEnumerable<PizzaViewModel> List()
        {
            return new List<Pizza>()
            {
                new PizzaViewModel() { Crust = "regular", Size = "medium", Price = 10}
            };
        }
    }
}