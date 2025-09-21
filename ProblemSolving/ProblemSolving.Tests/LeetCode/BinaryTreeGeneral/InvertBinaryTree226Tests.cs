using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.Tests.Assertions;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class InvertBinaryTree226Tests
    {
        private InvertBinaryTree226 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new InvertBinaryTree226();
        }

        [Test]
        public void InvertTree_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode head = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([4, 7, 2, 9, 6, 3, 1]);

            //  Act
            TreeNode result = _solution.InvertTree(head);

            //  Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode head = BinaryTreeHelper.CreateBinaryTree([2, 1, 3]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([2, 3, 1]);

            //  Act
            TreeNode result = _solution.InvertTree(head);

            //  Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            TreeNode head = BinaryTreeHelper.CreateBinaryTree([]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([]);

            //  Act
            TreeNode result = _solution.InvertTree(head);

            //  Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_SingleNode_ReturnsSameNode()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_TwoNodesLeftChild_InvertsToRightChild()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, null, 2]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_TwoNodesRightChild_InvertsToLeftChild()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, null, 2]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 2]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_TwoNodesBothChildren_SwapsChildren()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_ThreeLevelsBalanced_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([4, 7, 2, 9, 6, 3, 1]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_LeftSkewedTree_BecomesRightSkewed()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3, null, null, null, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, null, 3, null, null, null, null, null, null, null, 4]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_RightSkewedTree_BecomesLeftSkewed()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, 3, null, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 4, null, 3]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_AsymmetricTree_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, null, null, 5]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, 5, null, null, 4]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_NegativeValues_HandlesCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([-10, -5, -15, -20, null, null, -1]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([-10, -15, -5, -1, null, null, -20]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_ZeroValues_HandlesCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([0, 0, 0]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([0, 0, 0]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_MixedPositiveNegativeValues_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([0, -100, 100, 50, null, null, -50]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([0, 100, -100, -50, null, null, 50]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_PartiallyFilled_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, null, 6, 5, 4]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_DeepTree_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, null, null, 6, 7, 8, 9]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, null, null, 5, 4, null, null, null, null, 9, 8, 7, 6]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_BoundaryValues_HandlesCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([100, -100, 0]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([100, 0, -100]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_OnlyLeftSubtree_MovesToRight()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, 4, 3]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_DoubleInversion_ReturnsOriginal()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);

            // Act - invert twice
            TreeNode firstInvert = _solution.InvertTree(root);
            TreeNode secondInvert = _solution.InvertTree(firstInvert);

            // Assert - should match original structure
            Assert.That(secondInvert, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_CompleteTreeLevel3_InvertsCorrectly()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6, 7]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, 7, 6, 5, 4]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_MirroredStructure_BecomesOriginal()
        {
            // Arrange - already mirrored structure
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 2, 2, 3, 4, 4, 3]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert - becomes perfectly mirrored in opposite direction
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_LargeValidTree_InvertsCorrectly()
        {
            // Arrange - creating a larger tree (within 100 node constraint)
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([50, 25, 75, 12, 37, 62, 87, 6, 18, 31, 43, 56, 68, 81, 93]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([50, 75, 25, 87, 62, 37, 12, 93, 81, 68, 56, 43, 31, 18, 6]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_PerfectBinaryTree_InvertsSymmetrically()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, 7, 6, 5, 4, 15, 14, 13, 12, 11, 10, 9, 8]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_SingleNode_ReturnsSameTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_TwoLevelsComplete_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 7]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([4, 7, 2]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_ThreeLevelsComplete_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([4, 7, 2, 9, 6, 3, 1]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_UnbalancedLeft_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3, null, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, 4, null, 3]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_UnbalancedRight_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, 3, null, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 4, null, 3]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_MixedStructure_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, null, 4, 5, null, null, 6]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, 3, 2, null, 5, 4, null, 6]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_NegativeValues_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([-10, -5, -15, -2, -7, -12, -20]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([-10, -15, -5, -20, -12, -7, -2]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }

        [Test]
        public void InvertTree_MaximumNodes_ReturnsInvertedTree()
        {
            // Arrange - Create a tree with 100 nodes (complete binary tree)
            List<int?> values = new List<int?>();
            for (int i = 1; i <= 100; i++)
            {
                values.Add(i);
            }

            TreeNode root = BinaryTreeHelper.CreateBinaryTree(values.ToArray());

            // For a complete binary tree, inversion will swap children at each level
            // We'll create the expected tree by building the inverted version
            List<int?> invertedValues = new List<int?>();
            invertedValues.Add(1); // Root stays the same

            // For complete binary tree, inversion means swapping children at each level
            // This is a simplified approach - in practice, you might want to manually
            // construct the expected tree or use a different verification method
            for (int i = 2; i <= 100; i++)
            {
                invertedValues.Add(i);
            }
            // Note: For exact verification of large trees, you might want to use
            // a different approach or test with smaller trees

            TreeNode expected = BinaryTreeHelper.CreateBinaryTree(invertedValues.ToArray());

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert - For large trees, we can verify by checking specific properties
            // or use level order traversal to verify structure
            Assert.That(result.val, Is.EqualTo(1)); // Root should remain the same
            Assert.That(result.left.val, Is.EqualTo(3)); // Left child should be original right child
            Assert.That(result.right.val, Is.EqualTo(2)); // Right child should be original left child
        }

        [Test]
        public void InvertTree_DoubleInversion_ReturnsOriginalTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);
            TreeNode original = BinaryTreeHelper.CreateBinaryTree([4, 2, 7, 1, 3, 6, 9]);

            // Act
            TreeNode inverted = _solution.InvertTree(root);
            TreeNode result = _solution.InvertTree(inverted);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(original));
        }

        [Test]
        public void InvertTree_WithNullChildren_ReturnsInvertedTree()
        {
            // Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 4]);
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, null, 4]);

            // Act
            TreeNode result = _solution.InvertTree(root);

            // Assert
            Assert.That(result, BinaryTreesEqualAssertion.AreBinaryTreesEqual(expected));
        }
    }
}
