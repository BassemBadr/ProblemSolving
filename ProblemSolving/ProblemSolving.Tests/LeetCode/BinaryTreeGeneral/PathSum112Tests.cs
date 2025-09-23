using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class PathSum112Tests
    {
        private PathSum112 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new PathSum112();
        }

        [Test]
        public void HasPathSum_Example1_ShouldReturnTrue()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);
            int targetSum = 22;

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void HasPathSum_Example2_ShouldReturnFalse()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            int targetSum = 5;

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void HasPathSum_Example3_ShouldReturnFalse()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([]);
            int targetSum = 0;

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(0, false)]
        [TestCase(5, false)]
        public void HasPathSum_EmptyTree_ReturnsFalse(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = null;

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert & Act
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void HasPathSum_SingleNodeMatchingTarget_ReturnsTrue()
        {
            //  Arrange
            TreeNode root = new TreeNode(5);

            //  Act
            bool result = _solution.HasPathSum(root, 5);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void HasPathSum_SingleNodeDifferentTarget_ReturnsFalse()
        {
            //  Arrange
            TreeNode root = new TreeNode(5);

            //  Act
            bool result = _solution.HasPathSum(root, 10);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(3, true)]
        [TestCase(4, true)]
        public void HasPathSum_BalancedTreeWithValidPath_ReturnsTrue(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, false)]
        [TestCase(5, false)]
        public void HasPathSum_BalancedTreeNoValidPath_ReturnsFalse(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(22, true)]
        [TestCase(26, true)]
        [TestCase(18, true)]
        public void HasPathSum_ComplexTreeWithValidPath_ReturnsTrue(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, null, null, 1]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, false)]
        [TestCase(30, false)]
        public void HasPathSum_ComplexTreeNoValidPath_ReturnsFalse(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-5, true)]
        [TestCase(-2, false)]
        public void HasPathSum_TreeWithNegativeValues_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([-2, null, -3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HasPathSum_TreeWithZeroValues_ReturnsCorrectResult()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([0, 1, 0, null, null, 1, 0]);

            //  Act
            bool result = _solution.HasPathSum(root, 1);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(15, true)]
        [TestCase(6, false)]
        public void HasPathSum_LinearTree_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3,
                        new TreeNode(4,
                            new TreeNode(5)))));

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, true)]
        [TestCase(-2, true)]
        public void HasPathSum_SumEqualsZero_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, -3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2000, true)]
        [TestCase(0, true)]
        public void HasPathSum_BoundaryValues_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1000, 500, -1000, 500]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HasPathSum_IntermediateSumMatchesButNotLeaf_ReturnsFalse()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.HasPathSum(root, 3);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(6, true)]
        [TestCase(3, false)]
        public void HasPathSum_OnlyLeftChildren_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(6, true)]
        [TestCase(3, false)]
        public void HasPathSum_OnlyRightChildren_ReturnsCorrectResult(int targetSum, bool expected)
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, null, 3]);

            //  Act
            bool result = _solution.HasPathSum(root, targetSum);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
