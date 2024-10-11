using System.Text.Json;

public static class Data{

  public static async Task SerializeData(List<Movie> movies){

    string movieCatalog = JsonSerializer.Serialize(movies);

    try{
      using(StreamWriter writer = File.CreateText("MovieCatalog.txt")){
        await writer.WriteAsync(movieCatalog);
      }
    }
    catch(Exception ex){
      Console.WriteLine($"Error saving movie catalog: {ex.Message}");
    }
  }

  public static List<Movie> DeserializeMovieCatalog(){
    try{
      using(StreamReader reader = File.OpenText("MovieCatalog.txt")){
        string jsonString = reader.ReadToEnd();
        return JsonSerializer.Deserialize<List<Movie>>(jsonString);
      }
    }
    catch(Exception ex){
      Console.WriteLine($"Could not load movie catalog: {ex.Message}");
      return new List<Movie>();
    }
  }
}