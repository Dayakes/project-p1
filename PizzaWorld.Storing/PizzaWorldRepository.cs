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
        public IEnumerable<T> GetAll<T>() where T : AModel
        {
            return _ctx.Set<T>().ToList();
        }
        public T Get<T>(long id) where T : AModel
        {
            return _ctx.Set<T>().Find(id);
        }
        public void Add<T>(T item) where T : AModel
        {
            _ctx.Set<T>().Add(item);
        }
        public void Remove<T>(T item) where T : AModel
        {
            _ctx.Set<T>().Remove(item);
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