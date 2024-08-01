using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem3
    {
        /*

             Twitter(X) interview

        Bir e-ticaret siteniz var ve
        buradan yapılan son N siparişin
        numaralarının kaydını tutmak
        istiyorsunuz. Şu işlemleri yapacak
        bir veri yapisı yaziniz:
        kaydet(siparis_id)
        sondan(i) -> kaydedilmis siparişler
        arasinda sondan i. elemani
        döndürür. (i<=N)
        Yapı， zaman ve boyut açısından
        olabildigince etkili (efficient) olmalidir.

        N =5 (Son 5 siparişi tutacak)
        Siparişler: 1402, 1330, 4050, 1402, 4060

        Add(4080) -> 4080, 1330, 4050, 1402, 4060 
        
         */


        public void Test()
        {
            ProductOrderQueue order = new(5);
            var numbers = order.Solution1(new int[] { 1, 2, 3, 4, 5 });
            order.Add(7);


            foreach (var number in numbers)
                Console.Write(number);

            Console.WriteLine();
        }

        class ProductOrderQueue
        {
            private int n;
            int currentPosition;
            private int[] result;
            public ProductOrderQueue(int dimention)
            {
                result = new int[dimention];
                n = dimention;
            }
            public int[] Solution1(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i % n] = array[i];
                    currentPosition++;
                }

                return result;
            }

            public void Add(int number)
            {
                result[currentPosition % n] = number;
            }
        }

    }
}
