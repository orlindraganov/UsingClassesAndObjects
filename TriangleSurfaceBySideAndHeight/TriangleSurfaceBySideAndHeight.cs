using System;
using System.Globalization;
using System.Threading;


class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Triangle tri = new Triangle(side, height);
        Console.WriteLine("{0:F2}", tri.CalculateSurface());
    }
}

class Triangle
{
    private double side;
    private double height;

    public Triangle(double side, double height)
    {
        this.height = height;
        this.side = side;
    }
    public double CalculateSurface()
    {
        double surface = Math.Round(this.side * this.height / 2, 2);
        return surface;
    }
}
