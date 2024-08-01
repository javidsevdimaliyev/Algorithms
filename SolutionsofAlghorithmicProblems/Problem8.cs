using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem8
    {
        /*
        Hər hansı x ədədindən n1, n2... rəqəmlərinin çıxarılması 
        Nümunə:
        Ədəd:123456
        Çıxarılsın: 2 və 6
        Nəticə: 1346

       */

        public void Test()
        {
            Console.WriteLine(Solution1(123456,new int[]{2,5}));
        }

        public int Solution1(int number, int[] extractnumbers)
        {
            int mod = 0;
            int result = 0;
            int decimals = 1;
            while (number>0)
            {
                mod = number % 10;
                number /= 10;

                if (!extractnumbers.Contains(mod))
                {
                    result = result + mod * decimals;
                    decimals *= 10;
                }
                
            }

            return result;
        }
    }
}
