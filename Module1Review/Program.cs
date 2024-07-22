using System.Threading.Channels;

namespace Module1Review;

class Program
{
    static double areaOfACircle(double radius)
    {
        var circleArea = Math.PI*Math.Pow(radius, 2);
        return circleArea;
    }

    static double areaOfATriangle(double baseLength, double height)
    {
        var triangleArea = 0.5 * baseLength * height;
        return triangleArea;
    }

    static double areaOfARectangle(double length, double width)
    {
        var rectangleArea = length * width;
        return rectangleArea;
    }

    static double areaOfASquare(double side)
    {
        var squareArea = side * side;
        return squareArea;
    }
    static void Main(string[] args)
    {
        int radius = 0;
        int baseLength = 0;
        int height = 0;
        int length = 0;
        int width = 0;
        int side = 0;
        var userChoice = 0;

        do
        {
            Console.WriteLine("Please choose from the options below:");
            Console.WriteLine("1. Find the area of a circle.");
            Console.WriteLine("2. Find the area of a triangle.");
            Console.WriteLine("3. Find the area of a rectangle.");
            Console.WriteLine("4. Find the area of a square.");
            Console.WriteLine("5. Exit");
            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 5)
            {
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                }
            }
            
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Enter the radius of your circle.");
                    while (!int.TryParse(Console.ReadLine(), out radius))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    double circle = areaOfACircle(radius);
                    Console.WriteLine($"The area of your circle is {circle}.");
                    break;

                case 2:
                    Console.WriteLine("Enter the base length of your triangle.");
                    while (!int.TryParse(Console.ReadLine(), out baseLength))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    Console.WriteLine("Enter the height of your triangle.");
                    while (!int.TryParse(Console.ReadLine(), out height))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    double triangle = areaOfATriangle(baseLength, height);
                    Console.WriteLine($"The area of your triangle is {triangle}");
                    break;

                case 3:
                    Console.WriteLine("Enter the length of your rectangle.");
                    while (!int.TryParse(Console.ReadLine(), out length))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    Console.WriteLine("Enter the width of your rectangle.");
                    while (!int.TryParse(Console.ReadLine(), out width))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    double rectangle = areaOfARectangle(length, width);
                    Console.WriteLine($"The area of your rectangle is {rectangle}");
                    break;

                case 4:
                    Console.WriteLine("Enter the side of your square.");
                    while (!int.TryParse(Console.ReadLine(), out side))
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }

                    double square = areaOfASquare(side);
                    Console.WriteLine($"The area of your square is {square}");
                    break;

                case 5:
                    Console.WriteLine("Thank you for using our Area App!...goodbye.");
                    return;

                default:
                    Console.WriteLine("Invalid input, please enter a the number of an option listed");
                    break;
            }

            Console.WriteLine();
            
        } while (userChoice != 5);

    }
}