using System;
using System.Globalization;
using System.Threading;





class TriangleSurfaceByTwoSidesAndAngle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        Triangle tri = new Triangle(sideA, sideB, angle);
        Console.WriteLine("{0:F2}", tri.CalculateArea());
    }
}

class Triangle
{
    private double sideA;
    private double sideB;
    private double angle;

    public Triangle(double sideA, double sideB, double angle)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.angle = angle;
    }

    public double CalculateArea()
    {
        double area = sideA * sideB * Math.Sin(rad(angle)) / 2;
        return area;
    }
    
    public static double rad(double deg)
    {
        return deg * Math.PI / 180;
    }

}