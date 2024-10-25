using MovieCatalog.API.Model;

namespace MovieCatalog.API.Repository;

public interface IMovieRepository{
  public IEnumerable<Movie> GetAllMovies();

  public Movie GetMovieById(int id);

  public void AddMovie(Movie movie);

  public void EditMovie(Movie movie);

  public void DeleteMovie(Movie movie);
}