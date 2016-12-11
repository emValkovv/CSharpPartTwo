using System;

    class MaxSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; i++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            int sum1 = 0;
            for (int row = 0; row < n - 2; row++)
            {
                for (int cols = 0; cols < n - 2; cols++)
                {
                    sum += array[row, cols] + array[row, cols + 1] + array[row, cols + 2] +
                    array[row + 1, cols] + array[row + 1, cols + 1] + array[row + 1, cols + 2] +
                    array[row + 2, cols] + array[row + 2, cols + 1] + array[row + 2, cols + 2];
                    if (sum1 < sum)
                    {
                        sum1 = sum;
                    }
                }
            }

            Console.WriteLine(sum1);
        }
    }
