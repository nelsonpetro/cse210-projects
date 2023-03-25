public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string ShortDescription()
    {
        return $"Lecture: {GetTitle()}, {GetDate().ToShortDateString()}\n";
    }

    public override string StandardDetails()
    {
        return $"Lecture: {Details()}";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}Weather:{_weather}";
    }
}