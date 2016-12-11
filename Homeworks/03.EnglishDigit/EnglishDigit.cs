using System;

class EnglishDigit
{
    static void EnglishWord(int number)
    {
        string[] words = new string[10] {
                                            "zero",
                                            "one",
                                            "two",
                                            "three",
                                            "four",
                                            "five",
                                            "six",
                                            "seven",
                                            "eight",
                                            "nine"
                                        };
        for (int i = 1; i < words.Length; i++)
        {

            if (i / number == 1)
            {
                Console.WriteLine(words[i]);
                break;
            }
            else
            {
                continue;
            }
        }
    }

    static void Main()
    {
        int read = int.Parse(Console.ReadLine());
        if (read % 10 != 0)
        {
            int number = read % 10;
            EnglishWord(number);
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}
