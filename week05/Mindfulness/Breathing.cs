public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMsg();      // <--------DISPLAYING ACTIVITY-------->
        ShowSpinner(11);
        Console.Clear();

        Console.Write("Get ready! -- ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        DisplayEndingMsg();
        ShowSpinner(5);           // <------- DISPLAYING ENDING------->
        Console.Clear();
    }
}