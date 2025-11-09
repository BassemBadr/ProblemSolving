namespace ProblemSolving.LeetCode.MathLogic
{
    public class SquareRoot69
    {
        public int MySqrt(int x)
        {
            //  binary search for the nearest square root
            //  time O(log x)
            //  space O(1)

            if (x < 2) return x;

            int left = 1, right = x / 2;
            while (left <= right)
            {
                int mid = left + +(right - left) / 2;
                long square = (long)mid * mid;
                if (square == x) return mid;
                else if (square < x) left = mid + 1;
                else right = mid - 1;
            }
            return right;
        }

        private static int Solution1(ref int x)
        {
            //  mathimatical approach
            //  time O(√n)
            //  space O(1)
            int index = 0;
            int odd = 1;
            while (x > 0)
            {
                x -= odd;
                odd += 2;
                index++;
            }
            if (x < 0)
                index--;
            return index;
        }
    }
}
