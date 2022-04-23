using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Restaurant1.Models;

namespace Restaurant1.Repository
{
    public class ResturantContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Negin service\source\repos\Restaurant1\Restaurant1\Restaurant1DB.mdf"";Integrated Security=True");
        }
    }
}
