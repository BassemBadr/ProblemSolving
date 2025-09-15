namespace ProblemSolving.LeetCode.Stack
{
    public class ValidParentheses20
    {
        //https://leetcode.com/problems/valid-parentheses
        public bool IsValid(string s)
        {
            int l = s.Length;
            if (l == 0)
                return true;

            if ((l & 1) == 1)
                return false;

            char[] stack = new char[l];
            int topIndex = -1;

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack[++topIndex] = c;
                }

                else
                {
                    if (topIndex == -1) return false;

                    char top = stack[topIndex];
                    topIndex--;
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                   
                }
            }

            return topIndex == -1;
        }

        private static bool Solution4(string s)
        {
            int l = s.Length;
            if (l == 0)
                return true;

            if ((l & 1) == 1)
                return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private bool Solution3(string s)
        {
            int l = s.Length;
            if (l == 0)
                return true;

            if (l % 2 == 1)
                return false;

            Stack<char> stack = new();
            HashSet<char> opening = ['(', '[', '{',];

            foreach (char c in s)
            {
                if (opening.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if (c != GetClosingParenthes(top))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        char GetClosingParenthes(char c)
        {
            switch (c)
            {
                case '(': return ')';
                case '[': return ']';
                case '{': return '}';
            }
            return char.MinValue;
        }

        private static bool Solution2(string s)
        {
            //  time O(n)
            //  space O(n)
            Stack<char> stack = new();

            Dictionary<char, char> parentheses = new Dictionary<char, char> {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            foreach (char c in s)
            {
                if (parentheses.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if (c != parentheses[top])
                        return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool Solution1(string s)
        {
            //  time O(n)
            //  space O(n)

            Stack<char> stack = new();

            Dictionary<char, char> parentheses = new Dictionary<char, char> {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.TryPeek(out char c))
                {
                    if (parentheses[c] == s[i]) //  check if the new item is its closing parentheses
                    {
                        stack.Pop();
                    }
                    else if (parentheses.ContainsKey(s[i]))
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (parentheses.ContainsKey(s[i]))
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        private int GetParenthesValue(char p)
        {
            switch (p)
            {
                case '(': return 1;
                case ')': return -1;
                case '{': return 2;
                case '}': return -2;
                case '[': return 3;
                case ']': return -3;
            }
            return 0;
        }
    }
}
