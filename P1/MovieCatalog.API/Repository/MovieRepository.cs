using MovieCatalog.API.Data;
using MovieCatalog.API.Model;

namespace MovieCatalog.API.Repository;

public class MovieRepository : IMovieRepository
{
  private readonly MovieContext _movieContext;

  public MovieRepository(MovieContext movieContext) => _movieContext = movieContext;

  public IEnumerable<Movie> GetAllMovies()
  {
    return _movieContext.Movies.ToList();
  }

  public Movie GetMovieById(int id){
    return _movieContext.Movies.Find(id);
  }
}