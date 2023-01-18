using System;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        List<string> options = new List<string>()
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
        foreach(string option in options)
        {
            Console.WriteLine($"{options.IndexOf(option) + 1}. {option}");
        }
        Console.Write("What would you like to do?: ");
    }
}