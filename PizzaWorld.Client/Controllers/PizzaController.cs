using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }
    }
}