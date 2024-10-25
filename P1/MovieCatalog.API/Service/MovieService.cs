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

  public string AddMovie(Movie movie){

    if(movie.Name != null && movie.Year > 0 && movie.Genre != null){
      _movieRepository.AddMovie(movie);
      return $"Movie: ${movie.Name} added successfully!";
    }
    else{
      throw new Exception("Cannot Add Movie to Catalog. Please check name, release year, or genre");
    }
  }

  public Movie EditMovie(Movie movie){

    Movie movieToEdit = _movieRepository.GetMovieById(movie.Id);
    if (movieToEdit != null){
      if(movie.Name != null && movie.Year > 0 && movie.Genre != null){
        movieToEdit.Name = movie.Name;
        movieToEdit.Year = movie.Year;
        movieToEdit.Genre = movie.Genre;

        _movieRepository.EditMovie(movieToEdit);
        return movieToEdit;
      }
      else{
        throw new Exception("Cannot Edit Movie. Please check name, release year, or genre");
      }
    }
    else{
      throw new Exception("No movie was found with that id");
    }
  }

  public string DeleteMovie(int id){

    Movie movieToDelete = _movieRepository.GetMovieById(id);

    if (movieToDelete != null){
      _movieRepository.DeleteMovie(movieToDelete);
      return $"Movie: {movieToDelete.Name} deleted successfully!";
    }
    else{
      throw new Exception("No movie was found with that id");
    }
  }
}