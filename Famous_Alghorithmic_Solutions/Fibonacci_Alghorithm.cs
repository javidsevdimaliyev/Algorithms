using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class Fibonacci_Alghorithm
    {
        public void Test()
        {
            Fibonacci(2);
            //Console.WriteLine();
            //Console.WriteLine(FibonacciRecursive(8));
        }

        void Fibonacci(int n)
        {
            int a = 0, b = 1, currenttotal = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i <= n; i++)
            {
                currenttotal = a + b;
                Console.Write(" {0}", currenttotal);
                a = b;
                b = currenttotal;
            }

        }

        //Fibonacci Recursive
        int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }

   
}

