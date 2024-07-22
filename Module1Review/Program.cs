namespace Module1Review;

class Program
{
    static double areaOfACircle(double radius)
    {
        var circleArea = Math.PI*Math.Pow(radius, 2);
        return circleArea;
    }

    static double areaOfATriangle(double baselength, double height)
    {
        var triangleArea = 0.5 * baselength * height;
        return triangleArea;
    }

    static double areaOfARectangle(double length, double width)
    {
        var rectangleArea = length * width;
        return rectangleArea;
    }
    
    static void Main(string[] args)
    {
        double circle = areaOfACircle(3);
        Console.WriteLine($"The area of your circle is {circle}");

        double triangle = areaOfATriangle(3.0, 3.0);
        Console.WriteLine($"The area of your triangle is {triangle}");

        double rectangle = areaOfARectangle(4, 5);
        Console.WriteLine($"The area of your rectangle is {rectangle}");
    }
}