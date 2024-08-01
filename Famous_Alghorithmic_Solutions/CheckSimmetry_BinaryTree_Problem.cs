using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    public class CheckSimmetry_BinaryTree_Problem
    {
        public void Test()
        {
            var node = new TreeNode();

            node.left = new TreeNode(2);
            node.left.left = new TreeNode(3);
            node.left.right = new TreeNode(5);

            node.right = new TreeNode(2);
            node.right.left = new TreeNode(4);
            node.right.right = new TreeNode(3);

            Console.WriteLine(IsSymmetric(node));
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return Dfs(root.left, root.right);
        }

        static bool Dfs(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null)
                return true;

            if (root1?.val != root2?.val)
                return false;

            return Dfs(root1?.left, root2?.right) &&
                   Dfs(root1?.right, root2?.left);
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
    }
}
