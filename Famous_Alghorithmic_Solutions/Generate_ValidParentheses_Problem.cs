using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithm.Console.Solutions_of_Alghorithmic_problems
{
    public class Generate_ValidParentheses_Problem
    {
        private char[] arr = new[] { '(', ')' };
        public void Test()
        {
            do
            {
                for (int i = 1; i < 20; i++)
                {
                    var generated = GenereateValidParantheses(10);
                    System.Console.WriteLine($"{i:00}--> {generated}");
                }

            } while (System.Console.ReadKey().Key == ConsoleKey.Enter);
        }

        string GenereateValidParantheses(int length = 4)
        {
            if (length < 2)
                return string.Empty;

            if (length % 2 != 0)
                length++;
            var sb = new StringBuilder(capacity: length);
            GenereateParantheses(length, 0, 0, sb);
            return sb.ToString();
        }

        void GenereateParantheses(int length, int openCount, int closeCount, StringBuilder sb)
        {

            int max = length / 2;
            int arrIndex = 0;

            if (openCount <= closeCount)
                arrIndex = 0; //Open
            else
            {
                if (openCount == max && closeCount < max)
                    arrIndex = 1; //Close
                else
                    arrIndex = Random.Shared.Next(maxValue: 2);
            }


            var p = arr[arrIndex];
            sb.Append(p);

            if (arrIndex == 0)
                openCount++;
            else
                closeCount++;

            if (openCount + closeCount >= length)
                return;

            GenereateParantheses(length, openCount, closeCount, sb);

        }


    }
}
