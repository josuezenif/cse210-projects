using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;     // This is the bonus point for when completed
    private List<string> _celebrationList = new List<string>();

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;     // ADDS 1 TO THE AMOUNT COMPLETED 

        if (_amountCompleted == _target)        // FULLY COMPLETED CHECKLIST GOAL
        {
            _points += _bonus;
            Celebration();
            Thread.Sleep(4000);
            Console.WriteLine();

            Console.WriteLine("Congratulations! You have fully completed the Checklist Goal!");
            Console.WriteLine($"You have earned {_points} points with the {_bonus} bonus!");
            GetPoints();
            Console.WriteLine();
            Thread.Sleep(5000);
        }
        else
        {
            Console.WriteLine("Congratulations! You have completed a Checklist Goal!");
            Console.WriteLine($"You have earned {_points} points!");
            GetPoints();
            Thread.Sleep(3000);
        }

    }

    public override int GetPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == true && _amountCompleted == _target)
        {
            return $"[X] {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";
        }

        else
        {
            return $"[ ] {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public void AddCelebrationStrings()
    {
        _celebrationList.Add("C");
        _celebrationList.Add("O");
        _celebrationList.Add("N");
        _celebrationList.Add("G");
        _celebrationList.Add("R");
        _celebrationList.Add("A");
        _celebrationList.Add("T");
        _celebrationList.Add("U");
        _celebrationList.Add("L");
        _celebrationList.Add("A");
        _celebrationList.Add("T");
        _celebrationList.Add("I");
        _celebrationList.Add("O");
        _celebrationList.Add("N");
        _celebrationList.Add("S");
        _celebrationList.Add("!");
        _celebrationList.Add("!");
        _celebrationList.Add("🥳");
        _celebrationList.Add("🤩");
        _celebrationList.Add("🤯");
        _celebrationList.Add("🥳");

    }

    public void Celebration()
    {
        AddCelebrationStrings();

        foreach (string letter in _celebrationList)
        {
            Console.Write(letter);
            Thread.Sleep(120);
        }

        Console.WriteLine();
        Console.WriteLine("Keep up the great work! 💪");
    }
}