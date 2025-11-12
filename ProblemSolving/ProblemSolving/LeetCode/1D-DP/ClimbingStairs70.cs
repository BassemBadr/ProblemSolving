namespace ProblemSolving.LeetCode._1D_DP
{
    public class ClimbingStairs70
    {
        public int ClimbStairs(int n)
        {
            //  time O(n)
            //  space O(1)
            if (n <= 1) return 1;
            int prev1 = 1, prev2 = 1;

            for (int i = 2; i <= n; i++)
            {
                int current = prev1;
                prev1 = prev1 + prev2;
                prev2 = current;
            }
            return prev1;
        }

        private int RecursiveSolution(int n)
        {
            //  time O(2^n)
            //  space O(n)
            if (n == 0) return 1;
            if (n == 1) return 1;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
