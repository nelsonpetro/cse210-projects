using System;

public class Menu
{
    List<string> menu = new List<string>()
    {
        "Create order",
        "Display orders",
        "Quit"
    };

    public void DisplayMenu()
    {
        foreach(string option in menu)
        {
            Console.WriteLine($"{menu.IndexOf(option)+1}. {option}");
        }
    }
}