using Microsoft.AspNetCore.Mvc;
using MovieCatalog.API.Service;

namespace MovieCatalog.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
  private readonly IMovieService _movieService;

  public MovieController(IMovieService movieService) => _movieService = movieService;

  [HttpGet("/movies")]
  public IActionResult GetAllMovies()
  {
    try{
      var movies = _movieService.GetAllMovies();
      return Ok(movies);
    }
    catch(Exception ex){
      return StatusCode(500, ex.Message);
    }
  }

  [HttpGet("/movie/{id}")]
  public IActionResult GetMovieById(int id)
  {
    try{
      var movieSearched =  _movieService.GetMovieById(id);
      return Ok(movieSearched);
    }
    catch(Exception e){
      return StatusCode(500, e.Message); 
    }
  }
}