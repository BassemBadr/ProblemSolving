namespace ProblemSolving.LeetCode.Hashmap
{
    public class WordPattern290
    {
        //https://leetcode.com/problems/word-pattern
        public bool WordPattern(string pattern, string s)
        {
            return Solution4(pattern, s);
        }

        private static bool Solution5(string pattern, string s)
        {
            string[] wordList = s.Split(" ");
            if (pattern.Length != wordList.Length)
                return false;

            string[] charToWord = new string[256];
            Dictionary<string, char> wordToChar = [];

            for (int i = 0; i < pattern.Length; i++)
            {
                string word = wordList[i];
                char c = pattern[i];
                if (charToWord[c] != null)
                {
                    if (charToWord[c] != word)
                        return false;
                }
                else
                {
                    if (wordToChar.ContainsKey(word))
                    {
                        return false;
                    }
                    else
                    {
                        charToWord[c] = word;
                        wordToChar.Add(word, c);
                    }
                }
            }
            return true;
        }

        private static bool Solution4(string pattern, string s)
        {
            //  clean up checks and use dictionary for key and value 
            string[] wordList = s.Split(" ");
            if (pattern.Length != wordList.Length)
                return false;
            Dictionary<char, string> mapping = [];
            for (int i = 0; i < pattern.Length; i++)
            {
                string word = wordList[i];
                char c = pattern[i];
                if (mapping.ContainsKey(c))
                {
                    if (mapping[c] != word)
                        return false;
                }
                else
                {
                    if (mapping.ContainsValue(word))    //  need to find replacement for this
                    {
                        return false;
                    }
                    else
                    {
                        mapping.Add(c, word);
                    }
                }
            }
            return true;
        }

        private static bool Solution3(string pattern, string s)
        {
            //  time O(n + p)
            //  space O(p)
            //  still not satisfied

            string[] wordList = s.Split(" ");
            if (pattern.Length != wordList.Length)
                return false;
            string[] charMapping = new string[256];
            Dictionary<string, char> wordMapping = [];
            for (int i = 0; i < pattern.Length; i++)
            {
                string word = wordList[i];
                char c = pattern[i];
                if (charMapping[c] == null)
                {
                    charMapping[c] = word;
                }
                else if (charMapping[c] != word)
                {
                    return false;
                }

                if (wordMapping.TryGetValue(word, out char key))
                {
                    if (c != key || charMapping[key] != word)
                    {
                        return false;
                    }
                }
                else
                {
                    wordMapping.Add(word, c);
                }
            }
            return true;
        }

        private static bool Solution2(string pattern, string s)
        {
            //  the idea is to reverse it and loop on words of string s
            //  keep tracking of mapping in both ways
            //  time complexity of O(n)
            //  space of O(p + w)
            //  still don't like it i think there is still much better / cleaner solution
            string[] charMapping = new string[256];
            Dictionary<string, char> wordMapping = [];
            int wordCount = 0;
            int patternIndex = -1;
            List<char> wordChars = [];
            for (int i = 0; i <= s.Length; i++)
            {
                if (i == s.Length || s[i] == ' ')
                {
                    patternIndex++;
                    wordCount++;
                    if (patternIndex >= pattern.Length)
                        return false;

                    char c = pattern[patternIndex];
                    string newWord = string.Join("", wordChars);
                    if (charMapping[c] == null && !wordMapping.ContainsKey(newWord))
                    {
                        charMapping[c] = newWord;
                        wordMapping.Add(newWord, c);
                    }
                    else if ((!wordMapping.TryGetValue(newWord, out char key)) || key != c || charMapping[c] != newWord)
                    {
                        return false;
                    }
                    wordChars = [];
                }
                else
                {
                    wordChars.Add(s[i]);
                }
            }
            if (wordCount != pattern.Length)
                return false;

            return true;
        }

        private static bool Solution1(string pattern, string s)
        {
            //  first solution to come to mind 
            //  is to create mapping and go through the letters of pattern 
            //  then if not exist in mapping (as key or value) add it and if exist compare with previous if not equal return false
            //  all while keeping count of word count to compare vs pattern letters
            //  and string length to see if it matches the pattern
            //  time and space complexity are alittle complicated but i guess its as follows
            //  time complexity O(n + p^2) which is really bad because of the mapping.ContainsValue(word) part
            //  space complexity of O(p)

            if (pattern.Length == 0 && s.Length != 0)
                return false;

            if (s.Length == 0 && pattern.Length != 0)
                return false;

            Dictionary<char, string> mapping = [];

            int wordIndex = 0;
            int charCount = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (wordIndex >= s.Length)
                    break;

                char c = pattern[i];
                List<char> nextWord = [];
                while (wordIndex < s.Length && s[wordIndex] != ' ')
                {
                    nextWord.Add(s[wordIndex]);
                    wordIndex++;
                }

                string word = string.Join("", nextWord);
                charCount++;
                if (mapping.TryGetValue(c, out string? wordValue))
                {
                    if (wordValue != word)
                        return false;
                }
                else if (mapping.ContainsValue(word))
                {
                    return false;
                }
                else
                {
                    mapping.Add(c, word);
                }
                wordIndex++;
            }
            if (wordIndex < s.Length)
                return false;

            if (charCount != pattern.Length)
                return false;

            return true;
        }
    }
}
