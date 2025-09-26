using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinarySearchTree
{
    public class MinAbsoluteDifferenceInBST530
    {
        //https://leetcode.com/problems/minimum-absolute-difference-in-bst
        public int GetMinimumDifference(TreeNode root)
        {
            //  used recursive inorder traversal here instead of Morris
            //  time O(n)
            //  space O(h)

            int difference = int.MaxValue;
            int? lastNodeVal = null;

            InOrderTraversal(root, ref difference, ref lastNodeVal);
            return difference;
        }

        private void InOrderTraversal(TreeNode root, ref int difference, ref int? lastNodeVal)
        {
            if (root == null) return;
            InOrderTraversal(root.left, ref difference, ref lastNodeVal);
            if (lastNodeVal == null)
            {
                lastNodeVal = root.val;
            }
            else
            {
                int newDiff = root.val - lastNodeVal.Value;
                difference = newDiff < difference ? newDiff : difference;
                lastNodeVal = root.val;
            }

            InOrderTraversal(root.right, ref difference, ref lastNodeVal);
        }

        private static int Solution2(TreeNode root)
        {
            //  time O(n)
            //  space O(1)

            int difference = 0;
            int? lastVal = null;
            TreeNode current = root;
            while (current != null)
            {
                if (current.left == null)
                {
                    if (lastVal == null)
                    {
                        lastVal = current.val;
                    }
                    else
                    {
                        int newDiff = current.val - lastVal.Value;
                        if (difference == 0)
                            difference = newDiff;
                        else
                            difference = Math.Min(difference, newDiff);

                        lastVal = current.val;
                    }
                    current = current.right;
                }
                else
                {
                    TreeNode prev = current.left;
                    while (prev.right != null && prev.right != current)
                    {
                        prev = prev.right;
                    }
                    if (prev.right == null)
                    {
                        prev.right = current;
                        current = current.left;
                    }
                    else
                    {
                        if (lastVal == null)
                        {
                            lastVal = current.val;
                        }
                        else
                        {
                            int newDiff = current.val - lastVal.Value;
                            if (difference == 0)
                                difference = newDiff;
                            else
                                difference = Math.Min(difference, newDiff);

                            lastVal = current.val;
                        }
                        current = current.right;
                        prev.right = null;
                    }
                }
            }
            return difference;
        }

        private static int solution1(TreeNode root)
        {
            //  using Morris traversal allowing for traversing the tree in order then by comparing each consecutive numbers and compare with previous min we can get the absolute min difference in the tree
            //  time O(n)
            //  space O(1)

            int difference = 0;
            int? lastVal = null;
            TreeNode current = root;
            while (current != null)
            {
                if (current.left == null)
                {
                    CalculateMinDiff(ref difference, ref lastVal, current);
                    current = current.right;
                }
                else
                {
                    TreeNode prev = current.left;
                    while (prev.right != null && prev.right != current)
                    {
                        prev = prev.right;
                    }
                    if (prev.right == null)
                    {
                        prev.right = current;
                        current = current.left;
                    }
                    else
                    {
                        CalculateMinDiff(ref difference, ref lastVal, current);
                        current = current.right;
                        prev.right = null;
                    }
                }
            }
            return difference;
        }

        private static void CalculateMinDiff(ref int difference, ref int? lastVal, TreeNode current)
        {
            if (lastVal == null)
            {
                lastVal = current.val;
            }
            else
            {
                int newDiff = Math.Abs(current.val - lastVal.Value);
                if (difference == 0)
                    difference = newDiff;
                else
                    difference = Math.Min(difference, newDiff);

                lastVal = current.val;
            }
        }
    }
}
