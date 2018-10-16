using PluralsightTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightTutorial.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1,Name = "Scott Pizza" },
                new Restaurant { Id = 2,Name = "Pizza Hat" },
                new Restaurant { Id = 3,Name = "Domino" }
            };

        }

        List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
