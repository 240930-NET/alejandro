using MovieCatalog.API.Model;
using MovieCatalog.API.Repository;

namespace MovieCatalog.API.Service;

public class MovieService : IMovieService{
  private readonly IMovieRepository _movieRepository;

  public MovieService(IMovieRepository movieRepository) => _movieRepository = movieRepository;

  public IEnumerable<Movie> GetAllMovies(){

    IEnumerable<Movie> result = _movieRepository.GetAllMovies();
    if (!result.Any()){
      return null;
    }
    else{
      return result;
    }
  }

  public Movie GetMovieById(int id){

    Movie movie = _movieRepository.GetMovieById(id);
    if (movie != null){
      return movie;
    }
    else{
      return null;
    }
  }
}