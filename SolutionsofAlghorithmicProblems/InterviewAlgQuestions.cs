using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    /*
        1) write a function to print numbers till n
        2) function that checks is perfect number(orda tesvir edir nedi perfect number)
        3) filan qədər byte-ı megabyte-a çevir
        4) difference between Where and Having
        5) function that reverses number
        6) function to calculate factorial
        7) find min max in array
        8) fizzbuzz
        9) find a prime dividors of number
       10) find 2D matrix diagonal elements
    */
    internal class InterviewAlgQuestions
    {
        public void Test()
        {
            //Problem1Solution(5);
            //Problem2Solution(6);
            //Problem3Solution(365);
            //Problem5Solution(12456);
            //Problem6Solution();
            //Console.WriteLine(Problem6SolutionWithRecursion(6));
            //Problem7Solution(new int[] { 3, 5, 6, 2, 54, 67, 2 });
            Problem9Solution(62);
        }

        void Problem1Solution(int n)
        {
            #region Solution1
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
            }
            #endregion

            #region Solution2
            while (n > 0)
            {
                Console.Write(n--);
            }
            #endregion

        }

        void Problem2Solution(int number)
        {
            int sum = 0;
            #region Solution1

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            if (sum == number)
                Console.WriteLine($"yes {number} is a perfect number");
            else
                Console.WriteLine($"no {number} is not a perfect number"); ;

            #endregion

        }

        void Problem3Solution(int number)
        {
            //1 kilobyte is 1024 byte
            //1 megabyte is 1024 kilobyte
            //so
            //1 megabyte is 1024 * 1024 = 1048576 byte

            double divisor = 1024 * 1024; //megabyte;

            double result = number / divisor;

            Console.WriteLine("Result: " + result);
        }

        void Problem5Solution(int num)
        {
            int reverse = 0;
            #region Solution1
            while (num != 0)
            {
                reverse *= 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
            #endregion

            #region Solution2

            //string rev = "";
            //string number = num.ToString();
            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    rev += number[i];
            //}
            //Console.WriteLine("Reverse of Entered Number is : " + rev);
            //Console.ReadLine();
            #endregion

        }

        void Problem6Solution()
        {
            long result = 1;
            Console.WriteLine("Enter  number.");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Negativ reqemlerin faktoriyali yoxdur.");
                n = int.Parse(Console.ReadLine());
            }
            #region Solution1

            if (n == 0 || n == 1)
                Console.WriteLine(1);

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);

            #endregion

            #region Solution2
            result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
            #endregion

        }

        long Problem6SolutionWithRecursion(int n)
        {
            if (n > 1)
                return n * Problem6SolutionWithRecursion(--n);

            return n;
        }

        void Problem7Solution(int[] array)
        {
            #region Solution1

            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];

                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine($"Arrayin min deyeri: {min} ve max deyeri: {max}");
            #endregion

        }

        void Problem8Solution()
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

        void Problem9Solution(int number)
        {
            var list = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0 && IsPrime(i))
                {
                    list.Add(i);
                }
            }
            #region Solution1

            bool IsPrime(int divisor)
            {
                if (divisor <= 1)
                    return false;

                for (int i = 2; i < divisor; i++)
                {
                    if (divisor % i == 0)
                        return false;
                }
                return true;
            }

            #endregion

            #region Solution2
            bool IsPrimeChecker2(int divisor)
            {
                if (divisor <= 1 || divisor % 2 == 0)
                    return false;

                for (int i = 3; i < Math.Sqrt(divisor) + 1; i+=2)
                {
                    if (divisor % i == 0)
                        return false;
                }
                return true;
            }
            #endregion

            Console.WriteLine(string.Join(",",list.ToArray()));
            
          

          
        }

        void Problem10Solution()
        {
            int[,] matrix = new int[10, 10]
            {
                {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
                {31, 32, 33, 34, 35, 36, 37, 38, 39, 40},
                {41, 42, 43, 44, 45, 46, 47, 48, 49, 50},
                {51, 52, 53, 54, 55, 56, 57, 58, 59, 60},
                {61, 62, 63, 64, 65, 66, 67, 68, 69, 70},
                {71, 72, 73, 74, 75, 76, 77, 78, 79, 80},
                {81, 82, 83, 84, 85, 86, 87, 88, 89, 90},
                {91, 92, 93, 94, 95, 96, 97, 98, 99, 100},
                {101, 102, 103, 104, 105, 106, 107, 108, 109, 110}
            };

          
            for (int i = 0; i < 10; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
        }


    }
}
