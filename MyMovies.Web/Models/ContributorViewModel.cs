using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyMovies.Web.Models
{
    public class ContributorViewModel
    {
        public ContributorViewModel()
        {
            Movies = new Collection<MovieViewModel>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public int LanguageID { get; set; }

        public ICollection<MovieViewModel> Movies { get; set; }

        public ContributorTypeViewModel ContributorType { get; set; }

        public LanguageViewModel  Language { get; set; }
    }
}
