using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly MoviesContext _context;

        public LanguageRepository(MoviesContext context)
        {
            _context = context;
        }

        public List<Language> GetAllLanguage()
        {
            return _context.Languages.ToList();
        }

        public Language GetLanguageByID(int languageId)
        {
            return _context.Languages.SingleOrDefault(a => a.ID == languageId);
        }

        public void CreateLanguage(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
        }

        public void DeleteLanguage(int id)
        {
            var result = _context.Languages.SingleOrDefault(x => x.ID == id);
            _context.Languages.Remove(result);
            _context.SaveChanges();
        }

        public void UpdateLanguage(Language language)
        {
            var result = _context.Languages.SingleOrDefault(x => x.ID == language.ID);
            if (result != null)
            {
                result.Description = language.Description;
            }
        }

    }
}
