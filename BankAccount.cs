namespace csTryout;

public class BankAccount
{
    public string Number { get; } //can only GET
    public string Owner { get; set; } //can GET and SET

    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    } //can only GET

    private int _accountnumberSeed = 1234567890;

    //List to push all the transactions in
    private List<Transactions> allTransactions = new List<Transactions>();

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        MakeDeposits(initialBalance, DateTime.Now, "Initial Balance  ");
        Number = _accountnumberSeed.ToString();
        _accountnumberSeed++; //incrementing so that next user will get a different value
    }

    //Methods
    public void MakeDeposits(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must be positive");
        }

        var deposit = new Transactions(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawals(decimal amount, DateTime date, string note)
    {
        if (amount < 0)
        { 
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must be Positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }

        var withdrawal = new Transactions(-amount, date, note);
        allTransactions.Add(withdrawal);
    }
}