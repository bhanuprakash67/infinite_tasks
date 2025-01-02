using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Code_Challenge_2_que.Models
{
    public class MoviesContext:DbContext
    {
       
            public MovieContext() : base("name=MoviesDB") { }
            public DbSet<Movie> Movies { get; set; }

       

    }
}