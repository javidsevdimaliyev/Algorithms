using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem7
    {
        /*
        Girilen 3 basamaklı bir sayının
        basamaklarının küpleri toplamı
        sayının kendine eşit olup olmadığını
        bulan uygulamayı yazınız?
       */

        public void Test()
        {
            Console.WriteLine("Enter 3 digit number.");
            int number = int.Parse(Console.ReadLine());

            while (DetectDigitCount(number) != 3)
            {
                Console.WriteLine("Please enter only 3 digit number.");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Solution1(number));

        }

        public int DetectDigitCount(int number)
        {
            int counter = 0;
            while (number > 10)
            {
                number /= 10;
                counter++;
            }

            counter++;
            return counter;
        }

        public bool Solution1(int number)
        {
            var num1 = number / 100;
            var num2 = (number / 10) % 10;
            var num3 = number % 10;
            var totalsquare = Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3,3);

            if (totalsquare == number)
                return true;

            return false;
        }

        public bool Solution2(float number)
        {
            return false;
        }
    }
}
