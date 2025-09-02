namespace ProblemSolving.LeetCode.Array_String
{
    public class LengthOfLastWord58
    {
        //https://leetcode.com/problems/length-of-last-word
        public int LengthOfLastWord(string s)
        {
            //  lets try counting letters at the end
            //  its different approach instead of finding boundaries of the last word and subtract index
            //  i just cound letters of last word; its more clean simple and direct
            //  clean simple and direct so i added it here although its same time & complexity 
            //  but it actually performs better in memory, runtime and in readability
            //  same time complexity of O(n) and space O(1) as solution 1
            int count = 0, index = s.Length - 1;
            while (index >= 0)
            {
                if (s[index] != ' ')
                    count++;
                else if (count > 0)
                    return count;
                index--;
            }
            return count;
        }

        private static int Solution2(string s)
        {
            //  lol, built in solution beats by miles the intial solution
            //  but no idea about time and space complixity but on leetCode its really good
            //  but doesn't seem like problem solving practice but it actually solved the problem
            //  i am abit confused now wether to take it or not but lets try something else
            return s.Trim().Split(' ').Last().Length;
        }

        private static int Solution1(string s)
        {
            //  initial solution could be fine since its time O(n) and space O(1)
            //  but could be improved
            int startIndex = -1, endIndex = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    if (startIndex == -1)
                        startIndex = i;
                }
                else
                {
                    if (startIndex != -1)
                    {
                        endIndex = i;
                        break;
                    }
                }
            }
            return startIndex - endIndex;
        }
    }
}
