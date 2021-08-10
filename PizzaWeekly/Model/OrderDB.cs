using System;
using Microsoft.EntityFrameworkCore;

namespace PizzaWeekly.Model
{
    public class OrderDB : DbContext
    {
        public OrderDB(DbContextOptions<OrderDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
    }
}
