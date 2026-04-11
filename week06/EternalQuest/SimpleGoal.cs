using System.Globalization;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine("Congratulations! You have completed a Simple Goal!");
        Console.WriteLine($"You have earned {_points} points!");
        Thread.Sleep(3000);
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}