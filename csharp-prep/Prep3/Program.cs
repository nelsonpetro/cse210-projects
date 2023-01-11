using System;

class Program
{   
    static void Main(string[] args)
    {   
        //create a variable named answer to handle
        //the continuity of the code if the user wants to
        string answer = "yes";
        //do while loop to handle the first part
        //of the code
        do
        {
            //Generates a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            //declare variablesto store the guess and attempts the user
            //took to guess the correcct number
            int guess;
            int attempts = 1;
            //do while to handle the guessing part of the code
            do
            {
                //prompt the user to write a guess
                Console.Write("What is your guess: ");
                guess = int.Parse(Console.ReadLine());
                //clear the terminal
                Console.Clear();
                //compare the guess to the random number
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