using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    internal class BinaryTree_Traversal_Problem
    {
        public void Test()
        {
            var list1 = new TreeNode();

            ImportData(list1, new int[] { 1, 2, 3 });

            var list = InorderTraversal(list1);
            Console.WriteLine(string.Join(",", list.ToArray()));
        }

        static IList<int> list = new List<int>();
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root is null)
                return new List<int>(); ;

            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);

            return list;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static void ImportData(TreeNode rootNode, int[] values)
        {
            rootNode.val = values[0];
            for (int i = 1; i < values.Length; i++)
                AddNode(rootNode, values[i]);

        }

        //Applying with RECURSIVE
        public static void AddNode(TreeNode rootNode, int val)
        {
            if (val < rootNode.val)
            {
                if (rootNode.left is null)
                {
                    rootNode.left = new TreeNode(val);
                    return;
                }
                else
                {
                    AddNode(rootNode.left, val);
                }
            }
            else
            {
                if (rootNode.right is null)
                {
                    rootNode.right = new TreeNode(val);
                    return;
                }
                else
                {
                    AddNode(rootNode.right, val);
                }
            }
        }
    }
}
