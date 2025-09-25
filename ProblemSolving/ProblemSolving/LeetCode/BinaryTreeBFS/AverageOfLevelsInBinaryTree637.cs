using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeBFS
{
    public class AverageOfLevelsInBinaryTree637
    {
        //https://leetcode.com/problems/average-of-levels-in-binary-tree
        public IList<double> AverageOfLevels(TreeNode root)
        {
            //  time O(n)
            //  space O(n)
            if (root == null) return [];

            List<double> averages = [];
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                double levelSum = 0;

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    levelSum += node.val;

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                averages.Add(levelSum / levelSize);
            }

            return averages;
        }

        private static IList<double> Solution3(TreeNode root)
        {
            if (root == null) return [];

            double[] sums = new double[10000];
            int[] counts = new int[10000];

            Queue<Tuple<TreeNode, int>> queue = new();
            queue.Enqueue(new(root, 0));

            while (queue.Count > 0)
            {
                (TreeNode node, int lvl) = queue.Dequeue();

                sums[lvl] += node.val;
                counts[lvl]++;

                if (node.left != null)
                    queue.Enqueue(new(node.left, lvl + 1));
                if (node.right != null)
                    queue.Enqueue(new(node.right, lvl + 1));
            }

            IList<double> result = [];

            for (int i = 0; i < sums.Length; i++)
            {
                if (counts[i] != 0)
                {
                    result.Add(sums[i] / counts[i]);
                }
                else
                    break;
            }

            return result;
        }

        private IList<double> Solution2(TreeNode root)
        {
            if (root == null) return null;
            Dictionary<int, double> sum = [];
            Dictionary<int, int> count = [];
            calculateTreeAverage(root, 1, sum, count);
            return sum.Select(a => a.Value / count[a.Key]).ToList();
        }

        private void calculateTreeAverage(TreeNode root, int lvl, Dictionary<int, double> sum, Dictionary<int, int> count)
        {
            if (root == null) return;
            if (sum.ContainsKey(lvl))
            {
                sum[lvl] += root.val;
                count[lvl]++;
            }
            else
            {
                sum[lvl] = root.val;
                count[lvl] = 1;
            }
            calculateTreeAverage(root.left, lvl + 1, sum, count);
            calculateTreeAverage(root.right, lvl + 1, sum, count);
        }

        private static IList<double> Solution1(TreeNode root)
        {
            if (root == null) return null;

            Dictionary<int, (double, int)> levelSumCount = [];

            Queue<Tuple<TreeNode, int>> queue = new();
            queue.Enqueue(new(root, 1));

            while (queue.Count > 0)
            {
                (TreeNode node, int lvl) = queue.Dequeue();

                if (levelSumCount.TryGetValue(lvl, out (double, int) value))
                {
                    (double sum, int count) = value;
                    levelSumCount[lvl] = new(sum + node.val, count + 1);
                }
                else
                {
                    levelSumCount[lvl] = new(node.val, 1);
                }

                if (node.left != null)
                    queue.Enqueue(new(node.left, lvl + 1));
                if (node.right != null)
                    queue.Enqueue(new(node.right, lvl + 1));
            }

            IList<double> result = [];

            foreach (var item in levelSumCount)
            {
                result.Add(item.Value.Item1 / item.Value.Item2 * 1.0);
            }

            return result;
        }
    }
}
