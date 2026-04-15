public class Swimming : Activity
{
    double _numberOfLaps;

    public Swimming(string name, string date, int lengthTime, double numberOfLaps) : base(name, date, lengthTime)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000;
        return distance;
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
        return $"{_date} - {_name} ({_lengthTime} min) Distance: {GetDistance().ToString("F2")} km. Speed: {GetSpeed().ToString("F2")} kph. Pace: {GetPace().ToString("F2")} min per km";
    }
}