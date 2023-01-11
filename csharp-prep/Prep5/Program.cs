using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        Console.WriteLine();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);
    }
    //function to print the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    //function to prompt the user to enter his/her name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    //function to prompt the user to enter his/her favorite
    //number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    //function to get the number and reuturn it squared
    static int SquareNumber(int number)
    {
        return number*number;
    }
    //function to print the result as desired
    //"user's name" the square of your number is "squared number".
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    } 
}