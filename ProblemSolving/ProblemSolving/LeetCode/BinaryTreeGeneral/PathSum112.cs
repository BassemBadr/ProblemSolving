using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class PathSum112
    {
        //https://leetcode.com/problems/path-sum
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            //  time O(n)
            //  space O(h) 
            if (root == null) return false;

            if (root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }
            else
            {
                int remaining = targetSum - root.val;
                return HasPathSum(root.left, remaining) || HasPathSum(root.right, remaining);
            }
        }

        private bool Solution1(TreeNode root, int targetSum)
        {
            //  time O(n)
            //  space O(h) 
            return HasPathSum(root, targetSum, 0);
        }

        private bool HasPathSum(TreeNode node, int targetSum, int pathSum)
        {
            if (node == null)
            {
                return false;
            }

            pathSum += node.val;

            if (node.left == null && node.right == null)
            {
                return targetSum == pathSum;
            }
            else
            {
                return HasPathSum(node.left, targetSum, pathSum)
                    || HasPathSum(node.right, targetSum, pathSum);
            }
        }
    }
}
