using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string[] gagDigits = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
            string gagNumber = Console.ReadLine();

            List<byte> decDigits = new List<byte>();
            StringBuilder gagDigit = new StringBuilder();

            for (int i = 0; i < gagNumber.Length; i++)
            {
                gagDigit.Append(gagNumber[i]);
                for (byte j = 0; j < gagDigits.Length; j++)
                {
                    if (gagDigit.ToString() == gagDigits[j])
                    {
                        decDigits.Add(j);
                        gagDigit.Clear();
                    }
                }
            }

            ulong decNumber = 0;
            for (int i = 0; i < decDigits.Count; i++)
            {
                decNumber = decNumber * 7 + (ulong)decDigits[i];
            }

            Console.Write(decNumber);
            Console.WriteLine();

            //using System;

            //class NineGagNumber
            //{
            //static string[] digits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

            //static void Main()
            //{
            //    string number = Console.ReadLine();
            //    ulong result = 0;

            //    while (number.Length > 0)
            //    {
            //        for (int i = 0; i < digits.Length; i++)
            //        {
            //            if(number.StartsWith(digits[i]))
            //            {
            //                number = number.Remove(0, digits[i].Length);
            //                result = result * 9 + (ulong)i;
            //            }
            //        }
            //    }

            //    Console.WriteLine(result);
            //}
            //}
        }
    }
