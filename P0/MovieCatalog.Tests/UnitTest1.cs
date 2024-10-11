namespace MovieCatalog.Tests;

using Xunit;
using MovieLogic;
using System.Collections.Generic;
using System.Drawing;

public class UnitTest1
{
    [Fact]
    public void TestAddMovie(){
        // Arrange
        List<Movie> movieList = [];
        Movie newMovie = new Movie("Deadpool", 2024, "Action Comedy");

        // Act
        movieList.Add(newMovie);

        // Assert
        Assert.Contains(newMovie, movieList);
    }

    [Fact]
        public void TestDeleteMovie() {
        // Arrange
        var movieList = new List<Movie> {
        new Movie { Name = "Inception", Year = 2010, Genre = "Sci-Fi" },
        new Movie { Name = "The Matrix", Year = 1999, Genre = "Action" }
        };

        // Act
        var movieSelected = movieList.Find(movie => movie.Name == "Inception");
        movieList.Remove(movieSelected);

        // Assert
        Assert.False(movieList.Exists(movie => movie.Name == "Inception"));
    }

}