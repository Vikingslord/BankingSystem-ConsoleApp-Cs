namespace csTryout;

public class Program
{
    static void Main(string[] args)
    {
        BankAccount kendra = new BankAccount("Kendra", 10000);

        Console.WriteLine($"Account was created for {kendra.Owner} with amount of {kendra.Balance}\n" +
                          $"Account Number: {kendra.Number}");

        kendra.MakeWithdrawals(150, DateTime.Now, "Makeup");
        Console.WriteLine(kendra.Balance);

        kendra.MakeDeposits(3000, DateTime.Now, "Saved up");
        Console.WriteLine(kendra.Balance);
    }
}