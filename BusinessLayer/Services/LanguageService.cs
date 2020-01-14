using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public LanguageService(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public List<LanguageViewModel> GetAllLanguage()
        {
            var dbRow = _languageRepository.GetAllLanguage();
            var result = _mapper.Map<List<LanguageViewModel>>(dbRow);
            return result;
        }

        public LanguageViewModel GetLanguageByID(int id)
        {
            var dbRow = _languageRepository.GetLanguageByID(id);
            var result = _mapper.Map<LanguageViewModel>(dbRow);
            return result;
        }

        public void CreateLanguage(LanguageViewModel language)
        {
            var dbRow = _mapper.Map<Language>(language);
            _languageRepository.CreateLanguage(dbRow);
        }

        public void DeleteLanguage(int id)
        {
            _languageRepository.DeleteLanguage(id);
        }

        public void UpdateLanguage(LanguageViewModel language)
        {
            var dbRow = _mapper.Map<Language>(language);
            _languageRepository.UpdateLanguage(dbRow);

        }
    }
}
