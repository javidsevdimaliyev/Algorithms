using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem6
    {
        /*
          Girilen pozitif sayının kaç basamaklı
          olduğunu söyleyen uygulamayı
          yazınız?
        */

        public void Test()
        {
            Console.WriteLine("Enter number.");
            float number = float.Parse(Console.ReadLine());

            Console.WriteLine(Solution1(number));

        }

        public int Solution1(float number)
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

        public int Solution2(float number)
        {
            number /= 10;
            if (number > 10)
                return 1+Solution2(number);

            return 2;
        }
    }
}
