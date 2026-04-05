public class Reflection : Activity
{
    private List<string> _promptsList = ["----Think of a time when you stood up for someone else.----",
        "----Think of a time when you helped someone in need.----",
        "----Think of a time when you did something really difficult.----",
       "----Think of a time when you did something truly selfless.----",
       "----Think of a time you felt like truly like yourself.----",
        "----Think of a time you felt the Holy Ghost in your life.----",
       "----Think of a an experience where you changed for the better.----",
        "----Think of a time where you engaged service to others.----"
         ];

    private List<string> _questionsList = ["> Why was this experience meaningful to you?",
    "> Have you ever done anything like this before?",
    "> How did you get started?",
    "> How did you feel when it was complete?",
    "> What made this time different than other times when you were not as successful?",
    "> What is your favorite thing about this experience?"
    ];

    public Reflection(string name, string description, int duration) : base(name, description, duration)
    {

    }


    public void Run()
    {
        Console.Clear();

        DisplayStartingMsg();
        ShowSpinner(12);
        Console.Clear();
        Console.Write("Get ready... ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        DisplayPrompt();        // DISPLAYING PROMPT

        Console.WriteLine();
        Console.WriteLine("Press enter when you have something in mind... ");
        string ready = Console.ReadLine();

        if (ready == "")
        {
            Console.WriteLine("Ponder your experience to these question!");
            Console.Write("-- ");
            ShowCountDown(5);

            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            // DISPLAYING QUESTION
            while (DateTime.Now < endTime)
            {
                GetRandomQuestion();
                DisplayQuestion();
                ShowSpinner(15);
            }

            // --------| ENDING |---------
            DisplayEndingMsg();
            ShowSpinner(5);
            Console.Clear();
        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptsList.Count);
        string randomPrompt = _promptsList[index];

        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questionsList.Count);
        string randomQuestion = _questionsList[index];

        return randomQuestion;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}