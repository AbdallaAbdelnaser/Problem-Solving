public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {

        bool IsSymmetric(TreeNode node1, TreeNode node2)
        {

            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null || node1.val != node2.val)
                return false;

            return IsSymmetric(node1.left, node2.right) && IsSymmetric(node1.right, node2.left);

        }

        return IsSymmetric(root, root);
    }
}

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 **/
