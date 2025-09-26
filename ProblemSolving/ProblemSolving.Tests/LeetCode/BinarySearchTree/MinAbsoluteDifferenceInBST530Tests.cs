using ProblemSolving.LeetCode.BinarySearchTree;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinarySearchTree
{
    [TestFixture]
    public class MinAbsoluteDifferenceInBST530Tests
    {
        private MinAbsoluteDifferenceInBST530 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MinAbsoluteDifferenceInBST530();
        }

        [Test]
        public void GetMinimumDifference_Example1_ShouldReturn1()
        {
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 6, 1, 3]);
            int expected = 1;

            int result = _solution.GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMinimumDifference_Example2_ShouldReturn1()
        {
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 0, 48, null, null, 12, 49]);
            int expected = 1;

            int result = _solution.GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMinimumDifference_LargerGaps_ReturnsCorrectMin()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5,
                    new TreeNode(3),
                    new TreeNode(8)),
                new TreeNode(15,
                    new TreeNode(12),
                    new TreeNode(20)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(2));
        }

        [Test]
        public void GetMinimumDifference_MinAtRoot_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(100,
                new TreeNode(50,
                    new TreeNode(49),
                    new TreeNode(51)),
                new TreeNode(150));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(1));
        }

        [Test]
        public void GetMinimumDifference_TwoNodes_ReturnsDifference()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(5));
        }

        [Test]
        public void GetMinimumDifference_ThreeNodesStraight_ReturnsMinDiff()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5,
                    new TreeNode(3)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(2));
        }

        [Test]
        public void GetMinimumDifference_PositiveValuesOnly_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5,
                    new TreeNode(1),
                    new TreeNode(7)),
                new TreeNode(15,
                    new TreeNode(12),
                    new TreeNode(20)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(2));
        }

        [Test]
        public void GetMinimumDifference_DuplicateDifferences_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(2),
                    new TreeNode(4)),
                new TreeNode(7,
                    new TreeNode(6),
                    new TreeNode(8)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(1));
        }

        [Test]
        public void GetMinimumDifference_MinAtLeafLevel_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(50,
                new TreeNode(30,
                    new TreeNode(20),
                    new TreeNode(40,
                        new TreeNode(35),
                        new TreeNode(45))),
                new TreeNode(70,
                    new TreeNode(60),
                    new TreeNode(80)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(5));
        }

        [Test]
        public void GetMinimumDifference_BoundaryValues_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(100000,
                new TreeNode(0,
                    null,
                    new TreeNode(50000)));

            int result = _solution.GetMinimumDifference(root);
            Assert.That(result, Is.EqualTo(50000));
        }

        [Test]
        public void GetMinimumDifference_RightSkewedBST_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(1,
                null,
                new TreeNode(2,
                    null,
                    new TreeNode(3,
                        null,
                        new TreeNode(4))));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(1));
        }

        [Test]
        public void GetMinimumDifference_LeftSkewedBST_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(4,
                new TreeNode(3,
                    new TreeNode(2,
                        new TreeNode(1))));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(1));
        }

        [Test]
        public void GetMinimumDifference_MultipleMinCandidates_ReturnsSmallest()
        {
            TreeNode root = new TreeNode(100,
                new TreeNode(50,
                    new TreeNode(25,
                        new TreeNode(10),
                        new TreeNode(40)),
                    new TreeNode(75,
                        new TreeNode(60),
                        new TreeNode(90))),
                new TreeNode(150,
                    new TreeNode(125,
                        new TreeNode(110),
                        new TreeNode(140)),
                    new TreeNode(175,
                        new TreeNode(160),
                        new TreeNode(200))));

            int result = _solution.GetMinimumDifference(root);
            Assert.That(result, Is.GreaterThan(0));
        }

        [Test]
        public void GetMinimumDifference_MinimumSizeTree_ReturnsDifference()
        {
            TreeNode root = new TreeNode(100,
                new TreeNode(50));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(50));
        }

        [Test]
        public void GetMinimumDifference_MinBetweenDistantNodes_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5,
                    new TreeNode(4),
                    new TreeNode(8,
                        null,
                        new TreeNode(9))),
                new TreeNode(15,
                    new TreeNode(12),
                    new TreeNode(18)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(1));
        }

        [Test]
        public void GetMinimumDifference_LargerTree_PerformsCorrectly()
        {
            TreeNode root = CreateBalancedBST(1, 100);

            int result = _solution.GetMinimumDifference(root);

            Assert.That(result, Is.EqualTo(1));
        }

        private TreeNode CreateBalancedBST(int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(mid);
            root.left = CreateBalancedBST(start, mid - 1);
            root.right = CreateBalancedBST(mid + 1, end);

            return root;
        }

        [Test]
        public void GetMinimumDifference_WithZeroValues_ReturnsCorrect()
        {
            TreeNode root = new TreeNode(10,
                new TreeNode(5,
                    new TreeNode(0),
                    new TreeNode(8)),
                new TreeNode(15,
                    new TreeNode(12),
                    new TreeNode(20)));

            Assert.That(_solution.GetMinimumDifference(root), Is.EqualTo(2));
        }
    }
}
