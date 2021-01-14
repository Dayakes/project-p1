using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldRepository
    {
        private PizzaWorldContext _ctx;

        public PizzaWorldRepository(PizzaWorldContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Store> GetStores()
        {
            return _ctx.Stores;
        }
        public Store GetStore(string id)
        {
            return _ctx.Stores.FirstOrDefault(Store => Store.EntityId == long.Parse(id));
        }
        public void AddOrder(Order order)
        {
            _ctx.Orders.Add(order);
        }
        public void Update()
        {
            _ctx.SaveChanges();
        }
    }
}