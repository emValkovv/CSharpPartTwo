using System;

    class MaikaTi
    {
        static void GetMax(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            int z = int.Parse(numbers[2]);
            GetMax(x, y, z);

        }
    }
