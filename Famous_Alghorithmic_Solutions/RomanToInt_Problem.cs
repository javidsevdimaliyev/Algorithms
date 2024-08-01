using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class RomanToInt_Problem
    {
        public void Test()
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        public int RomanToInt(string s)
        {
            int res = 0;
            int prev = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L' , 50},
                {'X' , 10},
                {'V' , 5},
                {'I' , 1}
            };

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (prev <= dict[s[i]])
                {
                    res += dict[s[i]];
                }
                else if (prev > dict[s[i]])
                {
                    res -= dict[s[i]];
                }
                prev = dict[s[i]];
            }
            return res;
        }
    }
}
