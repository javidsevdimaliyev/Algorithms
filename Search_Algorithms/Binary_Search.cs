using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Search_Alghorithms
{
    internal class Binary_Search
    {
        public void Test()
        {
            var res = BinarySearch(new int[] { 5, 12, 36, 43, 53, 58, 72, 84, 91 }, 72);
            Console.WriteLine(res);
        }

        int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else if (key > inputArray[mid])
                {
                    min = mid + 1;
                }
                else
                    return mid;
            }
            return min;
        }

        int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

    }
}
