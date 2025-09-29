namespace ProblemSolving.LeetCode.BinarySearch
{
    public class SearchInsertPosition35
    {
        //https://leetcode.com/problems/search-insert-position
        public int SearchInsert(int[] nums, int target)
        {
            //  apply binary search for an element thats not less that target and keep track of that position and as the search ends
            //  the result is found automatically, also handle case where the taget is to be appended to the array initially
            //  time O(log n)
            //  space O(1) 
            int min = 0, max = nums.Length - 1;
            int result = nums.Length;
            while (min <= max)
            {
                int mid = (min + (max - min) / 2);
                if (target <= nums[mid])
                {
                    result = mid;
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return result;
        }
    }
}
