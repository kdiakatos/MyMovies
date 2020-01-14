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
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/Genre
        [HttpGet]
        public ActionResult<List<GenreViewModel>> Get()
        {
            var result = _genreService.GetAllGenre();
            return Ok(result);
        }

        // GET: api/Genre/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<GenreViewModel> Get(int id)
        {
            var result = _genreService.GetGenreByID(id);
            return Ok(result);
        }

        // POST: api/Genre
        [HttpPost]
        public ActionResult Post([FromBody] GenreViewModel genreViewModel)
        {
            _genreService.CreateGenre(genreViewModel);
            return Ok();
        }

        // PUT: api/Genre/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] GenreViewModel genreViewModel)
        {
            _genreService.UpdateGenre(genreViewModel);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _genreService.DeleteGenre(id);
            return Ok();
        }
    }
}
