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
    public class ContributorTypeController : ControllerBase
    {
        private readonly IContributorTypeService _contributorTypeService;

        public ContributorTypeController(IContributorTypeService contributorTypeService)
        {
            _contributorTypeService = contributorTypeService;
        }

        // GET: api/ContributorType
        [HttpGet]
        public ActionResult<List<ContributorTypeViewModel>> Get()
        {
            var result = _contributorTypeService.GetAllContributorType();
            return Ok(result);
        }

        // GET: api/ContributorType/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<ContributorTypeViewModel> Get(int id)
        {
            var result = _contributorTypeService.GetContributorTypeByID(id);
            return Ok(result);
        }

        // POST: api/ContributorType
        [HttpPost]
        public ActionResult  Post([FromBody] ContributorTypeViewModel contributorTypeViewModel)
        {
            _contributorTypeService.CreateContributorType(contributorTypeViewModel);
            return Ok();
        }

        // PUT: api/ContributorType/5
        [HttpPut("{id}")]
        public ActionResult  Put([FromBody] ContributorTypeViewModel contributorTypeViewModel)
        {
            _contributorTypeService.UpdateContributorType(contributorTypeViewModel);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _contributorTypeService.DeleteContributorType(id);
            return Ok();
        }
    }
}
