using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();

        Console.WriteLine("Welcome to your Journal App!");
        Console.WriteLine("Write everything you did today and goals you want to accomplish!");
        Console.WriteLine();

        int userInput = 0;
        int quit = 5;
        while (userInput != quit)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string user_Input = Console.ReadLine();
            userInput = int.Parse(user_Input);

            if (userInput == 1)
            {
                Console.Write("What you did today? ");
                string text = Console.ReadLine();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("This is the SECOND option");
            }

            else if (userInput == 3)
            {
                Console.WriteLine("This is the THIRD option");
            }

            else if (userInput == 4)
            {
                Console.WriteLine("This is the FOURTH option");
            }

            if (userInput == 5)
            {
                Console.WriteLine("Thanks you for using your Journal app!");
                Console.WriteLine("Come again tommorow!");
                break;
            }
        }

    }


}