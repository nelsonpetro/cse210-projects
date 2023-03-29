using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return (_laps * 50) / 1000;
    }

    public override double Speed()
    {
        return (Distance() / GetDuration()) * 60;
    }

    public override double Pace()
    {
        return GetDuration() / Distance();
    }
}