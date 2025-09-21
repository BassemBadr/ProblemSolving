using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class SameTree100
    {
        //https://leetcode.com/problems/same-tree
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Solution1(p, q);
        }

        private static bool Solution3(TreeNode p, TreeNode q)
        {
            //  this is slightly more organized but very complicated for the problem, will go with the recursive solution for now
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            TreeNode currP = p;
            TreeNode currQ = q;

            while (currP != null && currQ != null)
            {
                if (currP.left == null && currQ.left == null)
                {
                    if (currP.val != currQ.val)
                        return false;

                    currP = currP.right;
                    currQ = currQ.right;
                }
                else if (currP.left != null && currQ.left != null)
                {
                    TreeNode pPre = currP.left;
                    TreeNode qPre = currQ.left;
                    while (pPre.right != null && pPre.right != currP)
                    {
                        pPre = pPre.right;
                    }
                    while (qPre.right != null && qPre.right != currQ)
                    {
                        qPre = qPre.right;
                    }

                    if (qPre.val != pPre.val) return false;

                    if (pPre.right == null && qPre.right == null)
                    {
                        pPre.right = currP;
                        currP = currP.left;

                        qPre.right = currQ;
                        currQ = currQ.left;
                    }
                    else if (pPre.right == currP && qPre.right == currQ)
                    {
                        if (currP.val != currQ.val)
                            return false;

                        pPre.right = null;
                        qPre.right = null;

                        currP = currP.right;
                        currQ = currQ.right;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return currP == null && currQ == null;
        }

        private static bool Solution2(TreeNode p, TreeNode q)
        {
            //  an attempt to use Morris traversal to solve this problem,
            //  but needs alot of cleaning up
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            TreeNode currP = p;
            TreeNode currQ = q;

            while (currP != null && currQ != null)
            {
                if (currP?.left?.val != currQ?.left?.val)
                    return false;

                if (currP.left == null && currQ.left == null)
                {
                    if (currP.val != currQ.val)
                        return false;

                    currP = currP.right;
                    currQ = currQ.right;
                }
                else
                {
                    TreeNode pPre = currP.left;
                    TreeNode qPre = currQ.left;
                    while (pPre.right != null && pPre.right != currP && qPre.right != null && qPre.right != currQ)
                    {
                        pPre = pPre.right;
                        qPre = qPre.right;
                    }

                    if (pPre?.val != qPre?.val)
                        return false;

                    if (pPre == null || qPre == null)
                        return false;

                    else if (pPre.right == null && qPre.right == null)
                    {
                        pPre.right = currP;
                        currP = currP.left;

                        qPre.right = currQ;
                        currQ = currQ.left;
                    }
                    else if (pPre.right == currP && qPre.right == currQ)
                    {
                        if (currP?.val != currQ?.val)
                            return false;

                        pPre.right = null;
                        qPre.right = null;

                        currP = currP.right;
                        currQ = currQ.right;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return currP == null && currQ == null;
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

        private void ScanTreeUsingMorris(TreeNode head)
        {
            TreeNode current = head;
            List<int> res = [];
            while (current != null)
            {
                if (current.left == null)
                {
                    res.Add(current.val);
                    current = current.right;
                }
                else
                {
                    TreeNode predecessor = current.left;
                    while (predecessor.right != null && predecessor.right != current)
                    {
                        predecessor = predecessor.right;
                    }

                    if (predecessor.right == null)
                    {
                        predecessor.right = current;
                        current = current.left;
                    }
                    else
                    {
                        res.Add(predecessor.right.val);
                        predecessor.right = null;
                        current = current.right;

                    }
                }
            }
        }
    }
}
