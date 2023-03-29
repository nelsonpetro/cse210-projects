using System;

public abstract class Activity 
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string Summary(string name)
    {
        return $"{_date.ToString("dd MMM yyyy")} {name} ({_duration} min)  - Distance: {Distance()} km - Speed: {Speed()} km/h - Pace: {Pace()} min/km";
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    
}