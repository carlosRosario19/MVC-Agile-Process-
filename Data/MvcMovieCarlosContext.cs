using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieCarlos.Models;

namespace MvcMovieCarlos.Data
{
    public class MvcMovieCarlosContext : DbContext
    {
        public MvcMovieCarlosContext (DbContextOptions<MvcMovieCarlosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieCarlos.Models.Movie> Movie { get; set; } = default!;
    }
}
