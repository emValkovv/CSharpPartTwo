using System;

public class DecToHex
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHex(decNumber));
    }

    static string DecimalToHex(long decNumber)
    {
        string hexNumber = string.Empty;

        if (decNumber == 0)
        {
            return hexNumber += 0;
        }
        while (decNumber > 0)
        {
            switch (decNumber % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8: hexNumber = decNumber % 16 + hexNumber; break;
            }
            decNumber /= 16;
        }

        return hexNumber;
    }
}