using System;
using System.Linq;
using System.Numerics;

class CryptoCS
{
    static BigInteger MeowToDec(string meow)
    {
        BigInteger result = 0;

        foreach (char digit in meow)
        {
            result = (digit - 'a') + result * 26;
        }

        return result;
    }

    static BigInteger DecToMeow(string dec)
    {
        BigInteger result = 0;

        foreach (char digit in dec)
        {
            result = (digit - '0') + result * 7;
        }

        return result;
    }
    static string DecimalToBinary(BigInteger decNumber)
    {
        string binNumber = string.Empty;
        string reverseNumber = string.Empty;

        if (decNumber == 0)
        {
            return binNumber += 0;
        }
        while (decNumber > 0)
        {
            reverseNumber += decNumber % 9;
            decNumber /= 9;
        }

        for (int i = reverseNumber.Length - 1; i >= 0; i--)
        {
            binNumber += reverseNumber[i];
        }
        BigInteger a = BigInteger.Parse(binNumber);
        return binNumber;
    }
    static void Main()
    {
        string sum = Console.ReadLine();
        string sign = Console.ReadLine();
        string sumTwo = Console.ReadLine();
        BigInteger summary = 0;
        switch (sign[0])
        {
            case '+': summary = MeowToDec(sum) + DecToMeow(sumTwo); break;
            case '-': summary = MeowToDec(sum) - DecToMeow(sumTwo); break;
            default: break;
        }
        string result = DecimalToBinary(summary);
        Console.WriteLine(result);
    }
}