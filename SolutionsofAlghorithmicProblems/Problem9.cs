using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem9
    {
        /*
        Ədədin birinci və axrıncı rəqəmlərinin yerini dəyişmə alqoritmi
        Ədəd:  123456
        Nəticə: 623451
      */

        public void Test()
        {
            Console.WriteLine("Enter number.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution1(number));
        }

        public int Solution1(int number)
        {
            int n=number;
            int mod = 0;
            int result = 0;
            int decimals = 1;
            int first = 0;
            int last = number % 10;

            while (n > 0)
            {
                if (n / 10 == 0)
                    first = n;
                n/= 10;
            }

            n = number;
            while (n>0)
            {
                mod = n % 10;
                n /= 10;

                if(mod==last)
                    mod=first;
                else if (mod == first)
                    mod = last;

                result = result + mod * decimals;
                decimals *= 10;

            }

            return result;
        }
    }
}
