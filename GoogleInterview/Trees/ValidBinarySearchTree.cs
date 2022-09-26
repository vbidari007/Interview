using System;
namespace Trees
{
    public class ValidBinarySearchTree
    {
        public bool checkBST(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null)
                return true;
            if (root.right == null)
                return true;
            if (root.val < root.left.val)
                return false;
            if (root.val > root.right.val)
                return false;
            return checkBST(root.left)&&checkBST(root.right);
        }
    }
}
