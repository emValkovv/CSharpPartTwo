using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine(0);
            for (int i = 1; i < n; i++)
            {
                array[0] = 0;
                array[i] = array[i - 1] + 5;
                Console.WriteLine(array[i]);
            }
        }
    }
