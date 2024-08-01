using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem1
    {
        /*
            Google interview

        Size bir sayi dizisi ve 'k' sayis
        veriliyor. Bu dizideki herhangi iki
        sayının toplamınin 'k' olup
        olmadığını bulan bir program
        yazinız.
        Bonus: Bunu diziyi bir defa
        gezerek yapabilir misiniz? (O(n)
        Örn:
        Liste = [10, 15, 3, 7]
        k= 17
        10 ve 7 sayilarinin toplamı 17 ediyor.
         */

        public void Test()
        {
            Console.WriteLine(Solve(17, new int[] { 10, 15, 3, 7 }));
        }
        public bool Solve(int k, int[] array)
        {
            /*
             Solution viuality
             [10, 15, 3, 7] Sort => [3, 7, 10, 15]

             [3], 7, 10, [15]=> 3 + 15 = 18  if 18>k j--
              
             [3], 7, [10], 15=> 3 + 10 = 13  if 13<k i++
               
             3, [7], [10], 15=> 7 + 10 = 17
         
             */
            Array.Sort(array);
            int i = 0, j = array.Length - 1;

            while (i != j)
            {
                var total = array[i] + array[j];
                if (total == k)
                    return true;

                if (total > k)
                    j--;

                if (total < k)
                    i++;
            }

            return false;

        }
    }
}
