using System;

namespace TrimBinaryTree
{

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

    public class Solution
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root != null)
            {
                if (root.val > high) return TrimBST(root.left, low, high);
                if (root.val < low) return TrimBST(root.right, low, high);

                root.left = TrimBST(root.left, low, high);
                root.right = TrimBST(root.right, low, high);
            }
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode();
            var tree_1 = new TreeNode();
            var tree_2 = new TreeNode();
            var tree_3 = new TreeNode();
            var tree_4 = new TreeNode();

            tree_3.val = 1;

            tree_2.val = 2;
            tree_2.left = tree_1;

            tree_1.val = 0;
            tree_1.right = tree_2;

            tree_4.val = 4;

            tree.val = 3;
            tree.left = tree_1;
            tree.right = tree_4;

            var s = new Solution();
            s.TrimBST(tree, 1, 3);

            Console.WriteLine("Hello World!");
        }
    }
}
