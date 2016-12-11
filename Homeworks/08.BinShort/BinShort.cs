using System;

public class BinShort
{
    static void Main()
    {
        short input = short.Parse(Console.ReadLine());
        string inputToBinary = ShortToBinary(input);
        Console.WriteLine("{0}{1}", inputToBinary[0], inputToBinary.Substring(1, 15));
    }

    static string ShortToBinary(short number)
    {
        byte[] bytesInput = BitConverter.GetBytes(number); 
        string inputToBinary = "";
        for (int i = 0; i < bytesInput.Length; i++)
        {
            inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
        }

        return inputToBinary;
    }
}