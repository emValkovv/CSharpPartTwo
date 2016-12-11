using System;

    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());    
            }
            Array.Sort(numbers);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
