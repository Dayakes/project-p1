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
                order.store = _ctx.Get<Store>(long.Parse(model.Store));
                var i = 0;
                foreach (var pizza in model.Pizzas)
                {
                    if (pizza.Equals("Meat Pizza"))
                    {
                        order.Pizzas.Add(new MeatPizza(pizza.Size.Sizes[i],pizza.Crust.Crusts[i]));
                    }
                    else if (pizza.Equals("Veggie Pizza"))
                    {
                        order.Pizzas.Add(new VeggiePizza(new Size(pizza.Size.ToString()), new Crust(pizza.Crust.ToString())));
                    }
                    else if (pizza.Equals("Hawaiian Pizza"))
                    {
                        order.Pizzas.Add(new HawaiianPizza(new Size(pizza.Size.ToString()), new Crust(pizza.Crust.ToString())));
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