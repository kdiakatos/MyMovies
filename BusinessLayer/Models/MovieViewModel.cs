using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageID { get; set; }

        public GenreViewModel Genre { get; set; }
        public ContributorViewModel Contributor { get; set; }

        public LanguageViewModel Language { get; set; }
    }
}
