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
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/Movie
        [HttpGet]
        public ActionResult<List<MovieViewModel>> Get()
        {
            var result = _movieService.GetAllMovies();
            return Ok(result);
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<MovieViewModel> Get(int id)
        {
            var result = _movieService.GetMovieById(id);
            return Ok(result);
        }

        // POST: api/Movie
        [HttpPost]
        public ActionResult Post([FromBody] MovieViewModel movieViewModel)
        {
            _movieService.CreateMovie(movieViewModel);
            return Ok();
        }

        // PUT: api/Movie/5
        [HttpPut]
        public ActionResult  Put( [FromBody] MovieViewModel movieViewModel)
        {
            _movieService.UpdateMovie(movieViewModel);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult  Delete(int id)
        {
            _movieService.DeleteMovie(id);
            return Ok();
        }
    }
}
