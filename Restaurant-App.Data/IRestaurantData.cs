using Restaurant_App.Core;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Restaurant_App.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Shola's Restaurant",
                    Location="Kaduna",
                    Cuisine = CuisineType.Hausa
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Ife's Restaurant",
                    Location="Lagos",
                    Cuisine = CuisineType.Yoruba
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Titi's Restaurant",
                    Location="Abuja",
                    Cuisine = CuisineType.Igbo
                }

            };
        }
        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
