using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class ContributorTypeRespository : IContributorTypeRespository
    {
        private readonly MoviesContext _context;

        public ContributorTypeRespository(MoviesContext context)
        {
            _context = context;
        }

        public List<ContributorType> GetAllContributorType()
        {
            return _context.ContributorTypes.ToList();
        }

        public ContributorType GetContributorTypeByID(int contributorTypID)
        {
            return _context.ContributorTypes.SingleOrDefault(x => x.ID == contributorTypID);

        }

        public void CreateContributorType(ContributorType contributorType)
        {
            _context.ContributorTypes.Add(contributorType);
            _context.SaveChanges();
        }

        public void DeleteContributorType(int id)
        {
            var result = _context.ContributorTypes.SingleOrDefault(x => x.ID == id);
            _context.ContributorTypes.Remove(result);
            _context.SaveChanges();
        }

        public void UpdateContributorType(ContributorType contributorType)
        {
            var result = _context.ContributorTypes.SingleOrDefault(x => x.ID == contributorType.ID);
            if (result != null)
            {
                result.Name = contributorType.Name;
                result.Title = contributorType.Title;
                result.Description = contributorType.Description;
                _context.SaveChanges();
            }
        }
    }
}
