namespace ProblemSolving.LeetCode.Array_String
{
    public class StringFirstOccurenceIndex28
    {
        //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
        public int StrStr(string haystack, string needle)
        {
            //  removed the substring creation with each loop and substituted with a check function to verify the needle existance 
            //  without the extra memory overhead
            //  time still O(m*n) but space now is O(1)
            //  with early exists on failure ofcourse
            if (needle.Length > haystack.Length)
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if ((i + needle.Length) > haystack.Length)
                    return -1;
                if (CheckNeedleExist(needle, haystack, i))
                    return i;
            }

            return -1;
        }

        private bool CheckNeedleExist(string needle, string hayStack, int startIndex)
        {
            for (int i = 0; i < needle.Length; i++)
            {
                if (needle[i] != hayStack[i + startIndex])
                    return false;
            }
            return true;
        }

        private static int Solution1(string haystack, string needle)
        {
            //  the straight forward approach is to use a sliding window to scan for the needle in the haystack
            //  time complexity is O(m*n) and space of O(m) due to the substring creation 
            //  i guess i got to remove that
            if (needle.Length > haystack.Length)
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if ((i + needle.Length) > haystack.Length)
                    return -1;
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            }

            return -1;
        }
    }
}
