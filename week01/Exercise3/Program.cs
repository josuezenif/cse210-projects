using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        Console.WriteLine("Welcome to guess my number! Type in a number and we'll say Higher or Lower!");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int userGuess = 0;
        int tries = 0;

        while (userGuess != number)
        {
            Console.Write("Type in your guess: ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess > number)
            {
                Console.WriteLine("Lower!");
            }

            else if (userGuess < number)
            {
                Console.WriteLine("Higher!");
            }

            else if (userGuess == number)
            {
                Console.WriteLine("Great job! You guessed the number correctly!");
                Console.WriteLine();
            }

            tries += 1;
        }

        if (tries > 5)
        {
            Console.WriteLine($"You took {tries} tries to guess correctly!");
            Console.WriteLine("Can you guess in less than 5 tries?");
        }
        
        else if (tries < 5)
        {
            Console.WriteLine($"Great job! It took you {tries} tries to answer correctly!");
            Console.WriteLine("You beat the challenge of guessing in less than 5 tries!");
        }

        
    }
}