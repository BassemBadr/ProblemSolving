using System;

namespace ProblemSolving.LeetCode.Hashmap
{
    public class TwoSums1
    {
        //https://leetcode.com/problems/two-sum
        public int[] TwoSum(int[] nums, int target)
        {
            //  time O(n)
            //  space O(n)
            Dictionary<int, int> valueMapping = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int searchValue = target - nums[i];
                if (valueMapping.TryGetValue(searchValue, out int index) && i != index)
                {
                    return [index, i];
                }

                if (!valueMapping.ContainsKey(nums[i]))
                    valueMapping.Add(nums[i], i);
            }
            return [];
        }

        private static int[] Solution3(int[] nums, int target)
        {
            Dictionary<int, int> valueMapping = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (valueMapping.ContainsKey(target - nums[i]))
                    valueMapping[target - nums[i]] = i;
                else
                    valueMapping.Add(target - nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (valueMapping.TryGetValue(nums[i], out int index) && i != index)
                {
                    return [i, index];
                }
            }
            return [];
        }

        private static int[] Solution2(int[] nums, int target)
        {
            //  time O(n log n)
            //  space O(n)
            int[] sortedArray = new int[nums.Length];
            nums.CopyTo(sortedArray, 0);
            Array.Sort(sortedArray);
            int num1 = 0, num2 = 0;
            bool isNumFound = false;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                int low = i + 1, high = sortedArray.Length - 1;
                int targetNum2 = target - sortedArray[i];
                while (low <= high)
                {
                    int mid = low + (high - low) / 2;
                    if (targetNum2 == sortedArray[mid])
                    {
                        num1 = sortedArray[i];
                        num2 = targetNum2;
                        isNumFound = true;
                        break;
                    }
                    else if (targetNum2 > sortedArray[mid])
                    {
                        low = mid + 1;
                    }
                    else if (targetNum2 < sortedArray[mid])
                    {
                        high = mid - 1;
                    }
                }
                if (isNumFound) break;
            }

            int[] result = new int[2];
            bool num1Found = false, num2Found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num1 && !num1Found)
                {
                    result[0] = i;
                    num1Found = true;
                }
                else if (nums[i] == num2 && !num2Found)
                {
                    result[1] = i;
                    num2Found = true;
                }
                if (num1Found && num2Found)
                    break;
            }

            return result;
        }

        private static int[] Solution1(int[] nums, int target)
        {
            //  time O(n ^ 2)
            //  space O(1)
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }
            return [];
        }
    }
}
