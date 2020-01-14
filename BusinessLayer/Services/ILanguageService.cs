using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface ILanguageService
    {
        void CreateLanguage(LanguageViewModel language);
        void DeleteLanguage(int id);
        List<LanguageViewModel> GetAllLanguage();
        LanguageViewModel GetLanguageByID(int id);
        void UpdateLanguage(LanguageViewModel language);
    }
}