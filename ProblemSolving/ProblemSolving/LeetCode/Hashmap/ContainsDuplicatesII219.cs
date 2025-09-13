namespace ProblemSolving.LeetCode.Hashmap
{
    public class ContainsDuplicatesII219
    {
        //https://leetcode.com/problems/contains-duplicate-ii
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            return Solution3(nums, k);
        }

        private static bool Solution3(int[] nums, int k)
        {
            //  time O(n)
            //  space O(n)            

            if (k == 0) return false;

            Dictionary<int, int> keyLastSeen = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyLastSeen.TryGetValue(nums[i], out int value))
                {
                    if (Math.Abs(value - i) <= k) return true;
                }
                keyLastSeen[nums[i]] = i;
            }
            return false;
        }

        private static bool AnotherSolution(int[] nums, int k)
        {
            //  source: https://www.geeksforgeeks.org/dsa/check-given-array-contains-duplicate-elements-within-k-distance/
            //  the idea is to create a sliding window of the size of k using a hashset 
            //  and if any duplication is detected within the window return true
            //  time O(n)
            //  space O(k)

            HashSet<int> set = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                    return true;

                set.Add(nums[i]);

                if (i >= k)
                    set.Remove(nums[i - k]);
            }
            return false;
        }

        private static bool Solution2(int[] nums, int k)
        {
            //  after more inspection to the problem
            //  if k is the max distance then i need to register only last seen index of each element and compare it with the current 
            //  in case a match is found because if the current and last seen > k then any next index found would be > k as well when compared to the first
            //  then storing only last seen and compare with current at any moment is more sensible approach
            //  time O(n)
            //  space O(n)
            //  lets do alittle clean up

            if (k == 0) return false;

            Dictionary<int, int> keyLastSeen = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyLastSeen.TryGetValue(nums[i], out int value))
                    keyLastSeen.Add(nums[i], i);
                else
                {
                    if (Math.Abs(value - i) <= k) return true;
                    else keyLastSeen[nums[i]] = i;
                }
            }
            return false;
        }

        private static bool Solution1(int[] nums, int k)
        {
            //  this is absolutely bad solution, it works with the cases the the nested loops means the performance would be so bad 
            //  time complexity would be  O(n ^ 2)
            //  space would be O(n)

            if (k == 0) return false;

            Dictionary<int, List<int>> keyIndeces = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyIndeces.ContainsKey(nums[i]))
                    keyIndeces.Add(nums[i], []);

                keyIndeces[nums[i]].Add(i);
            }

            foreach (var item in keyIndeces)
            {
                if (item.Value.Count <= 1)
                    continue;

                for (int i = 0; i < item.Value.Count; i++)
                {
                    for (int j = i + 1; j < item.Value.Count; j++)
                    {
                        if (Math.Abs(item.Value[i] - item.Value[j]) <= k)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
