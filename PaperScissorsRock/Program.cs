namespace PaperScissorsRock;
class Program{
    static void Main(string[] args)
    {
        GameOptions userMenu = new GameOptions();
        userMenu.userGameMenu();

        string userInput = Console.ReadLine();

        while (!string.IsNullOrWhiteSpace(userInput)){
            userMenu.gameLogic(userInput);

            userMenu.userGameMenu();
            userInput = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}

