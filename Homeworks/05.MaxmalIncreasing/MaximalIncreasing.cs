using System;

class MaximalIncreasing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int count = 1;
        int number = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < n - 1; k++)
        {
            if (numbers[k] < numbers[k + 1])
            {
                count++;
                if (number < count)
                {
                    number = count;
                }
            }
            else if (numbers[k] >= numbers[k + 1])
            {
                count = 1;
            }
        }
        Console.WriteLine(number);
    }
}

