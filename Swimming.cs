using System;

public class Swimming : Activity
{
    private int laps;
    private const double lapDistance = 50; // meters per lap

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * lapDistance / 1000 * 0.62; // converting meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
