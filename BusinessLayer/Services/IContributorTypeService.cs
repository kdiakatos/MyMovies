using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IContributorTypeService
    {
        void CreateContributorType(ContributorTypeViewModel contributorType);
        void DeleteContributorType(int id);
        List<ContributorTypeViewModel> GetAllContributorType();
        ContributorTypeViewModel GetContributorTypeByID(int id);
        void UpdateContributorType(ContributorTypeViewModel contributorType);
    }
}