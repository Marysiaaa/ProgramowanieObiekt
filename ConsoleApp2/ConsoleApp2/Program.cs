namespace ConsoleApp2;

internal class Program
{
    public class Transaction
    {
        public double Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(double amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }

    static void Main(string[] args)
    {
        // Tworzenie nowego konta w banku
        var acount = new BankAccount("Maria Oleksinska", 1254);
        acount.ShowBankAccount();
        var account = new BankAccount("Grzegorz Karolewski", 2000000);
        account.ShowBankAccount();
        var account2 = new BankAccount("Jan Kowalski", 100000);
        Console.WriteLine(account2.ShowBankAccount());
        File.WriteAllLines("./asdf.txt", new[] { account2.ShowBankAccount() });
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);
        var transaction = new Transaction(2000, DateTime.Now, "wpłata");
    }
}