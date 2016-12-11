using System;

    class ReverseNumber
    {
        static void ReversedNumber(char[] array)
        {
            char[] reverseArray = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
			{
                reverseArray[i] = array[(array.Length - 1) - i];
			}
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.Write(reverseArray[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            char[] array = Console.ReadLine().ToCharArray();
            ReversedNumber(array);
        }
    }
