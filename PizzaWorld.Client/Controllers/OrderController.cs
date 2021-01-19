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
        [Route("[action]")]
        [HttpPost]
        public IActionResult StartNewOrder(CustomerViewModel customer)
        {
            TempData.Put<string>("SelectedStoreId", customer.SelectedStoreId);
            TempData.Put<string>("CurrentUserId", customer.UserId);
            return View("OrderOverview", customer.Order);
        }
        [Route("[action]")]
        [HttpPost]
        public IActionResult AddPizza(OrderViewModel order)
        {
            if (TempData.Get<List<PizzaViewModel>>("PizzaList") is not null)
            {
                order.WorkingPizzaList = TempData.Get<List<PizzaViewModel>>("PizzaList");
            }

            order.WorkingPizzaList.Add(new PizzaViewModel(order.PizzaName, order.PizzaSize, order.PizzaCrust));

            TempData.Put<List<PizzaViewModel>>("PizzaList", order.WorkingPizzaList);

            return View("OrderOverview", order);

        }
        [Route("[action]")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitOrder(OrderViewModel model)
        {
                model.WorkingPizzaList = TempData.Get<List<PizzaViewModel>>("PizzaList");
                TempData.Remove("PizzaList");

                Order order = new Order();
                order.DateModified = System.DateTime.Now;
                order.StoreEntityId = long.Parse(TempData.Get<string>("SelectedStoreId"));
                order.UserEntityId = long.Parse(TempData.Get<string>("CurrentUserId"));
                
                foreach(var pizza in model.WorkingPizzaList)
                {
                    if(pizza.Name.Equals("MeatPizza"))
                    {
                        order.Pizzas.Add(new MeatPizza(new Size(pizza.Size),new Crust(pizza.Crust)));
                    }
                    else if(pizza.Name.Equals("VeggiePizza"))
                    {
                        order.Pizzas.Add(new VeggiePizza(new Size(pizza.Size),new Crust(pizza.Crust)));
                    }
                    else if(pizza.Name.Equals("HawaiianPizza"))
                    {
                        order.Pizzas.Add(new HawaiianPizza(new Size(pizza.Size),new Crust(pizza.Crust)));
                    }
                }
                
                order.ComputePrice();                

                _ctx.AddOrder(order);
                _ctx.Update();

                return View("OrderPass");
        }
    }
}