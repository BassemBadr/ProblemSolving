namespace ProblemSolving.LeetCode.Hashmap
{
    public class RansomNote383
    {
        //https://leetcode.com/problems/ransom-note
        public bool CanConstruct(string ransomNote, string magazine)
        {
            return Solution2(ransomNote, magazine);
        }

        private static bool Solution3(string ransomNote, string magazine)
        {
            //  here i wanted to try to loop only on ransom note and store last index found in an array
            //  but this solution could be worse as in worst where magazine.IndexOf would potentially scan the entire array each time
            //  time complexity O(m * n)
            //  space O(1)
            //  i guess i prefer solution 2
            if (ransomNote.Length == 0)
                return true;

            if (ransomNote.Length > magazine.Length)
                return false;

            int[] charIndex = new int[128];
            foreach (var c in ransomNote)
            {
                int newIndex = magazine.IndexOf(c, charIndex[c]);
                if (newIndex == -1)
                    return false;
                else
                    charIndex[c] = newIndex + 1;
            }
            return true;
        }

        private static bool Solution2(string ransomNote, string magazine)
        {
            //  this solution is using the ascii of characters to access array index 
            //  and increment value when looping the magazine and decrementing the value when looping ransom note
            //  and returns false if any char was overused (usage dropped below 0)
            //  this is slightly better in space as its O(1)
            //  time is the same O(m+n)
            if (ransomNote.Length == 0)
                return true;

            if (ransomNote.Length > magazine.Length)
                return false;

            int[] charCount = new int[128];
            foreach (var c in magazine)
            {
                charCount[c]++;
            }

            foreach (var c in ransomNote)
            {
                charCount[c]--;
                if (charCount[c] < 0)
                    return false;
            }
            return true;
        }

        private static bool Solution1(string ransomNote, string magazine)
        {
            //  first idea that came to mind
            //  create character count for magazine then search for each ransom note char in character count 
            //  not the best performance imo time of O(m+n) where m = length of magazine and n = length of ransom note 
            //  space complexity of O(n) where n is the magazine lenght
            Dictionary<char, int> charCount = [];
            foreach (char c in magazine)
            {
                if (!charCount.ContainsKey(c))
                    charCount.Add(c, 0);
                charCount[c]++;
            }

            foreach (char c in ransomNote)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]--;
                    if (charCount[c] < 0)
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
