public class Listing : Activity
{
    private int _count;
    private List<string> _userItems = new List<string>();
    private List<string> _promptsList = ["> Who are people that you appreciate?",
        "> What are personal strengths of yours?",
        "> Who are people that you have helped this week?",
       "> When have you felt the Holy Ghost this month?",
       "> Who are some of your personal heroes?",
        "> When have you felt the hand of Christ in your life?",
       "> Have you engaged yourself in service to others? If so, how did you feel?",
        "> When was the last time you chose to be happy?",
        "> When was the last time you forgave someone? How did you feel?",
        "> Who do you love the most?",
        "> What are the things you are most grateful for?"
        ];

    public Listing(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptsList.Count);
        string randomPrompt = _promptsList[index];

        Console.WriteLine(randomPrompt);
    }

    public void GetListFromUser()
    {
        _count = _userItems.Count;
        Console.WriteLine($"Time's up! You listed {_count} of items!");
    }

    public void Run()
    {
        Console.Clear();

        DisplayStartingMsg();
        ShowSpinner(12);
        Console.Clear();

        Console.WriteLine("List as many things as you can about the following prompt!");
        Console.WriteLine();

        GetRandomPrompt();
        ShowSpinner(5);

        Console.Write("You begin in ");
        ShowCountDown(5);

        // setting up the time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _userItems.Add(item);
        }

        GetListFromUser();
        Thread.Sleep(3000);

        Console.WriteLine();
        DisplayEndingMsg();
        ShowSpinner(8);
        Console.Clear();
    }
}