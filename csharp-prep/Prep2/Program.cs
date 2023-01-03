using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask te user to enter the grade
        Console.Write("Please, enter the grade: ");
        //Read the grade enter by the user
        //float is used to handle non-integer percentages
        float grade = float.Parse(Console.ReadLine());
        //Clasify the grade
        //Declare an empty string to store the letter
        //that correspond to the grade
        String gradeLetter;
        //Declare an empty string to store the sign
        String sign;
        //Get the second digit of the grade using
        //the module operator to assign the "-" or "+"
        //to the correspondent letter
        float remainder = grade % 10;
        //Conditional statement to check the grade and
        //assign the letter
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        //Check the remainder to assign the "+" or "-" sign
        if (grade >= 60 && grade < 93)
        {
            if (remainder < 3)
            {
                sign = "-";
            }
            else if (remainder >= 7)
            {
                sign = "+";
            }
            else
            {
            sign = "";
            }
        }
        else
        {
            sign = "";
        }
        //Assign and print the final grade
        Console.WriteLine($"Your final grade is: {gradeLetter}{sign}");
        //If statement to print if the user passed or not the course
        if (grade >= 70)
        {
            Console.Write("Congratulations! You passed the course!");
        }
        else
        {
            Console.Write("You did not passed the course. Try harder next time!");
        }
    }
}