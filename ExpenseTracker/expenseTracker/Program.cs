﻿
class Program{

    public static void Main(string[] args){

        // Instantiate Menu Class (if not static)
        // Menu expenseTrackerMenu = new Menu();
        // expenseTrackerMenu.Greetings();

        List<Expense> currentExpenses = [];

        currentExpenses.Add(new Expense("Phone Bill", 65.32, 001));
        currentExpenses.Add(new Expense("PS5", 600.87, 002));

        // Greet User
        Menu.Greetings();

        // Display Menu options
        Menu.DisplayUserOptions();

        int selectedOption = Menu.GetUserInput();

        switch(selectedOption){
            case 1:
                Console.WriteLine("You selected to add a new Expense");
                break;
            case 2:
                Console.WriteLine("You selected to edit a new Expense");
                break;
            case 3:
                Console.WriteLine("You selected to delete a new Expense");
                break;
            case 4:
                Console.WriteLine("You selected to display all");
                break;
            case 5:
                Console.WriteLine("Save Expenses");
                break;

            case 9:
                Console.WriteLine("Thank you, see you soon!");
                break;
        }
    }
}