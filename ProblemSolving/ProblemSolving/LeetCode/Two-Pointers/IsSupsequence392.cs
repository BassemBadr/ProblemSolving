namespace ProblemSolving.LeetCode.Two_Pointers
{
    public class IsSupsequence392
    {
        //https://leetcode.com/problems/is-subsequence

        #region Initial problem

        public IsSupsequence392()
        {
            //  original solution
        }

        public bool IsSubsequence(string s, string t)
        {
            //  the idea is to loop mainly on characters of subsequence and check if every character exist in order in t string
            //  and once a character is found can then advance to the next character
            //  solution time complexity is O(n) and space complexity of O(1)

            if (s.Length > t.Length)
                return false;

            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            return sIndex == s.Length;
        }

        #endregion

        #region Follow up problem

        Dictionary<char, List<int>> charPosition = [];        
        private string t;

        public IsSupsequence392(string t)
        {
            //  prepare test string and map it to character list with the indeces for each character
            this.t = t;
            for (int i = 0; i < t.Length; i++)
            {
                char c = t[i];
                if (!charPosition.ContainsKey(c))
                    charPosition.Add(c, []);
                charPosition[c].Add(i);
            }
        }
        public bool IsSubsequence(string s)
        {
            //  this solution depends on preprocessing of the main string to prepare list of letters and its occurence indeces
            //  then use binary search for each char of subsequence string while considering previous found index to keep relative order
            //  preprocessing time is O(n) and space of O(n) where n = length of t
            //  as for the search function itself 
            //  Per query: O(m log k) m = length of query string s and k is average length of occurences in charPosition
            //  total time complexity for all queries O(n + k * m log k) instead of O(k * n)
            //  and space complexity is O(n) instead of O(1)

            if (s.Length == 0)
                return true;
            if (s.Length > t.Length)
                return false;

            foreach (var c in s)
            {
                if (!charPosition.ContainsKey(c))
                    return false;
            }

            int sCharIndex = -1;
            foreach (char c in s)
            {
                int nextIndex = -1;
                int low = 0, high = charPosition[c].Count - 1;

                while (low <= high)
                {
                    int mid = low + (high - low) / 2;
                    if (charPosition[c][mid] > sCharIndex)
                    {
                        nextIndex = charPosition[c][mid];
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                if (nextIndex == -1)
                    return false;   //  didn't find character with correct position in t (to keep same relative position rule)

                if (nextIndex == -1)    //  in this case no index was found for the char > current index (to keep the relative order rule in effect)
                    return false;
                sCharIndex = nextIndex;
            }
            return true;
        }

        #endregion
    }
}
