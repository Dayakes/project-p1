using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

public class PizzaWorldContext : DbContext
{
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<APizzaModel> Pizzas { get; set; }
    public PizzaWorldContext(DbContextOptions<PizzaWorldContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(store => store.EntityId);
        builder.Entity<Store>().HasMany(store => store.Orders).WithOne(order => order.store);

        builder.Entity<Order>().HasKey(order => order.EntityId);

        builder.Entity<User>().HasKey(u => u.EntityId);

        builder.Entity<APizzaModel>().HasKey(pizza => pizza.EntityId);
        builder.Entity<APizzaModel>().OwnsOne(pizza => pizza.Crust);
        builder.Entity<APizzaModel>().OwnsOne(pizza => pizza.Size);
        builder.Entity<APizzaModel>().HasMany(pizza => pizza.Toppings);

        builder.Entity<Topping>().HasKey(topping => topping.EntityId);


        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        builder.Entity<Store>().HasData(new List<Store>
            {
                new Store(){Name = "Dominos",EntityId = System.DateTime.Now.Ticks},
                new Store(){Name = "Pizza Hut",EntityId = System.DateTime.Now.Ticks}
            }
        );
        builder.Entity<User>().HasData(new List<User>
        {
            new User(){Name = "Darren",EntityId = System.DateTime.Now.Ticks},
            new User(){Name = "Fred",EntityId = System.DateTime.Now.Ticks},
            new User(){Name = "Isaiah",EntityId = System.DateTime.Now.Ticks}
        });
    }
}
