using MovieCatalog.API.Model;

namespace MovieCatalog.API.Repository;

public interface IMovieRepository{
  IEnumerable<Movie> GetAllMovies();

  public Movie GetMovieById(int id);
}