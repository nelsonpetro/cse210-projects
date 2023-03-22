using System;

public class Comments
{
    private string _name;
    private string _comment;

    public Comments(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nComment: {_comment}");
    }
}