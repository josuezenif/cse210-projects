// I added a little else if at the end for the quit option, I added a goodbye message (lines 72-76)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();


        Console.Clear();

        Console.WriteLine("Welcome to the Mindful Activities Game!");
        Console.WriteLine("Choose and activity from the list below to relax and wind down!");
        Console.WriteLine();

        int userOption = 0;
        int quit = 4;

        while (userOption != quit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Which activity would you like to do? ");
            string op = Console.ReadLine();
            userOption = int.Parse(op);

            Console.WriteLine();     // >--------breathing activity----------<
            if (userOption == 1)
            {
                Console.WriteLine();
                Console.Write("For how long (in seconds) do you wish to do this activity? ");
                string g = Console.ReadLine();
                int userTime = int.Parse(g);

                Console.Clear();

                Breathing breathingAct = new Breathing("Breathing", "This activity will help you relax and calm down by breathing in and out slowly. Forget everything else and focus on your breathing!", userTime);
                breathingAct.Run();
            }

            else if (userOption == 2)
            {
                // <-------REFLECTION ACTIVITY-------->
                Console.WriteLine();
                Console.Write("For how long (in seconds) do you wish to do this activity? ");
                string g = Console.ReadLine();
                int userTime = int.Parse(g);

                Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);
                reflection.Run();
            }

            else if (userOption == 3)     //-----LISTING ACTIVITY---->
            {
                Console.WriteLine();
                Console.Write("For how long (in seconds) do you wish to do this activity? ");
                string g = Console.ReadLine();
                int userTime = int.Parse(g);

                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. Be honest and sincere to yourself.", userTime);
                listing.Run();
            }

            else if (userOption == 4)
            {
                Console.WriteLine("Thanks for playing! We hope you are more relaxed and calm!");
                Console.Write("Come again to play soon!");
                Console.WriteLine();
            }
        }
    }
}