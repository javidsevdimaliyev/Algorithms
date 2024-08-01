using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    //https://upload.wikimedia.org/wikipedia/commons/9/9c/Insertion-sort-example.gif?20110309111239
    //https://www.youtube.com/watch?v=EdIKIf9mHk0&ab_channel=megaovermoc

    //Space Complexity: O(1)
    //Time Complexity: O(n^2)
    public class Insertion_Sort
    {
        public void Test()
        {
            int[] numbers = { 5, 2, 10, 7, 9, 1, 8, 6, 3, 4 };
            //string[] names = { "Cavid", "Parviz", "Vusal", "Asif", "Orxan" };

            InsertionSort(numbers);
            //InsertionSort(names);

            Console.WriteLine(string.Join(",", numbers));
            //System.Console.WriteLine(string.Join(",", names));

            Console.ReadKey();
        }

        void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;

            }
        }
    }
}
