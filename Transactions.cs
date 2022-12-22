namespace csTryout;

public class Transactions
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transactions(decimal _amount, DateTime _date, string _notes)
    {
        Amount = _amount;
        Date = _date;
        Notes = _notes;
    }
}