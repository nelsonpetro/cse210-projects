using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?: ");
        int magicNumber = int.Parse(Console.ReadLine());
        int guess;
        do
        {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
            Console.Clear();
            if(magicNumber == guess)
            {
                Console.Write("You guessed it!");
            }
            else
            {
                Console.WriteLine($"Your guess was {guess}");
                if(magicNumber > guess)
                {
                    Console.WriteLine("Try again with a higher number");
                }
                else
                {
                    Console.WriteLine("Try again with a lower number");
                }
            }
        }while(magicNumber != guess);
    }
}