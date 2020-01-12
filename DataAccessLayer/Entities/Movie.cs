using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageID { get; set; }

        public Genre Genre { get; set; }
        public Contributor Contributor { get; set; }

        public Language Language { get; set; }

    }
}
