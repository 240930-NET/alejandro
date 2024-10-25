using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Model;

namespace MovieCatalog.API.Data;

public partial class MovieContext : DbContext
{
  public MovieContext(){}
  public MovieContext(DbContextOptions<MovieContext> options) : base(options){}

  public virtual DbSet<Movie> Movies {get;set;}

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Movie>().HasData(
      new Movie {Id = 1, Name = "Deadpool", Genre = "Action Comedy", Year = 2024},
      new Movie {Id = 2, Name = "Superbad", Genre = "Comedy", Year = 2015}
    );
  }
}