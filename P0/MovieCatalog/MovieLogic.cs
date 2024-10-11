using System.Collections.Generic;

namespace MovieLogic;

public static class MovieLogic{

  public static void AddMovie(List<Movie> movieList){
    Movie movieAdded = Menu.NewMovie();
    movieList.Add(movieAdded);
    Console.WriteLine("New Movie Added!\n");
  }

  public static void DisplayMovieCatalog(List<Movie> movieList){

    if(movieList.Count > 0){
      foreach(Movie movie in movieList){
        movie.DisplayMovieDetails();
        }
    }
    else{
      Console.WriteLine("Empty catalog\n");
      return;
    }
    Console.WriteLine("\n");
  }

  public static void EditMovieCatalog(List<Movie> movieList){
    string? movieNameSelected = Menu.GetMovieName();
    var movieSelected = movieList.Find(movie => movie.Name == movieNameSelected);

    if (movieSelected != null){
      Movie updatedMovie = Menu.NewMovie();
      movieSelected.Name = updatedMovie.Name;
      movieSelected.Year = updatedMovie.Year;
      movieSelected.Genre = updatedMovie.Genre;
      Console.WriteLine("Movie was updated successfully\n");
    }
    else{
      Console.WriteLine("Movie was not found in the catalog\n");
    }
  }

  public static void DeleteMovie(List<Movie> movieList){
    string? movieNameSelected = Menu.GetMovieName();
    var movieSelected = movieList.Find(movie => movie.Name == movieNameSelected);

    if(movieSelected != null){
      movieList.Remove(movieSelected);
      Console.WriteLine("Movie was deleted successfully\n");
    }
    else{
      Console.WriteLine("Movie was not found in the catalog\n");
    }
  }

  public static void SaveMovieCatalog(List<Movie> movieList){
    Data.SerializeData(movieList);
  }

}