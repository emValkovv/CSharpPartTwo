using System;
using System.Numerics;
    class Factorial
    {
        static void NFactorial(int number)
        {
            BigInteger product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            NFactorial(number);
        }
    }
