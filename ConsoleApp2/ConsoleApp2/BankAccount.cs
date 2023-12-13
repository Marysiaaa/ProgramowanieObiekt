namespace ConsoleApp2;

internal class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    private readonly List<Program.Transaction> _transactions = new List<Program.Transaction>();
    private double _balance;

    public BankAccount(string name, double initialBalance)
    {
        Owner = name;
        Number = s_accountNumberSeed.ToString();
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }

    public BankAccount(string number, string owner, double balance, List<Program.Transaction> transactions)
    {
        Number = number;
        Owner = owner;
        Balance = balance;
        _transactions = transactions;
    }

    public string Number { get; }

    public string Owner { get; }

    public double Balance
    {
        get
        {
            _balance = 0;
            foreach (var item in _transactions)
            {
                _balance += item.Amount;
            }

            return _balance;
        }
        private set => _balance = value;
    }

    public void MakeDeposit(double amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(nameof(amount), "Kwota depozytu musi być dodatnia\r\n");
        }

        var deposit = new Program.Transaction(amount, date, note);
        _transactions.Add(deposit);
    }

    public void MakeWithdrawal(double amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(nameof(amount), "Kwota depozytu musi być dodatnia\r\n");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }

        var withdrawal = new Program.Transaction(-amount, date, note);
        _transactions.Add(withdrawal);
    }

    public string ShowBankAccount()
    {
        return $"Numer konta: {Number}, Imię właściciela: {Owner}, Bilans: {Balance}";
    }
}