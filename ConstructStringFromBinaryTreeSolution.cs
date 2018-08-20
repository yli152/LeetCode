using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Definition for a binary tree node.
    /*
     * public class TreeNode{
     *      public int val;
     *      public TreeNode left;
     *      public TreeNode right'
     *      public TreeNode(int x) {val = x;}
     * }
     */
    public class ConstructStringFromBinaryTreeSolution
    {
        //分情况讨论
        public string Tree2str(TreeNode t)
        {
            if (t == null) {
                return "";
            }
            if (t.left == null && t.right == null)
            {
                return t.val + "";
            }
            else if (t.left == null && t.right != null)
            {
                return t.val + "()" + "(" + Tree2str(t.right) + ")";
            }
            else if (t.left != null && t.right == null)
            {
                return t.val + "(" + Tree2str(t.left) + ")";
            }
            else {
                return t.val + "(" + Tree2str(t.left) + ")" + "(" + Tree2str(t.right) + ")";
            }
        }
    }
}
