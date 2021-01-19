using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly PizzaWorldRepository _ctx;
        public StoreController(PizzaWorldRepository context)
        {
            _ctx = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            TempData.Clear();
            var StoreLoginModel = new StoreLoginViewModel();
            StoreLoginModel.AllStores = _ctx.GetStores().ToList();

            return View("PickStore", StoreLoginModel);
        }
        public IActionResult Welcome(StoreLoginViewModel LoginModel)
        {
            var StoreModel = new StoreViewModel();
            StoreModel.CurrentStore =  _ctx.GetStore(LoginModel.CurrentStoreId);
            StoreModel.Name = StoreModel.CurrentStore.Name;
            StoreModel.StoreId = StoreModel.CurrentStore.EntityId.ToString();
            foreach(var order in StoreModel.CurrentStore.Orders)
            {
                StoreModel.TotalRevenue += order.TotalPrice;
            }

            return View("Home" , StoreModel);
        }
    }
}

