using System;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        List<string> _options = new List<string>()
        {
            "Write",
            "Display current entries",
            "Display all entries",
            "Discard entries",
            "Save entries",
            "Delete specific entry",
            "Delete all entries",
            "Quit"
        };
        foreach(string _option in _options)
        {
            Console.WriteLine($"{_options.IndexOf(_option) + 1}. {_option}");
        }
        Console.Write("What would you like to do?: ");
    }
}