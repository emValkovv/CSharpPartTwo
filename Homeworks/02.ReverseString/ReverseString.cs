using System;

    class ReverseString
    {
        static void Main()
        {
            string normalString = Console.ReadLine();
            char[] array = normalString.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
