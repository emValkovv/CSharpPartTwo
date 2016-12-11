using System;

    class AppearanceCount
    {
        static void CountAppearance(int lookingNumber, int[] numbersArray)
        {
            int counter = 0;
            int notCounter = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] / lookingNumber == 1 && numbersArray[i] % lookingNumber == 0)
                {
                    counter++;
                }
                else
                {
                    notCounter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int lookingNumber = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbersArray[i] = int.Parse(array[i]);    
            }
            CountAppearance(lookingNumber, numbersArray);
        }
    }
