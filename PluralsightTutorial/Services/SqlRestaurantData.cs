using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PluralsightTutorial.Data;
using PluralsightTutorial.Models;

namespace PluralsightTutorial.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private PluralsigghtTutorialDbContext _context;

        public SqlRestaurantData(PluralsigghtTutorialDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurant.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurant.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurant.OrderBy(r => r.Name);
        }
    }
}
