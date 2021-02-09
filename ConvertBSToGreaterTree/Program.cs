using System;

namespace ConvertBSToGreaterTree
{
    
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }

public class Solution {
    private  int sum = 0;
        public TreeNode ConvertBST(TreeNode root) {

          if (root != null){
              ConvertBST(root.right);
              sum += root.val;
              root.val = sum;
              ConvertBST(root.left);
          }

          return root;
        }

    public void Print(TreeNode tree){
        if (tree != null){
            Console.WriteLine(tree.val);
            Print(tree.left);
            Print(tree.right);
            
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode();
            tree.val = 8;

            var tree1 = new TreeNode();
            tree1.val = 7;
            tree1.right = tree;

            var tree2 = new TreeNode();
            tree2.val = 5;

            var tree3 = new TreeNode();
            tree3.val = 6;
            tree3.left = tree1;
            tree3.right = tree2;

            var tree4 = new TreeNode();
            tree4.val = 3;

            var tree5 = new TreeNode();
            tree5.val = 2;
            tree5.left = tree4;

            var tree6 = new TreeNode();
            tree6.val = 0;
     
            var tree7 = new TreeNode();
            tree7.val = 1;
            tree7.left = tree6;
            tree6.right = tree5;

            var tree8 = new TreeNode();
            tree8.val = 4;
            tree.left = tree7;
            tree8.right = tree3;

            var s = new Solution();
            s.Print(tree8);
            //s.ConvertBST(tree8);


            Console.WriteLine("Hello World!");
        }
    }
}
