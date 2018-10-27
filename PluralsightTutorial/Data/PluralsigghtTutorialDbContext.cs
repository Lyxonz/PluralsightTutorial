using Microsoft.EntityFrameworkCore;
using PluralsightTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightTutorial.Data
{
    public class PluralsigghtTutorialDbContext : DbContext
    {
        public PluralsigghtTutorialDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurant { get; set; }
    }
}
