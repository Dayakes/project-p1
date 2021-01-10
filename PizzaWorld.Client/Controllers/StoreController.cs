using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaWorld.Client.Models;

namespace PizzaWorld.Client.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {   
            var stores = new StoreViewModel();
            stores.Stores = new List<Domain.Models.Store>(){
                new Domain.Models.Store(),
                new Domain.Models.Store(),
                new Domain.Models.Store(),
                new Domain.Models.Store(),
                new Domain.Models.Store()
            };
            

            ViewBag.Stores = stores.Stores;
            return View("Store");
        }
        [HttpGet("{store}")]
        public IActionResult Get(string store)
        {
            return View("Store",store);
        }
        // public void Post()
        // {

        // }
        // public void Put()
        // {

        // }
        // public void Delete()
        // {

        // }
        // [HttpGet]
        // public IEnumerable<OrderViewModel> List()
        // {
        //     return new List<OrderViewModel>()
        //     {
        //         new OrderViewModel()
        //         {
        //             Pizzas = new List<PizzaViewModel>()
        //             {
        //                 new PizzaViewModel{Crust = "regular", Size = "medium", Price = 10}
        //             }
        //         }
        //     };
        // }
    }
}