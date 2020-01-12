using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BusinessLayer.Models
{
    public class ContributorTypeViewModel
    {
        public ContributorTypeViewModel()
        {
            Contributors = new Collection<ContributorViewModel>();
        }
        public int ID { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageID { get; set; }

        public ICollection<ContributorViewModel> Contributors { get; set; }

        public LanguageViewModel Language { get; set; }
    }
}
