using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        string userNumber = "9";
        string quit = "4";

        BankAccount account = new BankAccount();

        while (userNumber != quit)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display balance");
            Console.WriteLine("4. Quit");

            Console.WriteLine();

            Console.Write("What would you like to do? ");
            string userOption = Console.ReadLine();
            Console.WriteLine();


            if (userOption == "1")
            {
                Console.Write("How much is the amount you want to deposit? ");
                string answer = Console.ReadLine();
                double amount = double.Parse(answer);

                account.Deposit(amount);
                Console.WriteLine($"${amount} has been deposited!");
                Console.WriteLine();
            }

            else if (userOption == "2")
            {
                Console.Write("Amount to withdraw? ");
                string answer = Console.ReadLine();
                double amount = double.Parse(answer);

                account.Withdraw(amount);
                Console.Write($"${amount} have been succesfully withdrawn");
                Console.WriteLine();
            }

            else if (userOption == "3")
            {
                account.DisplayBalance();
            }

            else if (userOption == "4")
            {
                break;
            }
        }
    }
}