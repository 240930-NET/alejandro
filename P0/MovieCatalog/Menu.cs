public static class Menu{

    public static void Greeting(){

        Console.WriteLine("Hello admin,");
        Console.WriteLine("Select one of the following to manage the movie catalog:\n");
    }

    public static void DisplayOptions(){

        Console.WriteLine("1. Add a new Movie");
        Console.WriteLine("2. Edit a Movie");
        Console.WriteLine("3. Delete a Movie");
        Console.WriteLine("4. Display All");
        Console.WriteLine("5. Save movie catalog");
        Console.WriteLine("0. Leave the app");
    }

    public static int GetInput(){
        Console.WriteLine("Type the option number");

        string? Input = Console.ReadLine();

        try{
            int i = Int32.Parse(Input);
            return i;
        }
        catch(Exception er){
            Console.WriteLine(er.Message);
            return 0;
        }
    }

    public static string GetMovieName(){

        Console.WriteLine("Type the movie name you want to select:");
        string? movieName = Console.ReadLine();
        return movieName ?? "No movie selected";
    }

    public static Movie NewMovie(){

        Console.WriteLine("Movie name:");
        string? movieName = Console.ReadLine();

        Console.WriteLine("Release year:");
        string? releaseYear = Console.ReadLine();

        int movieYear = Int32.Parse(releaseYear ?? "0");

        Console.WriteLine("Movie genre:");
        string? movieGenre = Console.ReadLine();


        return new Movie(movieName, movieYear, movieGenre);
    }
}