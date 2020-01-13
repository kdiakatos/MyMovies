using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MoviesContext _context;

        public GenreRepository(MoviesContext context)
        {
            _context = context;
        }

        public List<Genre> GetAllGenre()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenreByID(int genreId)
        {
            return _context.Genres.SingleOrDefault(a => a.ID == genreId);
        }

        public void CreateGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            var result = _context.Genres.SingleOrDefault(x => x.ID == id);
            _context.Genres.Remove(result);
            _context.SaveChanges();
        }

        public void UpdateGanre(Genre genre)
        {
            var result = _context.Genres.SingleOrDefault(x => x.ID == genre.ID);
            if (result != null)
            {
                result.Title = genre.Title;
                result.Name = genre.Name;
                result.Description = genre.Description;
                _context.SaveChanges();

            }
        }
    }
}
