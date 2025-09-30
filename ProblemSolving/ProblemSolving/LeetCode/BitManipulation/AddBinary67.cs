using System.Text;

namespace ProblemSolving.LeetCode.BitManipulation
{
    public class AddBinary67
    {
        //https://leetcode.com/problems/add-binary
        public string AddBinary(string a, string b)
        {
            //  this solution has a neat shortcut
            //  a[i--] - '0' this line converts binary character to int because '0' = 48 and '1' = 49 so '0' - '0' = 48 - 48 = 0 and '1' - '0' = 49 - 48 = 1
            StringBuilder result = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';

                result.Append(sum % 2);
                carry = sum / 2;
            }

            char[] array = result.ToString().ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        private static string Solution2(string a, string b)
        {
            //  tried to simplify the solution alittle
            //  time O(max(m,n))
            //  space O(max(m,n)) where m = length of a and n is length of b
            int i = a.Length - 1;
            int j = b.Length - 1;
            Stack<char> result = [];
            char carry = '0';
            while (i >= 0 || j >= 0 || carry == '1')
            {
                char bitA = i >= 0 ? a[i] : '0';
                char bitB = j >= 0 ? b[j] : '0';
                if (bitA != bitB)
                {
                    // XOR case: 1+0 or 0+1
                    result.Push(carry == '0' ? '1' : '0');
                }
                else
                {
                    // Both bits are same: 0+0 or 1+1
                    result.Push(carry);
                    carry = bitA;
                }

                i--;
                j--;
            }

            StringBuilder builder = new StringBuilder();
            while (result.Count != 0)
            {
                builder.Append(result.Pop());
            }
            return builder.ToString();
        }

        private static string Solution1(string a, string b)
        {
            //  the straight forward math solution, wanted to just get it out of my mind
            //  this is like the mathimatical approach as if being done on paper
            Stack<char> result = [];
            int index = 0, carry = 0;
            int minLength = Math.Min(a.Length, b.Length);
            while (index < minLength)
            {
                char b1 = a[a.Length - 1 - index];
                char b2 = b[b.Length - 1 - index];
                if (b1 != b2)
                {
                    if (carry == 0)
                        result.Push('1');
                    else
                    {
                        result.Push('0');
                        carry = 1;
                    }
                }
                else
                {
                    if (carry == 0)
                        result.Push('0');
                    else
                    {
                        result.Push('1');
                        carry = 0;
                    }

                    if (b1 == '1')
                        carry = 1;
                }
                index++;
            }
            if (a.Length != b.Length)
            {
                string s = a.Length > b.Length ? a : b;
                while (index < s.Length)
                {
                    char b1 = s[s.Length - 1 - index];
                    if (carry == 1)
                    {
                        if (b1 == '0')
                        {
                            result.Push('1');
                            carry = 0;
                        }
                        else
                        {
                            result.Push('0');
                            carry = 1;
                        }
                    }
                    else
                    {
                        result.Push(b1);
                    }
                    index++;
                }
            }

            if (carry == 1)
                result.Push('1');

            StringBuilder builder = new StringBuilder();
            while (result.Count != 0)
            {
                builder.Append(result.Pop());
            }
            return builder.ToString();
        }
    }
}
