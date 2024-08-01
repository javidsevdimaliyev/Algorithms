using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    public class Problem5
    {
        /*
            Pozitif sayılarda çarpma işlemin
            toplama kullanarak bulan
            uygulamayı yazınız?
       */

        public void Test()
        {
            Console.WriteLine("Enter number.");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter division number.");
            int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Solution1(new []{2,3,4}));
            Console.WriteLine(Solution5(number1,number2));

        }

        public int Solution1(int number1, int number2)
        {
            var result = 0;
            for (int i = 0; i < number1; i++)
            {
                result += number2;
            }

            return result;
        }

        public int Solution2(int number1, int number2)
        {
            var counter = number2;
            var result = 0;
            while (counter>0)
            {
                result += number2;
                counter--;
            }

            return result;
        }

        //With recursive
        public int Solution3(int number1, int number2)
        {
            if (number2 > 0)
                return number1 + Solution3(number1, --number2);
              
            return number1;
        }

        /*
            Pozitif sayılarda bolme işlemin
            cikarma kullanarak bulan
            uygulamayı yazınız?
       */
        public int Solution5(int number1, int number2)
        {
            var counter = 0;
            var until = number1;
            for (int i = 0; i < until; i++)
            {
                if (number1 <= 0)
                    break;

                number1 -= number2;
                counter++;
            }

            return counter;
        }

        public int Solution6(int number1, int number2)
        {
            number1-=number2;
            if (number1 >= number2)
                return 1 + Solution6(number1, number2);
            return number1;
        }
    }
}
