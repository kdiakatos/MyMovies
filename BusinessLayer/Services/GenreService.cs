using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public List<GenreViewModel> GetAllGenre()
        {
            var dbRow = _genreRepository.GetAllGenre();
            var result = _mapper.Map<List<GenreViewModel>>(dbRow);
            return result;
        }

        public GenreViewModel GetGenreByID(int id)
        {
            var dbRow = _genreRepository.GetGenreByID(id);
            var result = _mapper.Map<GenreViewModel>(dbRow);
            return result;
        }

        public void CreateGenre(GenreViewModel genre)
        {
            var dbRow = _mapper.Map<Genre>(genre);
            _genreRepository.CreateGenre(dbRow);
        }

        public void DeleteGenre(int id)
        {
            _genreRepository.DeleteGenre(id);
        }

        public void UpdateGenre(GenreViewModel genre)
        {
            var dbRow = _mapper.Map<Genre>(genre);
            _genreRepository.UpdateGanre(dbRow);

        }
    }
}
