// I added an extra option for the user, this was to ask the user to Write whatever they wanted in a text box
// Then I added their response to the an entry using the entry class (lines 41-51)
// I made the prompt random question a choice for the user

using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();

        Console.WriteLine("Welcome to your Journal App!");
        Console.WriteLine("Write everything you did today and goals you want to accomplish!");
        Console.WriteLine();

        int userInput = 0;
        int quit = 6;

        while (userInput != quit)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Prompt a question");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            string user_Input = Console.ReadLine();
            userInput = int.Parse(user_Input);
            Console.WriteLine();


            if (userInput == 1)   // asks user what they want to write and adds their text to the entry 
            {
                Console.Write("What did you do today? ");
                string text = Console.ReadLine();
                string firstQuestion = "What did you do today?";

                Entry entry = new Entry();
                DateTime _currentDate = DateTime.Now;
                entry._date = _currentDate.ToShortDateString();
                entry._promptText = firstQuestion;
                entry._entryText = text;

                journal.AddEntry(entry);
            }

            else if (userInput == 2)    // prompts a random question
            {
                PromptGenerator promptQuestion = new PromptGenerator();
                string randomQuestion = promptQuestion.promptQuestion();
                Console.Write(randomQuestion);
                string answer = Console.ReadLine();

                Entry entry = new Entry();
                DateTime _currentDate = DateTime.Now;
                entry._date = _currentDate.ToShortDateString();
                entry._promptText = randomQuestion;
                entry._entryText = answer;

                journal.AddEntry(entry);
            }

            else if (userInput == 3)   // this is the DISPLAY option
            {
                journal.DisplayAll();
            }

            else if (userInput == 4)   // save option
            {
                Console.WriteLine("Type in a filename to save entries: ");
                string filename = Console.ReadLine();
                Console.WriteLine();
                journal.SaveToFile(filename);
            }

            else if (userInput == 5)    // load option
            {
                Console.WriteLine("Enter the filename to load entries: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (userInput == 6)  // quit option
            {
                Console.WriteLine("Thanks you for using your Journal app!");
                Console.WriteLine("Come again tommorow!");
                Console.WriteLine();
                break;
            }
        }
    }
}