using System;

    class CompareCharArrays
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            char[] firstArray = first.ToCharArray();
            char[] secondArray = second.ToCharArray();

            if (firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("=");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
        }
    }
