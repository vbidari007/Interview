using System;
using System.Collections.Generic;

namespace StacksQueues
{
    /**
 * Definition for a binary tree node.
 * */

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
 
    public class BinaryTreeInorder
    {
        IList<int> res = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return res;

            if(root.left!=null)
                InorderTraversal(root.left);
            res.Add(root.val);
            if(root.right!=null)
                InorderTraversal(root.right);

            return res;
        }
    }
}
