public class GoalManager
{
    protected List<Goal> _goalsList = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        int count = 1;

        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;
        Console.WriteLine("Your goals are: ");
        Console.WriteLine();

        foreach (Goal goal in _goalsList)
        {
            Thread.Sleep(1000);

            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()    //QUESTIONS ABOUT THE GOALS
    {
        Console.Write("What is the name of you goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many point are associated with this goal? ");
        string pt = Console.ReadLine();
        int points = int.Parse(pt);

        Goal goal = new SimpleGoal(goalName, description, points);
        _goalsList.Add(goal);
    }

    public void CreateEternalGoal()
    {
        Console.Write("What is the name of you goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many point are associated with this goal? ");
        string pt = Console.ReadLine();
        int points = int.Parse(pt);

        Goal goal = new EternalGoal(goalName, description, points);
        _goalsList.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine();
        Console.Write("Which goal did you complete? ");
        int count = int.Parse(Console.ReadLine());

        if (count < 1 || count > _goalsList.Count)
        {
            Console.WriteLine("Invalid choice! Try again");     // EXCEEDING REQUIREMENTS!
            return;
        }

        Console.WriteLine();

        Goal goal = _goalsList[count - 1];
        goal.RecordEvent();

        int pointsEarned = goal.GetPoints();
        _score += pointsEarned;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goalsList)
            {
                output.WriteLine(goal.GetStringRepresentation());     // display GET STRING REPRESENTATION
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] parts = System.IO.File.ReadAllLines(filename);

        _goalsList.Clear();     // CLEANS LIST

        bool firstLine = true;

        foreach (string part in parts)
        {
            if (firstLine)
            {
                _score = int.Parse(parts[0]);
                firstLine = false;
                continue;
            }

            string[] lines = part.Split("|");
            string GoalType = lines[0];

            if (GoalType == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(lines[1], lines[2], int.Parse(lines[3]), bool.Parse(lines[4]));
                _goalsList.Add(simpleGoal);
            }

            if (GoalType == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal(lines[1], lines[2], int.Parse(lines[3]));
                _goalsList.Add(eternalGoal);
            }

            if (GoalType == "Checklist Goal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(lines[1], lines[2], int.Parse(lines[3]), int.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]));
                _goalsList.Add(checklistGoal);
            }
        }
    }

    public void ChecklistGoalQuestions()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.WriteLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.WriteLine();

        Console.Write("How many point are associated with this goal? ");
        string pt = Console.ReadLine();
        int points = int.Parse(pt);

        Console.WriteLine();

        Console.Write("How many times does the goal need to be accomplished for? ");
        int target = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        Goal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
        _goalsList.Add(checklistGoal);


    }
}