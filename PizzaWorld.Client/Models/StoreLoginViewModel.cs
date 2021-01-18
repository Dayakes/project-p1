using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class StoreLoginViewModel
    {
        public string CurrentStoreName { get; set; }
        public string CurrentStoreId { get; set; }
        public List<Store> AllStores { get; set; }
    }
}