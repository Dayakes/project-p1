using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Domain.Models;
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
        public IActionResult Login()
        {
            var LoginModel = new LoginViewModel();
            LoginModel.AllUsers = _ctx.GetUsers().ToList(); 

            return View("PickUser",LoginModel);
        }
        public IActionResult Welcome(LoginViewModel LoginModel)
        {
            _ctx.CurrentUser = new User();
            _ctx.CurrentUser = _ctx.GetUser(long.Parse(LoginModel.CurrentUserId));

            var customer = new CustomerViewModel();
            customer.UserId = _ctx.CurrentUser.EntityId;
            customer.Name = _ctx.CurrentUser.Name;
            
            customer.Order = new OrderViewModel(){
                Stores = _ctx.GetStores().ToList()
            };
            return View("home",customer);
        }
        //new action NewUser()
    }
}