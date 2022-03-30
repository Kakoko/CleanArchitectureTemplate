using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviessController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviessController(IMovieService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie( Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(movie);
        }

    }
}
