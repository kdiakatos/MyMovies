using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class ContributorTypeService : IContributorTypeService
    {
        private readonly IContributorTypeRespository _contributorTypeRepository;
        private readonly IMapper _mapper;

        public ContributorTypeService(IContributorTypeRespository contributorTypeRepository, IMapper mapper)
        {
            _contributorTypeRepository = contributorTypeRepository;
            _mapper = mapper;
        }

        public List<ContributorTypeViewModel> GetAllContributorType()
        {
            var dbRow = _contributorTypeRepository.GetAllContributorType();
            var result = _mapper.Map<List<ContributorTypeViewModel>>(dbRow);
            return result;
        }

        public ContributorTypeViewModel GetContributorTypeByID(int id)
        {
            var dbRow = _contributorTypeRepository.GetContributorTypeByID(id);
            var result = _mapper.Map<ContributorTypeViewModel>(dbRow);
            return result;
        }

        public void CreateContributorType(ContributorTypeViewModel contributorType)
        {
            var dbRow = _mapper.Map<ContributorType>(contributorType);
            _contributorTypeRepository.CreateContributorType(dbRow);
        }

        public void DeleteContributorType(int id)
        {
            _contributorTypeRepository.DeleteContributorType(id);
        }

        public void UpdateContributorType(ContributorTypeViewModel contributorType)
        {
            var dbRow = _mapper.Map<ContributorType>(contributorType);
            _contributorTypeRepository.UpdateContributorType(dbRow);
        }
    }
}
