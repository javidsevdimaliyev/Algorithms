using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class Factorial_Problem
    {
        public void Test()
        {
            int factorial = 5;
            Console.WriteLine(Solution5(factorial));
        }

        long Solution1(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negativ reqemlerin faktoriyali yoxdur.");

            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        long Solution2(int n)
        {
            long result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        string Solution3(int n)
        {
            long result = 1;
            string visual = "";
            while (n > 0)
            {
                result *= n;

                if (n != 1)
                    visual += $"{n} x ";
                else
                    visual += $"{n} = {result}";

                n--;
            }

            return visual;
        }

        long Solution4(int n)
        {
            long result = 1;
            do
            {
                result *= n;
                n--;
                if (n == 0) break;
            } while (true);

            return result;
        }

        //With Recursion
        long Solution5(int n)
        {
            if (n > 1)
                return n * Solution5(--n);

            return n;
        }

    }
}
