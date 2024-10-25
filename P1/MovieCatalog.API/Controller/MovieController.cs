using Microsoft.AspNetCore.Mvc;
using MovieCatalog.API.Service;
using MovieCatalog.API.Model;
using Microsoft.EntityFrameworkCore;

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
    catch(Exception e){
      return StatusCode(500, e.Message);
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

  [HttpPost("new")]
  public IActionResult AddNewMovie([FromBody] Movie movie){

    try{
      _movieService.AddMovie(movie);
      return Ok(movie);
    }
    catch (DbUpdateException dbEx)
    {
      // Log the inner exception for more details
      return BadRequest($"Could not add movie to catalog: {dbEx.InnerException?.Message}");
    }
    catch(Exception e){
      return BadRequest($"Could not add movie to catalog: {e.Message}");
    }
  }

  [HttpPut("edit")]
  public IActionResult EditMovie(Movie movie){

    try{
      _movieService.EditMovie(movie);
      return Ok(movie);
    }
    catch(Exception e){
      return BadRequest($"Could not edit movie: {e.Message}");
    }
  }

  [HttpDelete("delete/{id}")]
  public IActionResult DeleteMovie(int id){

    try{
      _movieService.DeleteMovie(id);
      return Ok("Movie Deleted from catalog");
    }
    catch(Exception e){
      return BadRequest($"Could not remove movie: {e.Message}");
    }
  }
}