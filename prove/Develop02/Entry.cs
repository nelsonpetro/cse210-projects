using System;

public class Entry
{
    public string _text;
    public string _date;
    public string _prompt;
    public List<string> GenerateEntry()
    {
        List<string> _entryValues = new List<string>();
        _entryValues.Add(_date);
        _entryValues.Add(_prompt);
        _entryValues.Add(_text);
        
        return _entryValues;
    }
}