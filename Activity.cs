using System;

public abstract class Activity
{
    private string date;
    private int duration; // in minutes

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public string Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
