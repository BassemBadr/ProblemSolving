using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class MaximumDepthOfBinaryTree104
    {
        //https://leetcode.com/problems/maximum-depth-of-binary-tree
        public int MaxDepth(TreeNode root)
        {
            //  time O(n) : n is number of nodes as each node is visited only once
            //  space O(h) : h is tree hight and space is used for storing recursion stack

            if (root == null)
                return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        private int Solution1(TreeNode root)
        {
            if (root == null)
                return 0;

            int depth = 1;

            depth = Math.Max(TraverseDepth(root.left, depth), TraverseDepth(root.right, depth));
            return depth;
        }

        int TraverseDepth(TreeNode node, int depth)
        {

            if (node == null)
                return depth;

            depth++;

            return Math.Max(TraverseDepth(node.left, depth), TraverseDepth(node.right, depth));
        }
    }
}
