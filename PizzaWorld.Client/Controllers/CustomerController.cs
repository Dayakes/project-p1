using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client.Controllers
{
    [Route("")]
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
            TempData.Clear();
            var LoginModel = new LoginViewModel();
            LoginModel.AllUsers = _ctx.GetUsers().ToList(); 

            return View("PickUser",LoginModel);
        }
        public IActionResult Welcome(LoginViewModel LoginModel)
        {
            User CurrentUser = _ctx.GetUser(long.Parse(LoginModel.CurrentUserId));

            var customer = new CustomerViewModel();
            customer.UserId = CurrentUser.EntityId.ToString();
            customer.Name = CurrentUser.Name;
            
            customer.CurrentUser = CurrentUser;

            TempData.Put<CustomerViewModel>("CurrentCustomer" , customer);

            ViewBag.CustomerName = CurrentUser.Name;

            customer.Order = new OrderViewModel(){
                Stores = _ctx.GetStores().ToList()
            };

            return View("home",customer);
        }
        
    }
}