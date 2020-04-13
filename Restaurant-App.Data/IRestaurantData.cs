using Restaurant_App.Core;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Restaurant_App.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
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
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
