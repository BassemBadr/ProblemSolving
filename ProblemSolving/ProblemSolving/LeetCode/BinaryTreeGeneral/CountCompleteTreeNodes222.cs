using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class CountCompleteTreeNodes222
    {
        //https://leetcode.com/problems/count-complete-tree-nodes
        public int CountNodes(TreeNode root)
        {
            //  time O((log n)^2) ==> time complexity on each level = O(log n) and number of levels to recurse = O(h) = O(log n) ==> total work = O(log n) * O(log n) = O((log n)^2)
            //  space O(h) or O(log n)

            if (root == null) return 0;

            int leftHeight = GetLeftHeight(root);
            int rightHeight = GetRightHeight(root);

            if (leftHeight == rightHeight)
            {
                // Perfect binary tree
                return (1 << leftHeight) - 1; // 2^h - 1
            }

            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }

        private int GetRightHeight(TreeNode node)
        {
            int height = 0;
            while (node != null)
            {
                height++;
                node = node.right;
            }
            return height;
        }

        private int GetLeftHeight(TreeNode node)
        {
            int height = 0;
            while (node != null)
            {
                height++;
                node = node.left;
            }
            return height;
        }

        private int Solution1(TreeNode root)
        {
            //  time O(n) ==> but requirement says time should be < O(n)
            //  space O(h)
            if (root == null) return 0;

            if (root.left == null && root.right == null) return 1;

            int leftCount = CountNodes(root.left);
            int rightCount = CountNodes(root.right);

            return 1 + leftCount + rightCount;
        }
    }
}
