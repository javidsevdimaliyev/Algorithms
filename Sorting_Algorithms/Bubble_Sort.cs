namespace Sorting_Algorithms
{
    //https://upload.wikimedia.org/wikipedia/commons/c/c8/Bubble-sort-example-300px.gif
    //Space Complexity: O(1)
    //Time Complexity: O(n^2)
    public class Bubble_Sort
    {
        public void Test()
        {
            int[] numbers = { 5, 2, 10, 7, 9, 1, 8, 6, 3, 4 };
            //string[] names = { "Cavid", "Parviz", "Vusal", "Camal", "Orxan" };

            BubbleSort(numbers);
            //BubbleSort(names);

            System.Console.WriteLine(string.Join(",", numbers));
            //System.Console.WriteLine(string.Join(",", names));

            System.Console.ReadKey();
        }


        void BubbleSort<T>(T[] array) where T : IComparable
        {
            int length = array.Length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i; j++)
                {
                    //if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0) 
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        //Also can write like this
                        // (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}
