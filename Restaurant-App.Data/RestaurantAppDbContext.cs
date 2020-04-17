using System;
using Microsoft.EntityFrameworkCore;
using Restaurant_App.Core;

namespace Restaurant_App.Data
{
    public class RestaurantAppDbContext : DbContext
    {
        public RestaurantAppDbContext(DbContextOptions<RestaurantAppDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
