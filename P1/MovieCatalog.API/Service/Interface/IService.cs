using MovieCatalog.API.Model;

namespace MovieCatalog.API.Service;

public interface IMovieService{
  public IEnumerable<Movie> GetAllMovies();

  public Movie GetMovieById(int id);

  public string AddMovie(Movie movie);

  public Movie EditMovie(Movie movie);

  public string DeleteMovie(int id);
}