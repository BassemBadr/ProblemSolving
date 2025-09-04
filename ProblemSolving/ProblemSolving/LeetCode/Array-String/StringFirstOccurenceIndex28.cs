
namespace ProblemSolving.LeetCode.Array_String
{
    public class StringFirstOccurenceIndex28
    {
        //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
        public int StrStr(string haystack, string needle)
        {
            return BoyerMoorePatternSearch(haystack, needle);
        }

        private int BoyerMoorePatternSearch(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
                return -1;
            Dictionary<char, int> badMatchTable = CreateBadMatchTable(needle);
            int i = 0;
            while (i < haystack.Length)
            {
                bool isFound = true;
                for (int j = needle.Length - 1; j >= 0; j--)
                {
                    if ((i + j) >= haystack.Length)
                        return -1;
                    if (needle[j] != haystack[i + j])
                    {
                        isFound = false;
                        if (badMatchTable.TryGetValue(haystack[i + j], out int value))
                        {
                            i += value;
                            break;
                        }
                        else
                        {
                            i += needle.Length;
                            break;
                        }
                    }
                }
                if (isFound) return i;
            }
            return -1;
        }

        private Dictionary<char, int> CreateBadMatchTable(string needle)
        {
            int length = needle.Length;
            var table = new Dictionary<char, int>();

            // Default shift for characters not in pattern
            foreach (char c in needle)
            {
                table[c] = length;
            }

            // Update shifts for characters in pattern (except last)
            for (int i = 0; i < length - 1; i++)
            {
                table[needle[i]] = length - i - 1;
            }

            return table;
        }

        private int Solution2(string haystack, string needle)
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
