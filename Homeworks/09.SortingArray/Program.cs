using System;
using System.Linq;

class SortingArray
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        decimal[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(s => decimal.Parse(s)).ToArray();
        SortArray(arrayOfNumbers);
        Console.WriteLine(string.Join(" ", arrayOfNumbers));
    }

    static void SortArray(decimal[] array)
    {
        Array.Sort(array);
    }
}