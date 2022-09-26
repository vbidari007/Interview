using System;
namespace Trees
{
    /**
 * Definition for a binary tree node.
 **/
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
 
    public class CheckSameTree
    {
        
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var ptr1 = p;
            var ptr2 = q;
            if (ptr1 == null && ptr2 == null)
                return true;
            if (ptr1 == null) return false;
            if (ptr2 == null) return false;
            if (ptr1.val != ptr2.val) return false;
            
            return (IsSameTree(ptr1.left, ptr2.left) && (IsSameTree(ptr1.right, ptr2.right)));

        }
    }
}
