using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class ContributorService : IContributorService
    {
        private readonly IContributorRepository _contributorRepository;
        private readonly IMapper _mapper;

        public ContributorService(IContributorRepository contributorRepository, IMapper mapper)
        {
            _contributorRepository = contributorRepository;
            _mapper = mapper;
        }

        public List<ContributorViewModel> GetAllContributor()
        {
            var dbRow = _contributorRepository.GetAllContributor();
            var result = _mapper.Map<List<ContributorViewModel>>(dbRow);
            return result;
        }
        public ContributorViewModel GetContributorByID(int id)
        {
            var dbRow = _contributorRepository.GetContributorByID(id);
            var result = _mapper.Map<ContributorViewModel>(dbRow);
            return result;
        }

        public void CreateContributor(ContributorViewModel contributor)
        {
            var dbRow = _mapper.Map<Contributor>(contributor);
            _contributorRepository.CreateContributor(dbRow);
        }

        public void DeleteContributor(int id)
        {
            _contributorRepository.DeleteContributor(id);
        }

        public void UpdateContributor(ContributorViewModel contributor)
        {
            var dbRow = _mapper.Map<Contributor>(contributor);
            _contributorRepository.UpdateContributor(dbRow);
        }
    }
}
