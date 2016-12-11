using System;

    class Surface
    {
        public static double Calculations(double a, double hA)
        {
            double surface = (a * hA) / 2;
            return surface;
        }
    }

    class TriangleSurfaceSideAttitude
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double hA = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Surface.Calculations(a, hA));
        }
    }
