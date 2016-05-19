using System;
using System.Globalization;
using System.Threading;



class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        Triangle tri = new Triangle(sideA, sideB, sideC);
        Console.WriteLine("{0:F2}", tri.CalculateSurface());
    }
}

public class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;


    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public double CalculateSurface()
    {
        double p = this.sideA + this.sideB + this.sideC;
        double surface = Math.Sqrt((p / 2) * (p / 2 - sideA) * (p / 2 - sideB) * (p / 2 - sideC));
        return Math.Round(surface, 2);
    }
}