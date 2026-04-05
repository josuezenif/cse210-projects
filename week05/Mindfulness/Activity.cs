public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private List<string> animationsStrings = new List<string>();

    public void AddAnimationStrings()
    {
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMsg()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");

        // Console.Write("For how long (in seconds) do you wish to do this activity? ");
        // string g = Console.ReadLine();
        // int userTime = int.Parse(g);
        // _duration = userTime;
    }

    public void DisplayEndingMsg()
    {
        Console.WriteLine("");
        Console.WriteLine("Great job!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds!");
        Console.WriteLine("");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startDate = DateTime.Now;
        DateTime endTime = startDate.AddSeconds(seconds);
        // |/-\|/-
        AddAnimationStrings();
        while (DateTime.Now < endTime)
        {
            foreach (string item in animationsStrings)
            {
                Console.Write(item);      // goes for the length of the list 
                Thread.Sleep(80);       // 8 seconds right now (not anymore)
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}