using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        // CREATING AND ADDING ACTIVITIES
        Running running = new Running("Running", "12-03-2026", 40, 5.3);
        running.AddActivity(running);

        Bicycle bicycle = new Bicycle("Bicycle", "14-03-2026", 32, 7.34);
        running.AddActivity(bicycle);

        Swimming swim = new Swimming("Swimming", "18-03-2026", 45, 27);
        running.AddActivity(swim);

        //DISPLAYING ACTIVITIES AND THEIR INFO
        Console.WriteLine("Tracking excercices: ");
        Console.WriteLine();

        running.IterateList();

        Console.WriteLine(); // PRINTING EXTRA LINE FOR SPACIING
    }
}