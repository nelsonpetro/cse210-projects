using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        List<string> options = new List<string>()
        {
            "Square",
            "Rectangle",
            "Circle"
        };

        while (true)
        {
            Console.WriteLine("Options:");
            foreach(string option in options)
            {
                Console.WriteLine($"{options.IndexOf(option)+1}. {option}");
            }
            Console.Write("\nPlease, enter the shape: ");
            
            int choice = int.Parse(Console.ReadLine());

            Console.Write("\nPlease, enter the color: ");
            string color = Console.ReadLine();

            switch(choice)
            {
                case 1:
                    Console.Write("Please, enter the length of the side: ");
                    double side = double.Parse(Console.ReadLine());
                    Square square = new Square(color, side);
                    shapes.Add(square);
                    break;
                case 2:
                    Console.Write("Please, enter the length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Please, enter the width: ");
                    double width = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(color, length, width);
                    shapes.Add(rectangle);
                    break;
                case 3:
                    Console.Write("Please, enter the radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(color, radius);
                    shapes.Add(circle);
                    break;
                default:
                    Console.WriteLine("You entered an invalid option.");
                    break;
            }

            Console.Write("\nPress enter to add another shape, type quit to exit: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
        }

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"\nThe {color} shape has an area of {area}.");
        }
    }
}