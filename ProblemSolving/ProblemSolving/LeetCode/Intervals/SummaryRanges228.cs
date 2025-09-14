namespace ProblemSolving.LeetCode.Intervals
{
    public class SummaryRanges228
    {
        //https://leetcode.com/problems/summary-ranges
        public IList<string> SummaryRanges(int[] nums)
        {
            //  time O(n)
            //  space O(1)
            IList<string> result = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int start = nums[i];
                //  create loop to skip consecutive numbers
                while (i < nums.Length - 1 && nums[i] + 1 == nums[i + 1])
                {
                    i++;
                }
                //  check if single or range
                if (start == nums[i])
                {
                    result.Add($"{start}");
                }
                else
                {
                    result.Add($"{start}->{nums[i]}");
                }
            }
            return result;
        }

        private static IList<string> Solution1(int[] nums)
        {
            //  time O(n)
            //  space O(1)
            //  but needs alot of cleanup
            List<string> result = [];

            if (nums.Length == 0) return result;
            if (nums.Length == 1)
            {
                result.Add(nums[0].ToString());
                return result;
            }

            //  store first element in a string
            string firstNumber = nums[0].ToString();
            string lastNumber = string.Empty;
            bool isRange = false;

            //  start from second element
            for (int i = 1; i < nums.Length; i++)
            {
                //  if current number = previous number +1
                if (nums[i] == nums[i - 1] + 1)
                {
                    //      set last number in range as current number
                    lastNumber = nums[i].ToString();
                    //      if is last
                    if (i == nums.Length - 1)
                    {
                        //          add first number, last number as range to the result list
                        result.Add(firstNumber + "->" + lastNumber);
                    }
                    //      else if not last
                    else
                    {
                        //          set is range = true
                        isRange = true;
                        //          continue to the next number
                        continue;
                    }


                }
                //  else if current number != previous +1
                else
                {
                    //      if is last
                    if (i == nums.Length - 1)
                    {
                        //          if is range
                        if (isRange)
                        {
                            //              add first number, last number as range to the result list
                            result.Add(firstNumber + "->" + lastNumber);
                        }
                        //          else if not range
                        else
                        {
                            //              add first number as single element to the result list
                            result.Add(firstNumber);
                        }
                        //          add current number as single element to the result list
                        result.Add(nums[i].ToString());
                    }
                    //      else if is not last
                    else
                    {
                        //          if is range
                        if (isRange)
                        {
                            //              add first number, last number as range to the result list
                            result.Add(firstNumber + "->" + lastNumber);
                        }
                        //          else if not range
                        else
                        {
                            //              add first number as single element to the result list
                            result.Add(firstNumber);
                        }
                        //          set first element as current element
                        firstNumber = nums[i].ToString();
                        //           set last element as empty
                        lastNumber = string.Empty;
                        //            set is range = false
                        isRange = false;
                    }
                }
            }
            return result;
        }
    }
}
