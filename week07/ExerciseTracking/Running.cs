public class Running : Activity
{
    public Running(string name, string date, int lengthTime, double distance) : base(name, date, lengthTime)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double speed = distance / _lengthTime * 60;

        return speed;
    }

    public override double GetPace()
    {
        double speed = GetSpeed();
        double pace = 60 / speed;

        return pace;
    }

    public override string GetSummary()
    {
        return $"{_date} - {_name} ({_lengthTime} min) Distance: {GetDistance()} km. Speed: {GetSpeed().ToString("F2")} kph. Pace: {GetPace().ToString("F2")} min per km";
    }

}