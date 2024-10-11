using System.ComponentModel;

public class Movie{

    public string? Name {get; set;}
    public int Year {get; set;}
    public string? Genre {get; set;}

    public Movie(){}

    public Movie(string name, int year, string genre){
        Name = name;
        Year = year;
        Genre = genre;
    }

    public void DisplayMovieDetails(){
        Console.WriteLine($"Name: {Name}, Genre: {Genre}, Release Year: {Year}");
    }
}