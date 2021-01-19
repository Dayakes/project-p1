using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{
    public class PizzaWorldRepository
    {
        private PizzaWorldContext _ctx;
        private int MyProperty { get; set; }
        public User CurrentUser { get; set; }

        public PizzaWorldRepository(PizzaWorldContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Store> GetStores()
        {
            return _ctx.Stores;
        }
        public IEnumerable<User> GetUsers()
        {
            return _ctx.Users;
        }
        public User GetUser(long id)
        {
            return _ctx.Users.Include(user => user.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Crust).
            Include(user => user.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Size).
            Include(user => user.Orders).ThenInclude(Order => Order.Pizzas).ThenInclude(pizza => pizza.Toppings).
            FirstOrDefault(user => user.EntityId == id);
        }
        public Store GetStore(string id)
        {
            return _ctx.Stores.Include(store => store.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Crust).
            Include(store => store.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Size).
            Include(store => store.Orders).ThenInclude(Order => Order.Pizzas).ThenInclude(pizza => pizza.Toppings).
            FirstOrDefault(Store => Store.EntityId == long.Parse(id));
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