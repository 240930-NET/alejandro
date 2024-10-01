
class GameOptions{

    public void userGameMenu(){
        Console.WriteLine("Please select one of these options:");
        Console.WriteLine("1. Paper");
        Console.WriteLine("2. Scissors");
        Console.WriteLine("3. Rock");
        Console.WriteLine("Press ENTER to exit game...");
    }

    private Random random = new Random();

    public void gameLogic(string userInput){
        
        string[] opponentOptions = {"Paper", "Scissors", "Rock"};

        int opponentSelection = random.Next(opponentOptions.Length);

        if (userInput == "1" && opponentSelection == 0){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[0]}");
            Console.WriteLine("You tied!");
            Console.WriteLine("");
        }
        else if (userInput == "1" && opponentSelection == 1){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[1]}");
            Console.WriteLine("You Lost!");
            Console.WriteLine("");
        }
        else if (userInput == "1" && opponentSelection == 2){
            Console.WriteLine($"Opponent Chose: {opponentOptions[2]}");
            Console.WriteLine("You Won!");
            Console.WriteLine("");
        }
        else if (userInput == "2" && opponentSelection == 0){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[0]}");
            Console.WriteLine("You Won!");
            Console.WriteLine("");
        }
        else if (userInput == "2" && opponentSelection == 1){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[1]}");
            Console.WriteLine("You Tied!");
            Console.WriteLine("");
        }
        else if (userInput == "2" && opponentSelection == 2){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[2]}");
            Console.WriteLine("You Lost!");
            Console.WriteLine("");
        }
        else if (userInput == "3" && opponentSelection == 0){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[0]}");
            Console.WriteLine("You Lost!");
            Console.WriteLine("");
        }
        else if (userInput == "3" && opponentSelection == 1){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[1]}");
            Console.WriteLine("You Won!");
            Console.WriteLine("");
        }
        else if (userInput == "3" && opponentSelection == 2){
            Console.WriteLine($"Opponent Chose:  {opponentOptions[2]}");
            Console.WriteLine("You Tied!");
            Console.WriteLine("");
        }
        else{
            Console.WriteLine("Please select a proper option!");
        }
    }
}