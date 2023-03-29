using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return (Speed() * GetDuration()) / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return GetDuration() / Distance();
    }
}