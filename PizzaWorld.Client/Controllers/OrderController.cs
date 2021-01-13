using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly PizzaWorldRepository _ctx;
        public OrderController(PizzaWorldRepository context)
        {
            _ctx = context;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(OrderViewModel model)
        {
            if(ModelState.IsValid)
            {
                var order = new Order()
                {
                    DateModified = System.DateTime.Now,
                    StoreEntityId = _ctx.GetStores().FirstOrDefault(s => s.Name == model.Store).EntityId
                };

                _ctx.AddOrder(order);
                _ctx.Update();

                return View("OrderPass");
            }
            return View("OrderFail");
        }
    }
}