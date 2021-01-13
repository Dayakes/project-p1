using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly PizzaWorldRepository _ctx;
        public CustomerController(PizzaWorldRepository context)
        {
            _ctx = context;
        }
        [HttpGet]
        public IActionResult Home()
        {
            var customer = new CustomerViewModel();
            customer.Order = new OrderViewModel(){
                Stores = _ctx.GetStores().ToList()
            };
            return View("home",customer);
        }
    }
}