using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class SymmetricTree101
    {
        //https://leetcode.com/problems/symmetric-tree
        public bool IsSymmetric(TreeNode root)
        {
            //  time O(n)
            //  space O(n)
            if (root == null)
                return true;

            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            queue1.Enqueue(root.left);

            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue2.Enqueue(root.right);

            while (queue1.Count > 0 && queue2.Count > 0)
            {
                TreeNode node1 = queue1.Dequeue();
                TreeNode node2 = queue2.Dequeue();
                if (node1 == null && node2 == null)
                    continue;

                if (node1 == null || node2 == null)
                    return false;

                if (node1.val != node2.val)
                    return false;

                queue1.Enqueue(node1.left);
                queue2.Enqueue(node2.right);

                queue1.Enqueue(node1.right);
                queue2.Enqueue(node2.left);

            }

            return queue1.Count == 0 && queue2.Count == 0;
        }

        private bool RecursiveSolution(TreeNode root)
        {
            //  time O(n)
            //  space O(h)
            if (root == null)
                return true;
    
            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode leftBranch, TreeNode rightBranch)
        {
            if (leftBranch == null && rightBranch == null)
                return true;

            if (leftBranch == null || rightBranch == null)
                return false;

            if (leftBranch.val != rightBranch.val)
                return false;

            return IsSymmetric(leftBranch.left, rightBranch.right) && IsSymmetric(leftBranch.right, rightBranch.left);
        }
    }
}
