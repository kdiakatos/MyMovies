using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public List<MovieViewModel> GetAllMovies()
        {
            var dbrow = _movieRepository.GetAllMovies();
            var result = _mapper.Map<List<MovieViewModel>>(dbrow);
            return result;
        }

        public MovieViewModel GetMovieById(int id)
        {
            var dbRow = _movieRepository.GetMovieById(id);
            var result = _mapper.Map<MovieViewModel>(dbRow);
            return result;
        }

        public void CreateMovie(MovieViewModel movie)
        {
            var dbRow = _mapper.Map<Movie>(movie);
            _movieRepository.CreateMovie(dbRow);
        }
        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
        }

        public void UpdateMovie(MovieViewModel movie)
        {
            var dbRow = _mapper.Map<Movie>(movie);
            _movieRepository.UpdateMovie(dbRow);
        }
    }
}
