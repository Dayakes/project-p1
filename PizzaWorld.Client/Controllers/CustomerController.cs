using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var customer = new CustomerViewModel();
            customer.UserId = long.Parse(LoginModel.CurrentUserId);
            customer.Name = LoginModel.CurrentUserName;

            customer.Order = new OrderViewModel(){
                Stores = _ctx.GetStores().ToList()
            };
            return View("home",customer);
        }
        //new action NewUser()
    }
}