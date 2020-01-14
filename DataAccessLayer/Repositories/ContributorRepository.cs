using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class ContributorRepository : IContributorRepository
    {
        private readonly MoviesContext _context;

        public ContributorRepository(MoviesContext context)
        {
            _context = context;
        }

        public List<Contributor> GetAllContributor()
        {
            return _context.Contributors.ToList();
        }

        public Contributor GetContributorByID(int contributorID)
        {
            return _context.Contributors.SingleOrDefault(x => x.ID == contributorID);

        }

        public void CreateContributor(Contributor contributor)
        {
            _context.Contributors.Add(contributor);
            _context.SaveChanges();
        }

        public void DeleteContributor(int id)
        {
            var result = _context.Contributors.SingleOrDefault(x => x.ID == id);
            _context.Contributors.Remove(result);
            _context.SaveChanges();
        }

        public void UpdateContributor(Contributor contributor)
        {
            var result = _context.ContributorTypes.SingleOrDefault(x => x.ID == contributor.ID);
            if (result != null)
            {
                result.Name = contributor.Name;
                result.Title = contributor.Title;
                result.Description = contributor.Description;
                _context.SaveChanges();
            }
        }
    }
}
