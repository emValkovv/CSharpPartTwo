using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[][] kot = new string[n][];
            for (int i = 0; i < kot.Length; i++)
			{
			    kot[i] = Console.ReadLine().Split(' ');
			}
            for (int i = 0; i < kot.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < kot[i].Length; j++)
                {
                    System.Console.Write(String.Join(",", kot[i][j]));
                }
                System.Console.WriteLine();
            }



        }
    }
