namespace ProblemSolving.LeetCode.Array_String
{
    public class LongestCommonPrefix14
    {
        //https://leetcode.com/problems/longest-common-prefix
        public string LongestCommonPrefix(string[] strs)
        {
            return Solution2(strs);
        }

        private static string Solution3(string[] strs)
        {
            //  time should be O(nlog n) and space of O(m)
            //  this is actually worse
            Array.Sort(strs);
            int minLength = Math.Min(strs[0].Length, strs[strs.Length - 1].Length);
            int index = 0;
            while (index < minLength && strs[0][index] == strs[strs.Length - 1][index])
                index++;
            string commonPrefix = strs[0].Substring(0, index);
            return commonPrefix;
        }

        private static string Solution2(string[] strs)
        {
            //  this looks alittle better in readability and some operations are saved although not by much 
            //  overall still time complexity O(n*m) and space O(m) where m is longest prefix
            string commonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int minLength = Math.Min(commonPrefix.Length, strs[i].Length);
                int index = 0;

                while (index < minLength && commonPrefix[index] == strs[i][index])
                {
                    index++;
                }
                commonPrefix = commonPrefix.Substring(0, index);

                if (commonPrefix.Length == 0)
                    break;
            }
            return commonPrefix;
        }

        private static string Solution1(string[] strs)
        {
            //  the idea is to assume the common prefix is the entire first word 
            //  then cut down from it as i check more words 
            //  time complexity O(n*m) and space O(m) where m is longest prefix
            string commonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int minLength = Math.Min(commonPrefix.Length, strs[i].Length);
                if (minLength < commonPrefix.Length)
                    commonPrefix = commonPrefix.Substring(0, minLength);
                for (int index = 0; index < minLength; index++)
                {
                    if (commonPrefix[index] != strs[i][index])
                    {
                        commonPrefix = commonPrefix.Substring(0, index);
                        break;
                    }
                }
                if (commonPrefix.Length == 0)
                    break;
            }
            return commonPrefix;
        }
    }
}
