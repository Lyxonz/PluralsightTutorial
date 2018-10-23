using PluralsightTutorial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightTutorial.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(50)]
        public String Name { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
