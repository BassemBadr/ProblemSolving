namespace ProblemSolving.LeetCode.BitManipulation
{
    public class SingleNumber136
    {
        //https://leetcode.com/problems/single-number
        public int SingleNumber(int[] nums)
        {
            //  the initial idea is to create a result number =0 
            //  then use XOR with all numbers in the array each two equal numbers will cancel each other
            //  leaving only the single number existing in array as the result of the XOR
            //  time O(n)
            //  space O(1)
            int result = 0;
            foreach (int num in nums)
            {
                result = result ^ num;
            }
            return result;
        }
    }
}
