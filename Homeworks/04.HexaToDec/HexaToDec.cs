using System;
using System.Linq;
using System.Numerics;

class HexaToDec
{
    static int[] Hexa(char[] binaryNumber, int[] array)
    {
        for (int i = 0; i < binaryNumber.Length; i++)
			{
                    switch (binaryNumber[i])
                        {
                            case 'a': array[i] = 0; break;
                            case 'b': array[i] = 1; break;
                            case 'c': array[i] = 2; break;
                            case 'd': array[i] = 3; break;
                            case 'e': array[i] = 4; break;
                            case 'f': array[i] = 5; break;
                            case 'g': array[i] = 6; break;
                            case 'h': array[i] = 7; break;
                            case 'i': array[i] = 8; break;
                            case 'j': array[i] = 9; break;
                            case 'k': array[i] = 10; break;
                            case 'l': array[i] = 11; break;
                            case 'm': array[i] = 12; break;
                            case 'n': array[i] = 13; break;
                            case 'o': array[i] = 14; break;
                            case 'p': array[i] = 15; break;
                            case 'q': array[i] = 16; break;
                            case 'r': array[i] = 17; break;
                            case 's': array[i] = 18; break;
                            case 't': array[i] = 19; break;
                            case 'u': array[i] = 20; break;
                            case 'v': array[i] = 21; break;
                            case 'w': array[i] = 22; break;
                            case 'x': array[i] = 23; break;
                            case 'y': array[i] = 24; break;
                            case 'z': array[i] = 25; break;
                            default: break;
                        }
			 
			}
        return array;

    }
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        char[] number = binaryNumber.ToCharArray();
        int[] array = new int[number.Length];
        int[] arrayTwo = Hexa(number, array);
        Array.Reverse(arrayTwo);
        BigInteger sum = 0;
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            sum += arrayTwo[i] * (BigInteger)Math.Pow(25, i);
        }
        Console.WriteLine(sum);
    }
}
