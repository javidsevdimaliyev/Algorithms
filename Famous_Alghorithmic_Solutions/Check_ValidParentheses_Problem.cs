using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class Check_ValidParentheses_Problem
    {
        public void Test()
        {
            Console.WriteLine(IsValid("(){]"));
            Console.WriteLine(IsValid("{[()]}"));
        }

        public static bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>{
                {'{',  '}'},
                {'(',  ')'},
                {'[',  ']'},
            };
            Stack<char> openBrackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (dict.ContainsKey(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0)
                    {
                        return false;
                    }
                    if (dict[openBrackets.Pop()] == bracket)
                    {
                        continue;
                    };
                    return false;
                }
            }
            return openBrackets.Count == 0;
        }
    }
}
