using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IGenreService
    {
        void CreateGenre(GenreViewModel genre);
        void DeleteGenre(int id);
        List<GenreViewModel> GetAllGenre();
        GenreViewModel GetGenreByID(int id);
        void UpdateGenre(GenreViewModel genre);
    }
}