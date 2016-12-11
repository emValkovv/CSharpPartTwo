using System;

    class LargerThanNeighbours
    {
        static void Larger(int[] array)
        {
            int counter = 0;
            int notCounter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
                else
                {
                    notCounter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            Larger(array);
        }
    }
