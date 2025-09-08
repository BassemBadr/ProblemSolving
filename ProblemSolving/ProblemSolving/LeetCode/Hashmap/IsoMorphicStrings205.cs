namespace ProblemSolving.LeetCode.Hashmap
{
    public class IsoMorphicStrings205
    {
        //https://leetcode.com/problems/isomorphic-strings
        public bool IsIsomorphic(string s, string t)
        {
            //  here i replaced dictionary with direct indexing using character ascii to an array with fixed length
            //  leading to space complexity of O(1)
            //  time complexity is still O(n)

            char[] smap = new char[256];
            char[] tmap = new char[256];
            for (int i = 0; i < s.Length; i++)
            {
                if (smap[s[i]] != 0)
                {
                    if (smap[s[i]] != t[i])
                        return false;
                }
                else
                    smap[s[i]] = t[i];

                if (tmap[t[i]] != 0)
                {
                    if (tmap[t[i]] != s[i])
                        return false;
                }
                else
                    tmap[t[i]] = s[i];
            }
            return true;

        }

        private static bool Solution1(string s, string t)
        {
            //  first idea that came to mind is create a mapping for each string and scan both strings since they are of same length
            //  and check if mapping doesn't exist we add it and if exists check if its different from existing, if different should return false
            //  time compplexity of O(n) 
            //  space complexity of O(m + n) where m = length of s and n = length of t

            Dictionary<char, char> sMapping = [];
            Dictionary<char, char> tMapping = [];

            for (int i = 0; i < s.Length; i++)
            {
                if (sMapping.ContainsKey(s[i]))
                {
                    if (sMapping[s[i]] != t[i])
                        return false;
                }
                else
                    sMapping.Add(s[i], t[i]);

                if (tMapping.ContainsKey(t[i]))
                {
                    if (tMapping[t[i]] != s[i])
                        return false;
                }
                else
                    tMapping.Add(t[i], s[i]);
            }
            return true;
        }
    }
}
