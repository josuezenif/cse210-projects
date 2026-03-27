public class BankAccount
{
    // private string _ownerName;
    private double _balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else if (amount <= _balance)
        {
            _balance -= amount;
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"You account balance is ${_balance.ToString("F2")}");
        Console.WriteLine();
    }
}