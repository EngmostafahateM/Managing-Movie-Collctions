using Managing_Movie_Collctions.DTOs.Movie;
using Managing_Movie_Collctions.Rebo.Movie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Managing_Movie_Collctions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMoveRebo _rebo;

        public MovieController(IMoveRebo rebo )
        {
            _rebo = rebo;
        }

        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            var movise = _rebo.movieGetallDTOs;
            return Ok(movise);
        }

        [HttpGet("GetMovie")]
        public IActionResult GetMovie(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _rebo.movieGetbyid(id);
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult AddMovie(MovieGet movie)
        {
            try
            {
                var movie1 = _rebo.Add(movie);

                if (movie1 == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created();
        }


    }
}
