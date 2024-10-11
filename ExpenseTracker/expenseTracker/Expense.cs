
class Expense{
    public string Name { get; set; }
    public double Amount { get; set; }
    public int Id { get; set; }

    public Expense(string name, double amount, int id){
        Name = name;
        Amount = amount;
        Id = id;
    }

    public void PrintExpenseDetails(){
        Console.WriteLine($"Name: {Name}, Amount: {Amount}, Id: {Id}\n");
    }
}