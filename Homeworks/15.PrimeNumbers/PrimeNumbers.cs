using System;

public class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primeNumbers = new bool[n + 1];  // all numbers value is false by default
        for (int i = 0; i < primeNumbers.Length; i++)
        {
            primeNumbers[i] = true;               // so we set them all to true to be easier to chech them
        }
        // checking for prime numbers
        for (int i = 2; i < primeNumbers.Length; i++)
        {
            if (primeNumbers[i])
            {
                for (int j = i + i; j < primeNumbers.Length; j += i)
                {
                    primeNumbers[j] = false;
                }
            }
        }

        for (int i = primeNumbers.Length - 1; i > 0; i--)
        {
            if (primeNumbers[i])
            {
                Console.Write(i);
                break;
            }
        }
    }
}