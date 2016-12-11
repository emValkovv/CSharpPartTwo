using System;

    class FirstLarger
    {
        static void Larger(int[] array)
        {
            int notCounter = 2;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    notCounter++;
                }
            }
            if (notCounter >= array.Length)
            {
                Console.WriteLine("-1");
            }

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
