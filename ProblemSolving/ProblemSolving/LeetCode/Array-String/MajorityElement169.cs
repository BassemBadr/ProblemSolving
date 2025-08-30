namespace ProblemSolving.LeetCode.Array_String
{
    public class MajorityElement169
    {
        //https://leetcode.com/problems/majority-element
        public int MajorityElement(int[] nums)
        {
            //  trying to implement Boyer-Moore's voting algorithm
            //  from what i understand it depends on fluctations between upvotes and downvotes 
            //  and if a tie happens then we can say that all the previous dataset has no majority and can be discarded
            //  and calculate majority based on the coming elements using the same upvote and downvote scenarios
            int votes = 0, candidate = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (votes == 0)
                {
                    candidate = nums[i];
                    votes = 1;
                }
                else if (nums[i] == candidate)
                {
                    votes++;
                }
                else
                {
                    votes--;
                }
            }
            return candidate;

            //  since majority is guaranteed in the problem no need to check for it but we can 
            //  add a second loop count check for the majority i.e more than n/2
            //int count = 0;
            //for (int index = 0; index < nums.Length; index++)
            //{
            //    if (nums[index] == candidate)
            //        count++;
            //}
            //if (count > (nums.Length / 2))
            //    return candidate;
            //throw new Exception("Majoroty element not found");
        }

        private int Solution1(int[] nums)
        {
            //  i used extra space in dictionary need to check if there is a way to reduce or eleminate it
            //  extra performance required for search and access dictionary with each loop 
            //  lastly extra performance for order by the value at the end
            Dictionary<int, int> itemCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (itemCount.TryGetValue(nums[i], out int value))
                    itemCount[nums[i]] = ++value;
                else
                {
                    itemCount.Add(nums[i], 1);
                }
            }
            return itemCount.OrderByDescending(a => a.Value).First().Key;
        }
    }
}
