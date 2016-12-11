using System;
using System.Linq;

    class Sum
    {
        public static int SumOfArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }

    class SumIntegers
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int[] array = number
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(Sum.SumOfArray(array));     
        }
    }
