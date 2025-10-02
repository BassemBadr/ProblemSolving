namespace ProblemSolving.LeetCode.BitManipulation
{
    public class NumberOf1Bits191
    {
        static int[] lookup256 = new int[256];
        public NumberOf1Bits191()
        {
            lookup256[0] = 0;
            for (int i = 0; i < 256; i++)
            {
                lookup256[i] = (i & 1) + lookup256[i / 2];
            }
        }

        public int HammingWeight(int n)
        {
            //  for the followup would create lookup table storing the one's count for 0=> 255
            //  then divide n to 4 X 8 bit segments and count 1's for each segment using lookup
            return (lookup256[n & 0xff] + lookup256[(n >> 8) & 0xff] + lookup256[(n >> 16) & 0xff] + lookup256[n >> 24]);
        }

        private static int Solution3(int n)
        {
            //  found a solution called Brian Kernighan algorithm
            //  it depends performing bitwise & between n and n-1 
            //  with each iteration a 1 from the set bits is removed leading to No. of iterations = No. of ones
            //  time O(log n)   but in reality its faster
            //  space O(1)
            int result = 0;
            while (n > 0)
            {
                n &= (n - 1);
                result++;
            }
            return result;
        }

        private static int Solution2(int n)
        {
            //  alittle cleaned up version
            //  time O(log n)
            //  space O(1)
            int result = 0;
            while (n > 0)
            {
                result += n & 1;
                n >>= 1;
            }
            return result;
        }

        private static int Solution1(int n)
        {
            //  time O(log n)
            //  space O(1)
            int testNumber = n;
            int result = 0;
            while (testNumber != 0)
            {
                if ((testNumber & 1) == 1)
                    result++;
                testNumber >>= 1;
            }
            return result;
        }
    }
}
