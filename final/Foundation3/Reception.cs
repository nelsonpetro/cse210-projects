public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string ShortDescription()
    {
        return $"Reception: {GetTitle()}, {GetDate().ToShortDateString()}\n";
    }

    public override string StandardDetails()
    {
        return $"Reception: {Details()}";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}RSVP: {_rsvp}";
    }
}