using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new list object named numbers
        List<int> numbers = new List<int>();
        //Declare an int variable named "number"
        int number;
        float sum = 0;
        float average;
        int largest = 0;
        int smallest = int.MaxValue;
        int smallestPositive = int.MaxValue;
        //Display a prompt for the user to know how to stop entering numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        //do-while loop to add numbers to the list
        do
        {
            //asks the user to enter a number and 
            //add it to the numbers list
            Console.Write("Please, enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }while(number != 0);
        //for each loop to calculate the sum of the numbers
        foreach(int item in numbers)
        {
            sum += item;
        }
        //foreach loop to find the largest integer
        foreach(int item in numbers)
        {
            if (largest < item)
            {
                largest = item;
            }
        }
        //foreach loop to find the smallest integer
        foreach(int item in numbers)
        {
            if (smallest > item)
            {
                smallest = item;
            }
        }
        //foreach loop to find the smallest positive integer
        foreach(int item in numbers)
        {
            if (smallestPositive > item && item > 0)
            {
                smallestPositive = item;
            }
        }
        //sort the list using the Sort() method
        numbers.Sort();
        //Display the restuls here
        average = sum / (numbers.Count);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"[{String.Join(", ", numbers)}]");
    }
}