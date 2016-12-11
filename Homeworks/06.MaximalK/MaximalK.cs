using System;

    class MaximalK
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nArray = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                nArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nArray);
            for (int i = nArray.Length - k ; i < nArray.Length; i++)
            {
                sum += nArray[i];
            }
            Console.WriteLine(sum);
        }
    }
