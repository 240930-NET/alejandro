namespace MovieCatalog;

using System.Collections.Generic;
using MovieLogic;

public class MovieCatalog{

    public static void Main(string[] args){

        List<Movie> movies = Data.DeserializeMovieCatalog();

        Menu.Greeting(); 

        Menu.DisplayOptions();

        int selectedOption = Menu.GetInput();

        while (selectedOption != 0){
            switch(selectedOption){
                case 1:
                    MovieLogic.AddMovie(movies);
                    break;
                case 2:
                    MovieLogic.EditMovieCatalog(movies);
                    break;
                case 3:
                    MovieLogic.DeleteMovie(movies);
                    break;
                case 4:
                    MovieLogic.DisplayMovieCatalog(movies);
                    break;
                case 5:
                    MovieLogic.SaveMovieCatalog(movies);
                    break;
                default:
                    Console.WriteLine("Invalid input\n");
                    break;
            }

            Menu.DisplayOptions();

            selectedOption = Menu.GetInput();
        }

        Console.WriteLine("Thank you, see you soon!\n");
    }
}
