using System;

class Program
{
    static void Main(string[] args)
    {   
        string answer = "yes";
        do
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess;
        int attempts = 1;
            do
            {
                Console.Write("What is your guess: ");
                guess = int.Parse(Console.ReadLine());
                Console.Clear();
                if(magicNumber == guess)
                {
                    Console.WriteLine("You guessed it!");
                }
                else
                {   
                    attempts ++;
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
            Console.WriteLine($"You attempted to guess the number {attempts} times");
            Console.Write("Do you want to play again? (yes / no): ");
            answer = Console.ReadLine();
            Console.Clear();
        }while(answer.ToLower() == "yes");
    }
}