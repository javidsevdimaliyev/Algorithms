using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    //Divide and conquer

    //Pivot and Partition level
    //Partition methods : Hoare and Lomuto methods

    //Space Complexity: O(1)
    //Time Complexity
    //Best Case  O(n * log n)
    //Avg Case   O(n * log n)
    //Worst Case O(n^2)


    #region Hoare method
    /*

     Hoare method visual explaination

   1)   [4], 1, 7, 2    - pivot always will be first member
     i-1            j+1 - i looking for greater than pivot, j looking for smaller than pivot

   2)   [4], 1, 7, 2   
         i         j    - i=4 and not greater than pivot(4) but j[3] or 2 is smaller than pivot and we have to swap i and j values

   3)    2, 1, 7, [4] 
         i         j

   4)    2, 1, 7, [4]   - i[0] or 2 > pivot(4)(false), i[1] or 1 > pivot(4)(false), i[2] or 7 > pivot(4) (true)
         i         j

   5)    2, 1, 7, [4]   - j[2] or 7<pivot(4)(false), j[1] or 1<pivot(4)(true)
               i   j

   6)    2, 1, 7, [4]   - in this case we swap i value with pivot value and 7
            j  i 

   7)    2, 1, [4], 7   - if j crosses the border of i the procedure begins from start. Partition is j or 1
            j   i         
 -------------------------------------------------------------------------------------------------------------------------------   
        let's divide 2 side left of partition and right of partition

      Left side

   8)   [2], 1,| 7, 4   - So now our pivot is first element 2 
      i-1       j+1    

   9)   [2], 1,| 7, 4   - i[0] or 2 > pivot(2)(false) but j[1] or 1 < pivot(2)(true)
         i   j         

   10)  [2], 1,| 7, 4   - and we have to swap i and j  =>    1, [2], 4, 7
         i   j                                              i   j   
     
     Right side

   11)   1, 2,| [7], 4   - So now our pivot is 7
            i         j+1

   12)   1, 2,| [7], 4   - i[0] or 7 > pivot(7)(false) but j[3] or 4 < pivot(7)(true)
                 i   j  

   13)   1, 2,| [7], 4   - and we have to swap i and j  =>   1,  2, [4], 7
                 i   j                                               i   j     
  */
    #endregion

    #region Lomuto method
    /*
    Lomuto method visual explaination

    1)     4, 1, 7, [2]   - pivot always will be last member and j looking for smaller than pivot
      i-1  j              - i save last changes, j <= pivot then we have to swap i and j values

    2)     4, 1, 7, [2]  
      i-1  j              - j=4 and not smaller than pivot(2) and change j to next

    3)      4, 1, 7, [2]  - now j is smaller than pivot (1<=pivot(2)) and we have to swap i and j values (swap operation)
            i  j            P.S : for swap operation i increases

    4)      1, 4, 7, [2]  - let's continue =>  1, 4, 7, [2]  j is not smaller than pivot (7<=pivot(2)) =>  1, 4, 7, [2]
            i  j                               i     j                                                     i         j

    5)      1, 4, 7, [2]  - if j equals to pivot then we swap j value with i+1 value (this is the rule of method) Partition is i+1 or 2
            i         j

    6)      1, 2, 7, 4  - Now we divide array to pivot left side and pivot right side => first array: 1 / second array:   7, 4
            i        j                                                                                                i-1 j   

    7)      1,2,| 7, [4]     - j=7 and not smaller than pivot(2) and change j to next =>    7, [4] and applying 5th section rule again
             i-1  j                                                                      i-1    j

    8)      1,2,| 7, [4] =>   [4], 7  => Result: 1, [2], 4, 7 
                  i   j        i   j             i          j 

    */
    #endregion


    public class Quick_Sort
    {
        public void Test()
        {
            //int[] intArrayHoare = new[] { 4, 1, 7, 2 };
            int[] intArrayLomuto = new[] { 4, 1, 7, 2 };

            // QuickSortHoare(intArrayHoare, 0, intArrayHoare.Length - 1);
            QuickSortLomuto(intArrayLomuto, 0, intArrayLomuto.Length - 1);

            //Console.WriteLine(string.Join(',', intArrayHoare));
            Console.WriteLine(string.Join(',', intArrayLomuto));
            Console.ReadLine();
        }
        void QuickSortHoare<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                var partitionIndex = PartitionHoare(array, low, high); //n-defe calisir

                QuickSortHoare(array, low, partitionIndex); // log n - defe calisir
                QuickSortHoare(array, partitionIndex + 1, high); // log n - defe calisir

            }

            int PartitionHoare<T>(T[] array, int low, int high)
               where T : IComparable
            {
                var pivot = array[low];
                int i = low - 1, j = high + 1;
                while (true)
                {
                    do
                    {
                        i++;
                    } while (array[i].CompareTo(pivot) < 0);

                    do
                    {
                        j--;
                    } while (array[j].CompareTo(pivot) > 0);

                    if (i >= j)
                        return j;

                    Swap(array, i, j);
                }
            }


        }

        void QuickSortLomuto<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                var partitionIndex = PartitionLomuto(array, low, high);

                QuickSortLomuto(array, low, partitionIndex - 1);
                QuickSortLomuto(array, partitionIndex + 1, high);

            }

            int PartitionLomuto<T>(T[] array, int low, int high)
                where T : IComparable
            {
                var pivot = array[high];
                int i = low - 1;
                for (int j = low; j < high; j++)
                {
                    if (array[j].CompareTo(pivot) < 0)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                Swap(array, i + 1, high);
                return i + 1;
            }
        }

        void Swap<T>(T[] array, int i, int j)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}
