namespace ProblemSolving.LeetCode.MathLogic
{
    public class PlusOne66
    {
        public int[] PlusOne(int[] digits)
        {            
            //  time O(n)
            //  space O(1)
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
