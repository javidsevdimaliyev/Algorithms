using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    //https://makeagif.com/i/VrJ-Br

    //Space Complexity: O(1)
    //Time Complexity: O(n^2)
    public class Selection_Sort
    {
        public void Test()
        {
            int[] numbers = { 5, 2, 10, 7, 9, 1, 8, 6, 3, 4 };
            //string[] names = { "Cavid", "Parviz", "Vusal", "Asif", "Orxan" };

            SelectionSort(numbers);
            //SelectionSort(names);

            Console.WriteLine(string.Join(",", numbers));
            //System.Console.WriteLine(string.Join(",", names));

            Console.ReadKey();
        }


        void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
