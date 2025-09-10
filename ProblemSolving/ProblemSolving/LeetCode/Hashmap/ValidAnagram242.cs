namespace ProblemSolving.LeetCode.Hashmap
{
    public class ValidAnagram242
    {
        public bool IsAnagram(string s, string t)
        {
            //  first if the length is not equal return false
            //  then count unique characters from s string 
            //  then loop on char in t string and reduce their count and if any count gone below 0 return false
            //  otherwise then all went well return true
            //  time complexity of O(n)
            //  space complexity of O(1)
            if (s.Length != t.Length)
                return false;

            int[] charCount = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                charCount[t[i]]--;
                if (charCount[t[i]] < 0)
                    return false;
            }

            return true;
        }

        private static bool FollowUp(string s, string t)
        {
            //  for the followup 
            //  would replacee the array with dictionary
            //  time complexity O(n)
            //  space complexity O(k) k: number of unique characters in s
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charCount = [];
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                    charCount[s[i]]++;
                else
                    charCount.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!charCount.ContainsKey(t[i]))
                    return false;
                else
                {
                    charCount[t[i]]--;
                    if (charCount[t[i]] < 0)
                        return false;
                }
            }

            return true;
        }

        private static bool Solution3(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] charCount = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++;
                charCount[t[i] - 'a']--;
            }

            foreach (int c in charCount)
            {
                if (c != 0)
                    return false;
            }

            return true;
        }

        private static bool Solution2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charCount = [];
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount.ContainsKey(s[i]))
                    charCount[s[i]]++;
                else
                    charCount.Add(s[i], 1);

                if (charCount.ContainsKey(t[i]))
                    charCount[t[i]]--;
                else
                    charCount.Add(t[i], -1);
            }

            foreach (int c in charCount.Values)
            {
                if (c != 0)
                    return false;
            }

            return true;
        }

        private static bool Solution1(string s, string t)
        {
            //  first idea is to create mapping for each character count
            //  then loop on words and set character count
            //  then compare final result that each character still has the same count in the two strings
            //  time complexity of O(n)
            //  space complexity of O(1)
            if (s.Length != t.Length)
                return false;

            int[] sCount = new int[256];
            int[] tCount = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                sCount[s[i]]++;
                tCount[t[i]]++;
            }

            for (int i = 0; i < sCount.Length; i++)
            {
                if (sCount[i] != tCount[i])
                    return false;
            }
            return true;
        }
    }
}
