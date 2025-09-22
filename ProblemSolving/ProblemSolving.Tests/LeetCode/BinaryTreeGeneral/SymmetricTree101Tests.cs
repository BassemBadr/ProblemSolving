using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class SymmetricTree101Tests
    {
        private SymmetricTree101 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SymmetricTree101();
        }

        [Test]
        public void IsSymmetric_Example1_ShouldReturnTrue()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_Example2_ShouldReturnFalse()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, null, 3, null, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_EmptyTree_ReturnsTrue()
        {
            // Arrange
            TreeNode root = null;

            //  Act
            bool result = _solution.IsSymmetric(root);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_SingleNode_ReturnsTrue()
        {
            //  Arrange
            TreeNode root = new TreeNode(1);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_SymmetricTwoLevels_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_AsymmetricTwoLevels_ReturnsFalse()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_SymmetricThreeLevels_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_AsymmetricThreeLevels_ReturnsFalse()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 3, 4]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_MirrorValuesButDifferentStructure_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, null, null, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_ComplexSymmetricTree_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3, null, null, 6, 7, 7, 6]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_ComplexAsymmetricTree_ReturnsFalse()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3, null, null, 6, 7, 7, 5]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_UnbalancedTree_ReturnsFalse()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 3]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_NegativeValuesSymmetric_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([-10, -5, -5]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_MixedPositiveNegativeSymmetric_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([0, -5, -5]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_LargeValues_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([100, -100, -100]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSymmetric_OneChildNull_ReturnsFalse()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSymmetric_DeepSymmetricTree_ReturnsTrue()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 6, 6, 3, 4, 5, 7, 8, 8, 7, 5, 4]);

            //  Act
            bool result = _solution.IsSymmetric(root);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
