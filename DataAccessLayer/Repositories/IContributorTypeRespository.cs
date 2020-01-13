using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IContributorTypeRespository
    {
        void CreateContributorType(ContributorType contributorType);
        void DeleteContributorType(int id);
        List<ContributorType> GetAllContributorType();
        ContributorType GetContributorTypeByID(int contributorTypID);
        void UpdateContributorType(ContributorType contributorType);
    }
}