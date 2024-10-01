
static class Menu{

    // Greet User
    public static void Greetings(){
        Console.WriteLine("Hello user, this is a financial application!");
        Console.WriteLine("Select one of the following:");
    }

    // Display options
    public static void DisplayUserOptions(){
        Console.WriteLine("1. Add a new Expense");
        Console.WriteLine("2. Edit an Expense");
        Console.WriteLine("3. Delete an Expense");
        Console.WriteLine("4. Display all");

        Console.WriteLine("9. Leave app");
    }

    // Get user input
    public static int GetUserInput(){
        Console.WriteLine("Type the option number");

        string userInput = Console.ReadLine();

        // Convert user input string to an integer
        return Int32.Parse(userInput);
    }
}