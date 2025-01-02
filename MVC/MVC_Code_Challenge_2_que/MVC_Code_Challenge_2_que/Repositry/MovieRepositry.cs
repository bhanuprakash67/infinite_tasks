using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Code_Challenge_2_que.Repositry
{
    public class MovieRepositry
    {
        private readonly MovieContext _context;

        public MovieName(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movies> GetAll() => _context.Movie.ToList();

        public Movies GetById(int id) => _context.Movie.Find(id);

        public void Insert(Movies m) => _context.Movie.Add(m);

        public void Update(Movies m)
        {
            _context.Entry(movies).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
}