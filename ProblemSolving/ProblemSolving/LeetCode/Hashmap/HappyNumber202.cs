namespace ProblemSolving.LeetCode.Hashmap
{
    public class HappyNumber202
    {
        //https://leetcode.com/problems/happy-number
        public bool IsHappy(int n)
        {
            //  found this solution on https://www.geeksforgeeks.org/dsa/happy-number/
            //  it moves on two separate steps one fast (two calculations at a time) and one slow (one calculation at a time)
            //  its based on Floyd's Cycle-Finding Algorithm (tortoise and hare) 
            int slow, fast;

            slow = fast = n;
            do
            {
                slow = GetDigitSquareSum(slow);

                fast = GetDigitSquareSum(GetDigitSquareSum(fast));
            }
            while (slow != fast);

            return (slow == 1);
        }

        private bool Solution2(int n)
        {
            //  total time complexity O(k * log n) where k is number of iterations for the given number
            //  space complexity of O(n)
            HashSet<int> visited = new HashSet<int>();

            int squareSum = n;
            while (!visited.Contains(squareSum))
            {
                visited.Add(squareSum);
                squareSum = GetDigitSquareSum(squareSum);

                if (squareSum == 1)
                    return true;
            }
            return false;
        }

        private int GetDigitSquareSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (digit * digit);
                number = number / 10;
            }

            return sum;
        }

        private static bool Solution1(int n)
        {
            HashSet<int> visited = new HashSet<int>();

            int squareSum = n;
            while (!visited.Contains(squareSum))
            {
                int stepSum = 0;
                visited.Add(squareSum);
                while (squareSum > 0)
                {
                    int digit = squareSum % 10;
                    stepSum += (digit * digit);
                    squareSum = squareSum / 10;
                }

                if (stepSum == 1)
                    return true;
                else
                    squareSum = stepSum;
            }
            return false;
        }
    }
}
