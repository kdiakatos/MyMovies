using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IContributorRepository
    {
        void CreateContributor(Contributor contributor);
        void DeleteContributor(int id);
        List<Contributor> GetAllContributor();
        Contributor GetContributorByID(int contributorID);
        void UpdateContributor(Contributor contributor);
    }
}