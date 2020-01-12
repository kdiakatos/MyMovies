using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IMovieService
    {
        void CreateMovie(MovieViewModel movie);
        void DeleteMovie(int id);
        List<MovieViewModel> GetAllMovies();
        MovieViewModel GetMovieById(int id);
        void UpdateMovie(MovieViewModel movie);
    }
}