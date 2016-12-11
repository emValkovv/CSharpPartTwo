using System;

class Surface
{
    public static double Calculations(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double surface = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        return surface;
    }
}

class TriangleSurfaceThreeSides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", Surface.Calculations(a, b, c));
    }
}

