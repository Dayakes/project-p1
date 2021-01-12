using System.Collections.Generic;
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


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(s => s.EntityId);

        builder.Entity<Order>().HasKey(o => o.EntityId);

        builder.Entity<User>().HasKey(u => u.EntityId);

        builder.Entity<APizzaModel>().HasKey(p => p.EntityId);

        
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
        });
    }
}
