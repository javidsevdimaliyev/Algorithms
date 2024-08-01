using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Problem4
    {
        /*
           Google interview
        Size verilen bir sayı dizisinde, her
        bir elemanın sağında olan ve
        ondan küçük elemanların sayısını
        gösteren bir dizi döndürün.
        Örn:
        Liste = [3, 4, 9, 6, 1]
        k=[1, 1,2,1, 0]
        3'ten sonra 3'ten küçük 1 eleman var (1)
        4'ten sonra 4'ten küçük 1 eleman var (1)
        9'dan sonra 9'dan küçük 2 eleman var (1, 6)
        ..
     
       */



        /*
                 3                   1
               /  \                   \
              1    4                   6      
                    \                 / \
                     9               4   9
                    /               /    
                   6               3   
         
         */


        internal class Node
        {
            public Node(int val)
            {
                Val = val;
            }
            public int Val { get; init; }
            public int DuplicateCount { get; set; } = 1;
            public int SmallThanThisNodeCount { get; set; }
           // public int TotalSmalls { get; set; }

            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
        }

        internal class NodeOperations
        {
            Node BaseNode { get; set; }
            public NodeOperations(Node node)
            {
                BaseNode = node;
            }

            public int[] ImportDataAndCalculate(int[] values)
            {
                int[] counts= new int[values.Length];
                for (int i = 1; i < values.Length; i++)
                {
                    int counter = 0;
                   
                    AddNode(BaseNode, values[i], ref counter);
                    counts[i] = counter;
                }

                return counts;
            }

            //Applying with RECURSIVE
            public void AddNode(Node rootNode, int val, ref int counter)
            {
                if (val < rootNode.Val)
                {
                    if (rootNode.LeftNode is null)
                    {
                        rootNode.LeftNode = new Node(val);
                        rootNode.SmallThanThisNodeCount = 1;
                        return;
                    }
                    else
                        AddNode(rootNode.LeftNode, val, ref counter);
                    
                }
                else if (val > rootNode.Val)
                {
                    if (rootNode.RightNode is null)
                    {
                        rootNode.RightNode = new Node(val);
                        counter += rootNode.DuplicateCount + rootNode.SmallThanThisNodeCount;
                        return;
                    }
                    else
                    {
                        counter+=rootNode.DuplicateCount + rootNode.SmallThanThisNodeCount;
                        AddNode(rootNode.RightNode, val, ref counter);
                    }
                }
                else
                {
                    rootNode.DuplicateCount++;
                }
            }
        }

        public void Test()
        {
            var numbers = new int[] {3, 4, 9, 6, 1,1 };
            //var numbers = new int[] { 40, 20, 30, 5, 7 };
            Console.Write("Given array:");
            foreach (var number in numbers)
                Console.Write($" {number}");

            Array.Reverse(numbers);
            var node = new Node(numbers[0]);
            NodeOperations op = new(node);
            var result= op.ImportDataAndCalculate(numbers);
            Array.Reverse(result);

           
            Console.Write("\nResult     :");
            foreach (var number in result)
                Console.Write($" {number}");

        }


    }
}
