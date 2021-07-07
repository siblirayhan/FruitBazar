using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFrameworkCore;
using FruitBazar.Models;
using Microsoft.EntityFrameworkCore;

namespace FruitBazar.Data
{
    public class FruitBazarDataContext : DbContext
    {
        public FruitBazarDataContext (DbContextOptions<FruitBazarDataContext> options)
            : base(options)
        {
        }

        public DbSet<Fruit> fruits { get; set; }
        public DbSet<GetInTouch> getintouch { get; set; }
        public DbSet<ShoppingCart> shoppingcart { get; set; }
    }
}
