using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    internal class Mockup
    {
        /*

        */

        public void Test()
        {


        }

        public void Solution1()
        {

        }
    }

    class SolutionBinarySearchTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        public static void ImportData(TreeNode baseNode, int[] values)
        {
            foreach (var val in values)
            {
                AddNode(baseNode, val);
            }
        }

        //Applying with RECURSIVE
        public static void AddNode(TreeNode root, int val)
        {
            if (val < root.val)
            {
                if (root.left is null)
                {
                    root.left = new TreeNode(val);
                    return;
                }
                else
                {
                    AddNode(root.left, val);
                }
            }
            else
            {
                if (root.right is null)
                {
                    root.right = new TreeNode(val);
                    return;
                }
                else
                {
                    AddNode(root.right, val);
                }
            }
        }


        private void Traverse(TreeNode root)
        {
            if (root is null)
                return;

            Traverse(root.left);
            Console.WriteLine(root.val);
            Traverse(root.right);
        }

        private TreeNode Find(TreeNode node, int value)
        {
            if (node is not null)
            {
                if (node.val == value)
                {
                    return node;
                }

                if (node.val > value)
                {
                    Find(node.left, value);
                }
                else
                {
                    Find(node.right, value);

                }

            }

            return null;
        }


    }
}
