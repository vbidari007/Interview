using System;
using System.Collections.Generic;

namespace HashTable
{
    public class FindDuplicateSubtree
    {
        /**
 * Definition for a binary tree node.
 */
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

        public class Solution
        {
            Dictionary<string, TreeNode> dic;
            public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
            {
                 dic = new Dictionary<string, TreeNode>();

                List<TreeNode> result = new List<TreeNode>();

                Helper(root);

                foreach (var item in dic.Values)
                {
                    if (item != null)
                        result.Add(item);
                }

                return result;
            }

            private string Helper(TreeNode root)
            {
                if (root == null)
                    return "#";

                string path = root.val + "|" + Helper(root.left) + "|" + Helper(root.right);
                if (dic.ContainsKey(path))
                    dic[path] = root;
                else
                    dic.Add(path, null);

                return path;
            }
        }
    }
}
