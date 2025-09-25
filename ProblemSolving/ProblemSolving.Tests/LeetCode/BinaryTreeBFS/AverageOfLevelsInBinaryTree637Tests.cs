using ProblemSolving.LeetCode.BinaryTreeBFS;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeBFS
{
    [TestFixture]
    public class AverageOfLevelsInBinaryTree637Tests
    {
        private AverageOfLevelsInBinaryTree637 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new AverageOfLevelsInBinaryTree637();
        }

        [Test]
        public void AverageOfLevels_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([3, 9, 20, null, null, 15, 7]);
            IList<double> expected = [3.00000, 14.50000, 11.00000];

            //  Act
            IList<double> result = _solution.AverageOfLevels(root);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void AverageOfLevels_LargeNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([2147483647, 2147483647, 2147483647]);
            IList<double> expected = [2147483647.00000, 2147483647.00000];

            //  Act
            IList<double> result = _solution.AverageOfLevels(root);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void AverageOfLevels_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([3, 9, 20, 15, 7]);
            IList<double> expected = [3.00000, 14.50000, 11.00000];

            //  Act
            IList<double> result = _solution.AverageOfLevels(root);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void AverageOfLevels_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([98, 97, null, 88, null, 84, null, 79, 87, 64, null, null, null, 63, 69, 62, null, null, null, 30, null, 27, 59, 9, null, null, null, 3, null, 0, null, -4, null, -16, null, -18, -7, -19, null, null, null, -23, null, -34, null, -42, null, -59, null, -63, null, -64, null, -69, null, -75, null, -81]);
            IList<double> expected = [98, 97, 88, 83, 62, -4];

            //  Act
            IList<double> result = _solution.AverageOfLevels(root);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void AverageOfLevels_SingleNode_ReturnsSingleValue()
        {
            // Arrange
            TreeNode root = new TreeNode(5);
            double[] expected = [5.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_PerfectBinaryTree_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(7)));
            double[] expected = [1.00000, 2.50000, 5.50000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_UnbalancedTree_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3,
                        new TreeNode(4))),
                null);
            double[] expected = [1.00000, 2.00000, 3.00000, 4.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_NegativeValues_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(-2,
                    new TreeNode(-4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(-6),
                    new TreeNode(7)));
            double[] expected = [1.00000, 0.50000, 0.50000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_LargeValues_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(int.MaxValue,
                new TreeNode(int.MaxValue / 2),
                new TreeNode(int.MaxValue / 2));
            double expectedLevel0 = int.MaxValue;
            double expectedLevel1 = int.MaxValue / 2;

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result[0], Is.EqualTo(expectedLevel0).Within(0.00001));
            Assert.That(result[1], Is.EqualTo(expectedLevel1).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_DecimalAverages_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3));
            double[] expected = [1.00000, 2.50000, 4.50000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_OnlyLeftChildren_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3,
                        new TreeNode(4))),
                null);
            double[] expected = [1.00000, 2.00000, 3.00000, 4.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }


        [Test]
        public void AverageOfLevels_OnlyRightChildren_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                null,
                new TreeNode(2,
                    null,
                    new TreeNode(3,
                        null,
                        new TreeNode(4))));
            double[] expected = [1.00000, 2.00000, 3.00000, 4.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_RepeatingValues_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(5,
                new TreeNode(5,
                    new TreeNode(5),
                    new TreeNode(5)),
                new TreeNode(5,
                    new TreeNode(5),
                    new TreeNode(5)));
            double[] expected = [5.00000, 5.00000, 5.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_MixedPositiveNegative_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(10,
                new TreeNode(-5,
                    new TreeNode(15),
                    new TreeNode(-10)),
                new TreeNode(20,
                    new TreeNode(25),
                    new TreeNode(-15)));
            double[] expected = [10.00000, 7.50000, 3.75000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_LargeTree_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = CreateLargeTree(100);

            // Act - should not throw exception
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert - should have correct number of levels
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void AverageOfLevels_ZeroValues_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(0,
                new TreeNode(0,
                    new TreeNode(0)),
                new TreeNode(0));
            double[] expected = [0.00000, 0.00000, 0.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void AverageOfLevels_AlternatingPattern_ReturnsCorrectAverages()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(10,
                    new TreeNode(1000)),
                new TreeNode(100,
                    new TreeNode(10000)));
            double[] expected = [1.00000, 55.00000, 5500.00000];

            // Act
            IList<double> result = _solution.AverageOfLevels(root);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.00001));
        }

        private TreeNode CreateLargeTree(int nodeCount)
        {
            if (nodeCount <= 0) return null;

            TreeNode root = new TreeNode(1);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int count = 1;

            while (count < nodeCount && queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                if (count < nodeCount)
                {
                    current.left = new TreeNode(++count);
                    queue.Enqueue(current.left);
                }
                if (count < nodeCount)
                {
                    current.right = new TreeNode(++count);
                    queue.Enqueue(current.right);
                }
            }

            return root;
        }
    }
}
