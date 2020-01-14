using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface ILanguageRepository
    {
        void CreateLanguage(Language language);
        void DeleteLanguage(int id);
        List<Language> GetAllLanguage();
        Language GetLanguageByID(int languageId);
        void UpdateLanguage(Language language);
    }
}