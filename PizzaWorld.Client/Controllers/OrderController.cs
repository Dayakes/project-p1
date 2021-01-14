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
            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.DateModified = System.DateTime.Now;
                order.store = _ctx.GetStore(model.Store);

                foreach (var pizza in model.PizzaSelection)
                {
                    if (pizza.Equals("Meat Pizza"))
                    {
                        order.Pizzas.Add(new MeatPizza());
                    }
                    else if (pizza.Equals("Veggie Pizza"))
                    {
                        order.Pizzas.Add(new VeggiePizza());
                    }
                    else if (pizza.Equals("Hawaiian Pizza"))
                    {
                        order.Pizzas.Add(new HawaiianPizza());
                    }
                }

                _ctx.AddOrder(order);
                _ctx.Update();

                return View("OrderPass");
            }
            return View("OrderFail", model);
        }
    }
}