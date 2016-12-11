using System;

public class IndexOfLetters
{
    static void Main()
    {
        char[] lettersArray = new char[26];

        for (int i = 0; i < lettersArray.Length; i++)
        {
            lettersArray[i] = (char)(i + 97);
        }

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < lettersArray.Length; j++)
            {
                if (word[i] == lettersArray[j])
                {
                    Console.WriteLine(j);
                    break;
                }
            }
        }
    }
}