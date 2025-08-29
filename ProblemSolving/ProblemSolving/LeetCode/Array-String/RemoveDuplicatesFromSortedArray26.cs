namespace ProblemSolving.LeetCode.Array_String
{
    public class RemoveDuplicatesFromSortedArray26
    {
        //https://leetcode.com/problems/remove-duplicates-from-sorted-array
        public int RemoveDuplicates(int[] nums)
        {
            int writeIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[writeIndex] = nums[i];
                    writeIndex++;
                }
            }
            return writeIndex;
        }

        private int Solution2(int[] nums)
        {
            //  i don't need to swap since i don't need to care about duplicate values, need only to keep unique
            //  i can make use of always non descending order so i can search for different next value and write it directly to next place in array
            int replaceIndex = 1, testIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[testIndex])
                {
                    (nums[replaceIndex], nums[i]) = (nums[i], nums[replaceIndex]);
                    testIndex++;
                    replaceIndex++;
                }
            }
            return replaceIndex;
        }

        private int Solution1(int[] nums)
        {
            // i need to make use of first element is guaranteed to be fixed so no need to revese loop the array
            int replaceIndex = nums.Length - 1;
            int testIndex = nums.Length - 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] == nums[testIndex])
                {
                    for (int r = testIndex; r < replaceIndex; r++)
                    {
                        int item = nums[r];
                        nums[r] = nums[r + 1];
                        nums[r + 1] = item;
                    }
                    replaceIndex--;
                }
                testIndex--;
            }
            return replaceIndex + 1;
        }
    }
}
