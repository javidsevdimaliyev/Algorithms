using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class FizzBuzz_Problem
    {
        /*
            FizzBUZZ question

            1 ile 100 arasındaki sayılar için,
            3'e bölünürse "Fizz",
            5'e bölünürse "Buzz",
            15'e bölünürse "FizzBuzz"
            yazdıran bir kod yazın.
    
       */

        public void Test()
        {
            var dict = new Dictionary<int, string>()
            {
                [3] = "Fizz",
                [5] = "Buzz",
                [15] = "FizzBuzz"
            };

            #region Solution1

            for (int i = 1; i <= 100; i++)
            {
                string result = i.ToString();
                foreach (var key in dict.Keys)
                    if (i % key == 0)
                        result = dict[key];

                Console.WriteLine(result);
            }
            #endregion

            #region Solution2

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

        }
    }
}
