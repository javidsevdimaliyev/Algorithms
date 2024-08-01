using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class PlusOne_Problem
    {
        public void Test()
        {
            Console.WriteLine(string.Join(",", PlusOne(new int[] { 8, 9, 9 })));
        }

        public static int[] PlusOne(int[] digits)
        {
            var lastIndex = digits.Length - 1;
            if (digits[lastIndex] < 9)
            {
                digits[lastIndex] += 1;
                return digits;
            }

            while (lastIndex >= 0 && digits[lastIndex] + 1 == 10)
            {
                digits[lastIndex] = 0;

                lastIndex--;
            }

            if (lastIndex >= 0)
            {
                digits[lastIndex] += 1;
                return digits;
            }
            else
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digits.Length);
                return result;
            }

        }
    }
}
