using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IMovieRepository
    {
        void CreateMovie(Movie movie);
        void DeleteMovie(int id);
        List<Movie> GetAllMovies();
        Movie GetMovieById(int movieId);
        void UpdateMovie(Movie movie);
    }
}