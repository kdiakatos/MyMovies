using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesContext _context;

        public MovieRepository(MoviesContext context)
        {
            _context = context;
        }
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int movieId)
        {
            return _context.Movies.SingleOrDefault(m => m.ID == movieId);
        }

        public void CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var result = _context.Movies.SingleOrDefault(a => a.ID == id);
            _context.Movies.Remove(result);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            var result = _context.Movies.SingleOrDefault(a => a.ID == movie.ID);
            if (result != null)
            {
                result.Title = movie.Title;
                result.Name = movie.Name;
                result.Description = movie.Description;
                _context.SaveChanges();

            }

        }
    }
}
