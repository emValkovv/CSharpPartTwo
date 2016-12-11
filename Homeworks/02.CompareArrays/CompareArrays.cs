using System;
using System.Linq;

    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }
            int[] newArray2 = new int[n];
            for (int i = 0; i < newArray2.Length; i++)
            {
                newArray2[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = Enumerable.SequenceEqual(newArray, newArray2);
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
