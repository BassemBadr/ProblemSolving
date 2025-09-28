using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.DivideAndConquer
{
    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
    public class ConvertSortedArrayToBinarySearchTree108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            //  the initial idea is to implement method almost like binary search 
            //  get the middle node set it to the root then assign left and right using the sub-arrays and apply the same logic
            //  time O(n)
            //  space O(log n)
            TreeNode root = CreateBinaryTree(nums, 0, nums.Length - 1);
            return root;
        }

        private TreeNode CreateBinaryTree(int[] nums, int start, int end)
        {
            if (start > end)
                return null;

            int middle = start + ((end - start) / 2);
            TreeNode root = new TreeNode(nums[middle]);
            root.left = CreateBinaryTree(nums, start, middle - 1);
            root.right = CreateBinaryTree(nums, middle + 1, end);
            return root;
        }
    }
}
