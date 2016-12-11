using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Kitty
{
    static void Main()
    {

        //1. input
        //2. 
        char[] symbols = Console.ReadLine().ToCharArray();
        int[] moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        char[] array = new char[moves.Length + 1];
        array[0] = symbols[0];
        symbols[0] = ' ';
        int currentPosition = 0;
        char[] symbolsTwo = new char[] { '@', '*', 'x' };
        int counterSouls = 0;
        int counterFood = 0;
        int counterDead = 0;
        for (int i = 1; i < moves.Length; i++)
        {
            if (moves[i - 1] >= 0)
            {
                array[i] = symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length];
                currentPosition = Array.IndexOf(symbols, symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length]);
                symbols[currentPosition] = ' ';
                if (currentPosition % 2 == 0 && symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length] == array[1])
                {
                    switch (symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length])
                    {
                        case '*': counterSouls--; continue;
                        default: continue;
                    }
                }
                else if (currentPosition % 2 != 0 && symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length] == array[1])
                {
                    switch (symbols[currentPosition + Math.Abs(moves[i - 1]) % symbols.Length])
                    {
                        case '*': counterFood--; continue;
                        default: continue;
                    }
                }
            }
            else
            {
                array[i] = symbols[((symbols.Length + currentPosition - Math.Abs(moves[i - 1])) % symbols.Length)];
                currentPosition = Array.IndexOf(symbols, symbols[Math.Abs(currentPosition - Math.Abs(moves[i - 1]) % symbols.Length)]);
                symbols[currentPosition] = ' ';
                if (currentPosition % 2 == 0 && symbols[((symbols.Length + currentPosition - Math.Abs(moves[i - 1])) % symbols.Length)] == array[1])
                {
                    switch (symbols[((symbols.Length + currentPosition - Math.Abs(moves[i - 1])) % symbols.Length)])
                    {
                        case '*': counterSouls--; continue;
                        default: continue;
                    }
                }
                else if (currentPosition % 2 != 0 && symbols[((symbols.Length + currentPosition - Math.Abs(moves[i - 1])) % symbols.Length)] == array[1])
                {
                    switch (symbols[((symbols.Length + currentPosition - Math.Abs(moves[i - 1])) % symbols.Length)])
                    {
                        case '*': counterFood--; continue;
                        default: continue;
                    }
                }
            }
        }
        if (array[1] != symbolsTwo[1] )
        {
            int zero = 0;
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case '@': counterSouls++; break;
                    case '*': counterDead++; break;
                    case 'x': counterFood++; continue;
                    case ' ': zero++; break;
                    default: break;
                }
            }
            int[] result = new int[3] { counterSouls, counterFood, counterDead };
            Console.WriteLine("Coder souls collected: {0}", result[0]);
            Console.WriteLine("Food collected: {0}", result[1]);
            Console.WriteLine("Deadlocks: {0}", result[2]);
        }
        else
        {
            Console.WriteLine("You are deadlocked, you greedy kitty!");
            Console.WriteLine("Jumps before deadlock: 0");
        }

    }
}