using System;

    class Surface
    {
        public static double Calculations(double a, double b, double sin)
        {
            double surface = (a * b * (Math.Sin((sin * Math.PI) / 180))) / 2;
            return surface;
        }
    }

    class TriangleSurfaceAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sin = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Surface.Calculations(a, b, sin));
        }
    }
