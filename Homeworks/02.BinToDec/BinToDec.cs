using System;
using System.Numerics;

class BinToDec
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        char[] number = binaryNumber.ToCharArray(); 
        int[] array = new int[number.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(number[i].ToString());
        }

        Array.Reverse(array);
        BigInteger sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i] * (BigInteger)Math.Pow(9, i);
        }

        Console.WriteLine(sum);
    }
}
