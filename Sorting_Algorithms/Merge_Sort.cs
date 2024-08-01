using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    //Divide and conquer

    //Space Complexity: O(n)

    //Time Complexity:
    //Best Case  O(n * log n)
    //Avg Case   O(n * log n)
    //Worst Case O(n * log n)
    public class Merge_Sort
    {
        void Mergesort<T>(T[] array, int left, int right)
            where T : IComparable
        {
            // 1, 2, 5, 8, 2, 60, 76
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Mergesort(array, left, middle);
                Mergesort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        void Merge<T>(T[] array, int middle, int left, int right)
            where T : IComparable
        {
            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;

            T[] leftArray = new T[leftArrayLength];
            T[] rightArray = new T[rightArrayLength];

            Array.Copy(array, left, leftArray, 0, leftArrayLength);
            Array.Copy(array, middle + 1, rightArray, 0, rightArrayLength);

            int leftIndex = 0, rightIndex = 0;
            int k = left;

            while (leftIndex < leftArrayLength && rightIndex < rightArrayLength)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }

                k++;
            }

            while (leftIndex < leftArrayLength)
            {
                array[k] = leftArray[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < rightArrayLength)
            {
                array[k] = rightArray[rightIndex];
                rightIndex++;
                k++;
            }
        }



    }
}
