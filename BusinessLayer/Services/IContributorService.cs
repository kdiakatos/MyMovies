using BusinessLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public interface IContributorService
    {
        void CreateContributor(ContributorViewModel contributor);
        void DeleteContributor(int id);
        List<ContributorViewModel> GetAllContributor();
        ContributorViewModel GetContributorByID(int id);
        void UpdateContributor(ContributorViewModel contributor);
    }
}