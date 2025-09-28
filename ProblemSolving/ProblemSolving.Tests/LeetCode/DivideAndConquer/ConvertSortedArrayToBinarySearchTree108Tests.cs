using ProblemSolving.LeetCode.DivideAndConquer;
using ProblemSolving.Tests.Assertions;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.DivideAndConquer
{
    [TestFixture]
    public class ConvertSortedArrayToBinarySearchTree108Tests
    {
        private ConvertSortedArrayToBinarySearchTree108 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ConvertSortedArrayToBinarySearchTree108();
        }

        [Test]
        public void SortedArrayToBST_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -3, 0, 5, 9];

            //  Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            //  Assert
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);

        }

        [Test]
        public void SortedArrayToBST_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3];
            TreeNode expected = BinaryTreeHelper.CreateBinaryTree([3, 1]);

            //  Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            //  Assert
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);

        }

        // Test Case 1: Single element array
        [Test]
        public void SortedArrayToBST_SingleElement_ReturnsSingleNode()
        {
            // Arrange
            int[] nums = [5];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.val, Is.EqualTo(5));
            Assert.That(result.left, Is.Null);
            Assert.That(result.right, Is.Null);
        }

        // Test Case 2: Two elements array
        [Test]
        public void SortedArrayToBST_TwoElements_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [1, 2];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            // Should be: [2,1] or [1,null,2] - both are valid
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
        }

        // Test Case 3: Three elements array
        [Test]
        public void SortedArrayToBST_ThreeElements_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [1, 2, 3];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.val, Is.EqualTo(2)); // Root should be middle element
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
        }

        // Test Case 4: Odd number of elements
        [Test]
        public void SortedArrayToBST_OddLength_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [-10, -3, 0, 5, 9];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 5: Even number of elements
        [Test]
        public void SortedArrayToBST_EvenLength_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 6: Array with negative values
        [Test]
        public void SortedArrayToBST_NegativeValues_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [-10, -5, -3, -1, 0, 1, 3, 5, 10];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 7: Array with duplicate differences (consecutive numbers)
        [Test]
        public void SortedArrayToBST_ConsecutiveNumbers_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 8: Large array within constraints
        [Test]
        public void SortedArrayToBST_LargeArray_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = Enumerable.Range(1, 100).ToArray();

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);

            // Verify height is logarithmic
            int height = GetHeight(result);
            int maxExpectedHeight = (int)Math.Ceiling(Math.Log(nums.Length + 1, 2));
            Assert.That(height, Is.LessThanOrEqualTo(maxExpectedHeight));
        }

        // Test Case 9: Array with minimum constraint (1 element)
        [Test]
        public void SortedArrayToBST_MinimumSize_ReturnsSingleNode()
        {
            // Arrange
            int[] nums = [42];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.val, Is.EqualTo(42));
            Assert.That(result.left, Is.Null);
            Assert.That(result.right, Is.Null);
        }

        // Test Case 10: Array with boundary values
        [Test]
        public void SortedArrayToBST_BoundaryValues_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [-10000, -5000, 0, 5000, 10000];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 11: Four elements array
        [Test]
        public void SortedArrayToBST_FourElements_ReturnsBalancedBST()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 12: Seven elements array (perfect binary tree size)
        [Test]
        public void SortedArrayToBST_SevenElements_ReturnsPerfectBST()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6, 7];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);

            // For 7 elements, we should get a perfect BST of height 3
            Assert.That(GetHeight(result), Is.EqualTo(3));
        }

        // Test Case 13: Empty array (though constraints say min 1 element)
        [Test]
        public void SortedArrayToBST_EmptyArray_ReturnsNull()
        {
            // Arrange
            int[] nums = [];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Null);
        }

        // Test Case 14: Array with all zeros (though strictly increasing constraint prevents this)
        [Test]
        public void SortedArrayToBST_StrictlyIncreasing_ReturnsBalancedBST()
        {
            // Arrange - strictly increasing as per constraints
            int[] nums = [10, 20, 30, 40, 50];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(IsBalancedBST(result, nums), Is.True);
            Assert.That(ContainsAllValues(result, nums), Is.True);
            Assert.That(IsValidBST(result), Is.True);
        }

        // Test Case 15: Verify in-order traversal gives original array
        [Test]
        public void SortedArrayToBST_InOrderTraversal_ReturnsOriginalArray()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            // Act
            TreeNode result = _solution.SortedArrayToBST(nums);
            List<int> inOrderResult = InOrderTraversal(result);

            // Assert
            Assert.That(inOrderResult, Is.EqualTo(nums));
        }

        // Helper Methods

        private bool IsBalancedBST(TreeNode root, int[] originalArray)
        {
            return IsBalanced(root) && ContainsAllValues(root, originalArray) && IsValidBST(root);
        }

        private bool IsBalanced(TreeNode root)
        {
            return CheckHeight(root) != -1;
        }

        private int CheckHeight(TreeNode node)
        {
            if (node == null) return 0;

            int leftHeight = CheckHeight(node.left);
            if (leftHeight == -1) return -1;

            int rightHeight = CheckHeight(node.right);
            if (rightHeight == -1) return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1) return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        private bool ContainsAllValues(TreeNode root, int[] values)
        {
            HashSet<int> valueSet = new HashSet<int>(values);
            CollectValues(root, valueSet);
            return valueSet.Count == 0;
        }

        private void CollectValues(TreeNode node, HashSet<int> valueSet)
        {
            if (node == null) return;
            valueSet.Remove(node.val);
            CollectValues(node.left, valueSet);
            CollectValues(node.right, valueSet);
        }

        private bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode node, int? min, int? max)
        {
            if (node == null) return true;

            if ((min.HasValue && node.val <= min.Value) ||
                (max.HasValue && node.val >= max.Value))
            {
                return false;
            }

            return IsValidBST(node.left, min, node.val) &&
                   IsValidBST(node.right, node.val, max);
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
        }

        private List<int> InOrderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            InOrder(root, result);
            return result;
        }

        private void InOrder(TreeNode node, List<int> result)
        {
            if (node == null) return;
            InOrder(node.left, result);
            result.Add(node.val);
            InOrder(node.right, result);
        }
    }
}
