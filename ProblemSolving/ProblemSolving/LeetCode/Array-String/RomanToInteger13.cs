namespace ProblemSolving.LeetCode.Array_String
{
    public class RomanToInteger13
    {
        static readonly Dictionary<char, int> RomanMap = new() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

        int Roman(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }
            return 0;
        }

        public int RomanToInt(string s)
        {
            //  wanted to try a function with switch case instead of dictionary
            //  seems better in performance as well as memory usage
            //  but overall still time O(n) and space O(1)

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = Roman(s[i]);
                if (i + 1 < s.Length && Roman(s[i + 1]) > current)
                {
                    total -= current;
                    total += Roman(s[i + 1]);
                    i++;
                }
                else
                {
                    total += current;
                }
            }
            return total;
        }

        private static int Solution3(string s)
        {
            //  after some search there was a suggestion for a look ahead approach which means
            //  checking the next symbol before deciding to add or subtract instead of calculation correction

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = RomanMap[s[i]];
                if (i + 1 < s.Length && RomanMap[s[i + 1]] > current)
                {
                    total -= current;
                }
                else
                {
                    total += current;
                }
            }
            return total;
        }

        private static int Solution2(string s)
        {
            int total = RomanMap[s[0]];
            for (int i = 1; i < s.Length; i++)
            {
                if (RomanMap[s[i]] > RomanMap[s[i - 1]])
                {
                    total -= (2 * RomanMap[s[i - 1]]);
                }
                total += RomanMap[s[i]];
            }
            return total;
        }

        private int Solution1(ref string s)
        {
            //  the idea i came up with when observing the samples is that
            //  i can go through each symbol if symbol value is the same or decreasing  from the previous symbol then the value is added to total
            //  and if its higher then i need to subtract the value of previous symbol thats was already added 
            //  then add the value of the enw symbol after subtracting the value of previous symbol (which lead to subtracting symbol value twice as appearing in the code)
            //  note:i think i can remove lastSymbol and use always previous symbol from the string to tweak it alittle more
            //  time complixity is O(n) and space O(1)

            int total = RomanMap[s[0]]; char lastSymbol = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (RomanMap[s[i]] > RomanMap[lastSymbol])
                {
                    total -= (2 * RomanMap[lastSymbol]);
                    total += RomanMap[s[i]];
                }
                else
                {
                    total += RomanMap[s[i]];
                }
                lastSymbol = s[i];
            }
            return total;
        }
    }
}
