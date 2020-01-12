﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Genre
    {
        public Genre()
        {
            Movies = new Collection<Movie>();
        }
        public int ID { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageID { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public Language Language { get; set; }

    }
}
