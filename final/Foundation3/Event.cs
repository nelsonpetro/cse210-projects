public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public string Details()
    {
        return $"{_title}\n{_description}\nDate: {_date.ToShortDateString()} Time: {_time}\nAddress: {_address}\n";
    }

    public abstract string ShortDescription();
    public abstract string StandardDetails();
    public abstract string FullDetails();
}