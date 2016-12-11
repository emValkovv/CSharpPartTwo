using System;

    class FillMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char method = char.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int number = 1;
            int[,] array = new int[rows, cols];
            switch (method)
            {
                case 'a':
                    for (int row  = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            array[row, col] = number + col;
                        }
                        number += n;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(" " + array[i ,j]);
                        }
                        Console.WriteLine();
                    }

                    break;
                case 'b':
                    break;
                case 'c':
                    break;
                case 'd':
                    break;
            }
        }
    }
