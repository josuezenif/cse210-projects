// I added an the animated spinner and used it throughout the program! I also added additional lines saying "creating goal"
// and making it look like a real game! I added a celebration method to the Checklist class and it is an animation
// for when the user completes a checklist activity (fully completed), the animation runs and gives a exciting effect!

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.Clear();

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}