using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem2
    {
        /*
             Uber interview

        Size bir sayi dizisi veriliyor. Bu
        dizideki her elemanin yerinde, o
        eleman harici tüm elemanlarin
        çarpımını içeren bir dizi döndürün.
        Bonus: Bunu bölme islemi
        yapmadan nasıl yaparsınız?
        Orn:
        Om:
        List = [1,2,3,4,5]
        Result =[120. 60, 40. 30. 24)

        List = [3, 2. 1]     
        Result =[2. 3, 6)
         */

        public void Test()
        {
            var numbers = Solution1(new int[] { 1, 2, 3, 4, 5 });
            var numbers2 = Solution2(new int[] { 1, 2, 3, 4, 5 });
            foreach (var number in numbers)
                Console.Write(number);

            Console.WriteLine();

            foreach (var number in numbers2)
                Console.Write(number);

        }

        public int[] Solution1(int[] array)
        {
            int[] result = new int[array.Length];
            var total = 1;
            foreach (var number in array)
            {
                total *= number;
            }

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = total / array[i];
            }

            return result;
        }
        public int[] Solution2(int[] array)
        {
            /*
             Solution viuality
             1) 1*2*3*4*5=120
                120/1=120;
                120/2=60;
                120/3=40;
                120/4=30;
                120/5=24;

            2) 

             */
            int[] result= new int[array.Length];
           
           
            for (int i = 0; i < array.Length; i++)
            {
                int total = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i!=j)
                     total *= array[j];
                }

                result[i] = total;
            }

            return result;
        }
    }
}
