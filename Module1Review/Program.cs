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
    
    
    static void Main(string[] args)
    {
        double circle = areaOfACircle(3);
        Console.WriteLine($"The area of your circle is {circle}");

        double triangle = areaOfATriangle(3.0, 3.0);
        Console.WriteLine($"The area of your triangle is {triangle}");
    }
}