public abstract class Activity
{
    protected string _name;
    protected string _date;
    protected int _lengthTime;
    protected double _distance;     // DISTANCE IN KM   
    protected double _speed;
    private List<Activity> _activitiesList = new List<Activity>();

    public Activity(string name, string date, int lengthTime)
    {
        _name = name;
        _date = date;
        _lengthTime = lengthTime;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();

    public void AddActivity(Activity activity)
    {
        _activitiesList.Add(activity);
    }

    public void IterateList()
    {
        foreach (Activity activity in _activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}