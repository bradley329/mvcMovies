using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvcMovies.Models
{
    public class mvcMoviesContext : DbContext
    {
        public mvcMoviesContext (DbContextOptions<mvcMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<mvcMovies.Models.Movie> Movies { get; set; }
    }
}
