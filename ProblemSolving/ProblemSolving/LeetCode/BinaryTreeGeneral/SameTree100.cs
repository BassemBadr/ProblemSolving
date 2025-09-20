using ProblemSolving.LeetCode.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class SameTree100
    {
        //https://leetcode.com/problems/same-tree
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Solution1(p, q);
        }

        private bool Solution1(TreeNode p, TreeNode q)
        {
            //  Time O(n) maximum is number all nodes in one tree if they are identical
            //  space O(k) recursion stack representing tree height
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
