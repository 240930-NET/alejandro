using MovieCatalog.API.Service;
using MovieCatalog.API.Data;
using MovieCatalog.API.Model;
using MovieCatalog.API.Repository;
using Moq;

namespace MovieCatalog.Tests;

public class MovieCatalogTests{

    [Fact]
    public async Task GetAllMoviesThrowExceptionOnEmpty(){

        //Arrange
        Mock<IMovieRepository> mockRepo = new();
        MovieService movieService = new(mockRepo.Object);

        List<Movie> emptyCatalog = [];

        mockRepo.Setup(repo => repo.GetAllMovies())
            .Returns(emptyCatalog);

        //Act
        var result = movieService.GetAllMovies();

        //Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task GetAllMovies(){

        //Arrange
        Mock<IMovieRepository> mockRepo = new();
        MovieService movieService = new(mockRepo.Object);

        List<Movie> movieCatalog = [
            new Movie {Name = "Batman", Year = 2022, Genre = "Action"},
            new Movie {Name = "Pulp Fiction", Year = 2005, Genre = "Action"}
        ];

        mockRepo.Setup(repo => repo.GetAllMovies())
            .Returns(movieCatalog);

        //Act
        var result = movieService.GetAllMovies();

        //Assert
        Assert.NotNull(result);
        Assert.Contains(result, e => e.Name!.Equals("Batman"));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task GetMovieById(int id){

        //Arrange
        Mock<IMovieRepository> mockRepo = new();
        MovieService movieService = new(mockRepo.Object);

        List<Movie> movieCatalog = [
            new Movie {Id = 1, Name = "Batman", Year = 2022, Genre = "Action"},
            new Movie {Id = 2, Name = "Pulp Fiction", Year = 2005, Genre = "Action"}
        ];

        mockRepo.Setup(repo => repo.GetMovieById(It.IsAny<int>()))!
            .Returns(movieCatalog.FirstOrDefault(movie => movie.Id == id));

        //Act
        var result = movieService.GetMovieById(id);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<Movie>(result);
        Assert.Equal(id, result.Id);
    }

    [Fact]
    public async Task AddNewMovieToCatalog(){

        //Arrange
        Mock<IMovieRepository> mockRepo = new();
        MovieService movieService = new(mockRepo.Object);

        List<Movie> movieCatalog = [
            new Movie {Id = 1, Name = "Batman", Year = 2022, Genre = "Action"},
            new Movie {Id = 2, Name = "Pulp Fiction", Year = 2005, Genre = "Action"}
        ];

        Movie newMovie = new(){Id = 3, Name = "Star Wars", Year = 2001, Genre = "Action"};

        mockRepo.Setup(repo => repo.AddMovie(It.IsAny<Movie>()))
            .Callback(() => movieCatalog.Add(newMovie));

        //Act
        var result = movieService.AddMovie(newMovie);

        //Assert
        Assert.NotNull(result);
        Assert.Contains(movieCatalog, movie => movie.Name!.Equals("Star Wars"));
        mockRepo.Verify(r => r.AddMovie(It.IsAny<Movie>()), Times.Exactly(1));
    }

    [Fact]
    public void DeleteMovieFromCatalog() {
        // Arrange
        var mockRepo = new Mock<IMovieRepository>();
        var movieService = new MovieService(mockRepo.Object);

        var movieToDelete = new Movie { Id = 1, Name = "Star Wars", Year = 1977, Genre = "Sci-Fi" };

        mockRepo.Setup(repo => repo.GetMovieById(movieToDelete.Id))
            .Returns(movieToDelete);
        
        // Act
        var result = movieService.DeleteMovie(movieToDelete.Id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"Movie: {movieToDelete.Name} deleted successfully!", result);
        mockRepo.Verify(r => r.DeleteMovie(movieToDelete), Times.Once);
    }

    [Fact]
    public void EditMovieSuccessfully(){
        
        //Arrange
        Mock<IMovieRepository> mockRepo = new();
        MovieService movieService = new(mockRepo.Object);

        var existingMovie = new Movie { Id = 1, Name = "Star Wars", Year = 1977, Genre = "Sci-Fi" };
        var updatedMovie = new Movie { Id = 1, Name = "Star Wars: A New Hope", Year = 1977, Genre = "Sci-Fi" };

        mockRepo.Setup(repo => repo.GetMovieById(existingMovie.Id))
            .Returns(existingMovie);

        //Act
        var result = movieService.EditMovie(updatedMovie);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(updatedMovie.Name, result.Name);
        Assert.Equal(updatedMovie.Year, result.Year);
        Assert.Equal(updatedMovie.Genre, result.Genre);
        mockRepo.Verify(r => r.EditMovie(It.IsAny<Movie>()), Times.Once);
    }
}
