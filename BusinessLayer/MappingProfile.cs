using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieViewModel>().ReverseMap();
            CreateMap<Contributor, ContributorViewModel>().ReverseMap();
            CreateMap<ContributorType, ContributorTypeViewModel>().ReverseMap();
            CreateMap<Genre, GenreViewModel>().ReverseMap();
            CreateMap<Language, LanguageViewModel>().ReverseMap();

        }
    }
}
