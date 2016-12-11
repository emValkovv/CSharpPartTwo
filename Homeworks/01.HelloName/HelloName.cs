using System;

    class HelloName
    {
        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            PrintName();
        }
    }
