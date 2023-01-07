using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user to enter his/her first name on the same line
        Console.Write("What is your first name? ");
        //Get the input from the user
        string firstName = Console.ReadLine();
        //Ask the user to enter his/her last name on the same line
        Console.Write("What is your last name? ");
        //Get the input from the user
         string lastName = Console.ReadLine();
        //Print the final sentence
        Console.WriteLine($"Your name is {char.ToUpper(lastName[0])}{lastName.Substring(1).ToLower()}, {char.ToUpper(firstName[0])}{firstName.Substring(1).ToLower()} {char.ToUpper(lastName[0])}{lastName.Substring(1).ToLower()}.");
         
    }
}