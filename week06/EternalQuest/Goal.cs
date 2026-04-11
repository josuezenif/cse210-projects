public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_shortName} ({_description}) {_points} pts";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) {_points} pts";
        }
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public abstract int GetPoints();
}

public class Goal1
{
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

    public void ShowAnimation()
    {
        Console.Write("Creating goal... ");
        ShowSpinner(3);
        Console.WriteLine("Goal created!");
        Thread.Sleep(3000);
    }
}