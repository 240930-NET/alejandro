using MovieCatalog.API.Model;

namespace MovieCatalog.API.Service;

public interface IMovieService{
  public IEnumerable<Movie> GetAllMovies();

  public Movie GetMovieById(int id);
}