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
        Goal1 goal1 = new Goal1();

        Console.WriteLine("Welcome to the Eternal Goal Quest!");
        Console.WriteLine("Write your goals and make points as you complete them!");
        Console.WriteLine();

        int option = 0;
        int quit = 6;

        while (option != quit)
        {
            Console.WriteLine();
            goalManager.DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.Write("What would you like to do? ");
            string userOption = Console.ReadLine();
            option = int.Parse(userOption);

            if (option == 1)
            {
                // RUN THE CREATE GOAL 
                Console.Clear();
                Console.WriteLine("The type of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine();

                Console.Write("Which type of goal would you like to do? ");
                string op = Console.ReadLine();
                int userOp = int.Parse(op);

                if (userOp == 1) // simple goal
                {
                    //RUN THE INFO QUESTIONS
                    Console.Clear();
                    goalManager.CreateGoal();
                    goal1.ShowAnimation();
                    Console.Clear();
                }

                else if (userOp == 2)   // ETERNAL GOAL
                {
                    Console.Clear();
                    goalManager.CreateEternalGoal();
                    goal1.ShowAnimation();
                    Console.Clear();
                }

                else if (userOp == 3)       // CHECKLIST GOAL
                {
                    Console.Clear();
                    goalManager.ChecklistGoalQuestions();
                    goal1.ShowAnimation();
                    Console.Clear();
                }
            }

            else if (option == 2)
            {
                Console.Clear();
                goalManager.ListGoalDetails();
                Thread.Sleep(2000);
            }

            else if (option == 3)   // SAVE GOAL TO FILE
            {
                Console.Write("Type in the name of your file: ");
                string userFile = Console.ReadLine();

                goalManager.SaveGoals(userFile);

                Console.WriteLine("Saving data to file...");
                goal1.ShowSpinner(3);
                Console.Write("Data successfully saved!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else if (option == 4)       // LOAD GOALS FROM FILE 
            {
                Console.Write("Type in the name of your file: ");
                string userFile = Console.ReadLine();

                goalManager.LoadGoals(userFile);
                Console.WriteLine("Retrieving data and goals...");
                goal1.ShowSpinner(3);
                Console.Write("Data retrieved!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else if (option == 5)       // RECORD EVENT 
            {
                Console.Clear();
                goalManager.RecordEvent();
                Console.Clear();
            }

            else if (option == 6)
            {
                Console.WriteLine("You better go and complete more goals! 😤");
                Thread.Sleep(2000);
                Console.WriteLine("NEVER BACK DOWN, NEVER WHAT...?");
                Console.WriteLine();
                Thread.Sleep(2300);
                Console.WriteLine("NEVER GIVE UP!");
            }
        }
    }
}