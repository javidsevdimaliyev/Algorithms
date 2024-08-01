using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class Palindrome_Problem
    {
        public void Test()
        {
            int number = 123321;
            Console.WriteLine(IsPalindrome(number));
        }

        //Solution for int
        public static bool IsPalindrome(int number)
        {
            if (number < 0) { return false; }
            int originalNumber = number;
            int reversedNumber = 0;

            // Reverse operation
            while (number != 0)
            {
                reversedNumber *= 10;
                reversedNumber += number % 10;
                number /= 10;
            }

            //or

            //while (number > 0)
            //{
            //    int remainder = number % 10;
            //    reversedNumber = (reversedNumber * 10) + remainder;
            //    number /= 10;
            //}

            //Check Original and reversed
            return originalNumber == reversedNumber;
        }

        public static bool IsPalindrome(string str)
        {
            // Ignore non-alphanumeric characters
            string cleanedStr = new string(str.ToLower().ToCharArray()
                .Where(c => char.IsLetterOrDigit(c))
                .ToArray());

            int length = cleanedStr.Length-1;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanedStr[i] != cleanedStr[length - i])
                    return false;
            }

            return true;
        }

       
    }

}