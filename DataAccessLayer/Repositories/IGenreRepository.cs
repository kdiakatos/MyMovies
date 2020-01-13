using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IGenreRepository
    {
        void CreateGenre(Genre genre);
        void DeleteGenre(int id);
        List<Genre> GetAllGenre();
        Genre GetGenreByID(int genreId);
        void UpdateGanre(Genre genre);
    }
}