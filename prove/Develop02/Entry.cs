using System;

public class Entry
{
    public string _text;
    public string _date;
    public string _prompt;
    public void GenerateEntry()
    {
        string entryToLine = _date + "-"+_prompt + "\n"+ _text;
        Console.Write($"{entryToLine}");
    }
}