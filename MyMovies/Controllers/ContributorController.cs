using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Models;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContributorController : ControllerBase
    {
        private readonly IContributorService _contributorService;
        public ContributorController(IContributorService contributorService)
        {
            _contributorService = contributorService;
        }


        // GET: api/Contributor
        [HttpGet]
        public ActionResult<List<ContributorViewModel>> Get()
        {
            var result = _contributorService.GetAllContributor();
            return Ok(result);
        }

        // GET: api/Contributor/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<ContributorViewModel> Get(int id)
        {
            var result = _contributorService.GetContributorByID(id);
            return Ok(result);
        }

        // POST: api/Contributor
        [HttpPost]
        public ActionResult Post([FromBody] ContributorViewModel contributorViewModel)
        {
            _contributorService.CreateContributor(contributorViewModel);
            return Ok();
        }

        // PUT: api/Contributor/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] ContributorViewModel contributorViewModel )
        {
            _contributorService.UpdateContributor(contributorViewModel);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _contributorService.DeleteContributor(id);
            return Ok();
        }
    }
}
