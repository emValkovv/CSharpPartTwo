using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            Console.WriteLine(0);
            for (int i = 1; i < n; i++)
            {
                newArray[0] = 0;
                newArray[i] = newArray[i - 1] + 5;
                Console.WriteLine(newArray[i]);
            }
        }
    }
