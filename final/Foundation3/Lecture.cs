public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
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
        return $"{StandardDetails()}Speaker: {_speaker}\nCapacity: {_capacity}";
    }
}