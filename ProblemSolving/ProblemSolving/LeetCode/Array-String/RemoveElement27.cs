namespace ProblemSolving.LeetCode.Array_String
{
    public class RemoveElement27
    {
        //https://leetcode.com/problems/remove-element
        public int RemoveElement(int[] nums, int val)
        {
            int replaceIndex = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    int replaceItem = nums[replaceIndex];
                    nums[replaceIndex] = nums[i];
                    nums[i] = replaceItem;
                    replaceIndex--;
                }
            }
            return replaceIndex + 1;
        }
    }
}
