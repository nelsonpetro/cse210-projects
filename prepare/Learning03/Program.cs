using System;

class Program
{
    static void Main(string[] args)
    {   
        int answer = 1;
        do
        {
            Console.Clear();
            Fraction frac = new Fraction();
            Console.Write("Please, enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());
            frac.SetTop(numerator);
            frac.SetBottom(denominator);
            frac.GetTop();
            frac.GetBottom();
            Console.WriteLine("");
            Console.WriteLine(frac.GetFractionString());
            Console.WriteLine(frac.GetDecimalValue());
            Console.Write("\nPlease enter 1 to use again, any other number to quit: ");
            answer = int.Parse(Console.ReadLine());
        }while(answer == 1);
    }
}