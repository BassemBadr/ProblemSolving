using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.LeetCode.Types;
using ProblemSolving.Tests.Helpers;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class MaximumDepthOfBinaryTree104Tests
    {
        private MaximumDepthOfBinaryTree104 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MaximumDepthOfBinaryTree104();
        }

        [Test]
        public void MaxDepth_Example1_ShouldReturn3()
        {
            //  Arrange
            TreeNode head = BinaryTreeHelper.CreateBinaryTree([3, 9, 20, null, null, 15, 7]);
            int expected = 3;

            //  Act
            int result = _solution.MaxDepth(head);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MaxDepth_Example2_ShouldReturn2()
        {
            //  Arrange
            TreeNode head = BinaryTreeHelper.CreateBinaryTree([1, null, 2]);
            int expected = 2;

            //  Act
            int result = _solution.MaxDepth(head);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // 1. Edge Cases
        [Test]
        public void MaxDepth_NullTree_ReturnsZero()
        {
            //  Act
            int result = _solution.MaxDepth(null);

            //  Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MaxDepth_SingleNode_ReturnsOne()
        {
            //  Arrange
            TreeNode root = new TreeNode(5);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(1));
        }

        // 2. Balanced Trees
        [Test]
        public void MaxDepth_CompleteBinaryTreeDepth2_Returns3()
        {
            // Tree: 
            //     1
            //    / \
            //   2   3
            //  / \ / \
            // 4  5 6 7

            //  Arrange            
            int?[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void MaxDepth_CompleteBinaryTreeDepth3_Returns4()
        {
            //  Arrange
            int?[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(4));
        }

        // 3. Unbalanced Trees (Left-skewed)
        [Test]
        public void MaxDepth_LeftSkewedTree_ReturnsMaxDepth()
        {
            // Tree:
            //     1
            //    /
            //   2
            //  /
            // 3
            ///
            //4

            //  Arrange
            int?[] arr = { 1, 2, null, 3, null, null, null, 4 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(4));
        }

        // 4. Unbalanced Trees (Right-skewed)
        [Test]
        public void MaxDepth_RightSkewedTree_ReturnsMaxDepth()
        {
            // Tree:
            // 1
            //  \
            //   2
            //    \
            //     3
            //      \
            //       4

            //  Arrange
            int?[] arr = { 1, null, 2, null, null, null, 3, null, null, null, null, null, null, null, 4 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(4));
        }

        // 5. Mixed Unbalanced Trees
        [Test]
        public void MaxDepth_MixedUnbalancedTree_ReturnsCorrectDepth()
        {
            // Tree:
            //     1
            //    / \
            //   2   3
            //  /     \
            // 4       5
            //          \
            //           6

            //  Arrange
            int?[] arr = { 1, 2, 3, 4, null, null, 5, null, null, null, null, null, null, null, 6 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(4));
        }

        // 6. Trees with Null Values
        [Test]
        public void MaxDepth_TreeWithMissingNodes_ReturnsCorrectDepth()
        {
            // Tree:
            //     1
            //    / \
            //   2   null
            //  / \
            // 4   5

            //  Arrange
            int?[] arr = { 1, 2, null, 4, 5 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void MaxDepth_SparseTree_ReturnsCorrectDepth()
        {
            // Tree:
            //     1
            //      \
            //       3
            //      /
            //     6

            //  Arrange
            int?[] arr = { 1, null, 3, null, null, 6 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(3));
        }

        // 7. Boundary Value Tests (Within constraints)
        [Test]
        public void MaxDepth_MaximumDepthTree_ReturnsMaxDepth()
        {
            // Create a tree with maximum possible depth (104 nodes in a chain)
            // This tests the upper constraint boundary

            //  Arrange
            TreeNode root = new TreeNode(0);
            TreeNode current = root;

            for (int i = 1; i < 104; i++) // 104 nodes total, depth = 104
            {
                current.right = new TreeNode(i);
                current = current.right;
            }

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(104));
        }

        [Test]
        public void MaxDepth_LargeBalancedTree_ReturnsLog2Depth()
        {
            // Create a nearly complete binary tree with many nodes
            // Depth should be approximately log2(n)
            // For 100 nodes in complete tree, depth = floor(log2(100)) + 1 ≈ 7

            //  Arrange
            int?[] arr = new int?[100]; // Large array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i; // Fill with values
            }
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(7)); // 2^6 = 64, 2^7 = 128 → depth = 7
        }

        // 8. Value Boundary Tests
        [Test]
        public void MaxDepth_MinValueNode_ReturnsCorrectDepth()
        {
            //  Arrange
            TreeNode root = new TreeNode(-100);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void MaxDepth_MaxValueNode_ReturnsCorrectDepth()
        {
            //  Arrange
            TreeNode root = new TreeNode(100);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void MaxDepth_MixedBoundaryValues_ReturnsCorrectDepth()
        {
            // Tree with min and max values

            //  Arrange
            int?[] arr = { -100, 0, 100 };
            TreeNode root = BinaryTreeHelper.CreateBinaryTree(arr);

            //  Act
            int result = _solution.MaxDepth(root);

            //  Assert
            Assert.That(result, Is.EqualTo(2));
        }

        // 10. Performance Test (Within constraints)
        [Test]
        [Timeout(1000)] // Should complete within 1 second
        public void MaxDepth_LargeTree_PerformanceTest()
        {
            // Create a large tree with 10,000 nodes (within 10^4 constraint)

            //  Arrange
            int?[] largeArray = new int?[10000];
            for (int i = 0; i < largeArray.Length; i++)
            {
                largeArray[i] = i % 100; // Fill with values within range
            }

            TreeNode root = BinaryTreeHelper.CreateBinaryTree(largeArray);

            //  Act
            int result = _solution.MaxDepth(root);

            // Just verify it doesn't crash and returns a reasonable value

            //  Assert
            Assert.Greater(result, 0);
            Assert.LessOrEqual(result, 10000);
        }
    }
}
