using System;

class Program
{
    static void Main(string[] args)
    {
        string decision = "";

        // storing scripture in reference class
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture(reference, "  And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayTextScripture());
            Console.WriteLine();

            Console.Write("Type enter to continue or 'quit' to end the program! ");
            decision = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            if (decision == "quit")
            {
                break;
            }
            else if (decision == "")
            {
                scripture.HideRandomWords(2);
            }
        }
    }
}