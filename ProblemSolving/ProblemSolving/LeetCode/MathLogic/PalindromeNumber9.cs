namespace ProblemSolving.LeetCode.MathLogic
{
    public class PalindromeNumber9
    {
        public bool IsPalindrome(int x)
        {
            //  generate reversed number using least significant then multiply by 10^loop count 
            //  compare the reversed with the original 
            //  all negative numbers are not palindrome
            //  space O(1)
            //  time O(log10 n)
            if (x < 0) return false;
            if (x < 10) return true;

            int temp = x, reversed = 0;

            while (temp > 0)
            {
                if (reversed > int.MaxValue / 10)
                    return false;

                int least = temp % 10;
                reversed = reversed * 10 + least;
                temp = temp / 10;
            }
            return reversed == x;
        }
    }
}
