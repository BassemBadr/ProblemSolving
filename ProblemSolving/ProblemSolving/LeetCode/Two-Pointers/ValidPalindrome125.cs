namespace ProblemSolving.LeetCode.Two_Pointers
{
    public class ValidPalindrome125
    {
        //https://leetcode.com/problems/valid-palindrome
        public bool IsPalindrome(string s)
        {
            //  the idea is to create two pointers at the start and the end
            //  and go thorough the alpha numeric only to check if the start and end are equal or not if not 
            //  then not palindrome if they are continue checking untill the pointers meet each other
            //  if any of the pointers encounters space or special char skips it to the next item
            //  time complexity O(n/2) => O(n) and space O(1)

            int start = 0, end = s.Length - 1;
            while (start < end)
            {
                if (!char.IsAsciiLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }
                if (!char.IsAsciiLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (char.ToLowerInvariant(s[start]) != char.ToLowerInvariant(s[end]))
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
