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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        // GET: api/Language
        [HttpGet]
        public ActionResult<List<LanguageViewModel>> Get()
        {
            var result = _languageService.GetAllLanguage();
            return Ok(result);
        }

        // GET: api/Language/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<LanguageViewModel> Get(int id)
        {
            var result = _languageService.GetLanguageByID(id);
            return Ok(result);
        }

        // POST: api/Language
        [HttpPost]
        public ActionResult Post([FromBody] LanguageViewModel languageViewModel)
        {
            _languageService.CreateLanguage(languageViewModel);
            return Ok();
        }

        // PUT: api/Language/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] LanguageViewModel languageViewModel)
        {
            _languageService.UpdateLanguage(languageViewModel);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _languageService.DeleteLanguage(id);
            return Ok();
        }
    }
}
