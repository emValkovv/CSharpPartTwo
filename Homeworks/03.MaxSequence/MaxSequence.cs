﻿using System;
using System.Linq;

public class SequenceInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] rowsAndColsArray = input.Split(' ').Select(n => int.Parse(n)).ToArray();
        int rows = rowsAndColsArray[0];
        int cols = rowsAndColsArray[1];
        //int rows = 5;
        //int cols = 5;
        string[,] inputArray = new string[rows, cols];

        // int[,] inputArray = {
        //0  1  2  3  4
        //{1, 3, 3, 5, 5},
        //{1, 1, 4, 5, 6},
        //{2, 2, 1, 3, 5},
        //{4, 2, 4, 1, 6},
        //{1, 2, 3, 5, 1}
        //};

        //Initiating Array
        for (int row = 0; row < rows; row++)
        {
            var colArray = Console.ReadLine().Split(' ').ToArray();

            for (int col = 0; col < cols; col++)
            {
                inputArray[row, col] = colArray[col];
            }
        }

        // Task Solution

        int maxSequence = 1;
        int currentSequence = 1;
        #region
        // row sequence check
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (inputArray[row, col] == inputArray[row, col + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }
        }
        currentSequence = 1;
        // col sequence check
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (inputArray[row, col] == inputArray[row + 1, col])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }
        }
        #endregion
        Console.WriteLine(maxSequence);
    }
}