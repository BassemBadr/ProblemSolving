using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArray26Tests
    {
        private RemoveDuplicatesFromSortedArray26 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new RemoveDuplicatesFromSortedArray26();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void RemoveDuplicates_Example1_ShouldReturnCorrectResult()
        {
            // Arrange
            int[] nums = { 1, 1, 2 };
            int[] expected = { 1, 2 };
            int expectedK = 2;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "Should return correct count of unique elements");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void RemoveDuplicates_Example2_ShouldReturnCorrectResult()
        {
            // Arrange
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] expected = { 0, 1, 2, 3, 4 };
            int expectedK = 5;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "Should return correct count of unique elements");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Single element array")]
        public void RemoveDuplicates_SingleElement_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 42 };
            int[] expected = { 42 };
            int expectedK = 1;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "Single element should return count 1");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("No duplicates - all unique elements")]
        public void RemoveDuplicates_AllUnique_ShouldReturnOriginalLength()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            int expectedK = 5;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "All unique elements should return original length");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("All elements are the same")]
        public void RemoveDuplicates_AllSameElement_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 7, 7, 7, 7, 7 };
            int[] expected = { 7 };
            int expectedK = 1;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "All same elements should return count 1");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Two identical elements")]
        public void RemoveDuplicates_TwoIdentical_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int[] expected = { 3 };
            int expectedK = 1;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "Two identical elements should return count 1");
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with negative numbers")]
        public void RemoveDuplicates_WithNegativeNumbers_ShouldWork()
        {
            // Arrange
            int[] nums = { -3, -3, -1, -1, 0, 0, 2, 2 };
            int[] expected = { -3, -1, 0, 2 };
            int expectedK = 4;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with all negative numbers")]
        public void RemoveDuplicates_AllNegative_ShouldWork()
        {
            // Arrange
            int[] nums = { -100, -50, -50, -25, -25, -1 };
            int[] expected = { -100, -50, -25, -1 };
            int expectedK = 4;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with zeros")]
        public void RemoveDuplicates_WithZeros_ShouldWork()
        {
            // Arrange
            int[] nums = { -1, 0, 0, 0, 1, 1 };
            int[] expected = { -1, 0, 1 };
            int expectedK = 3;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with only zeros")]
        public void RemoveDuplicates_OnlyZeros_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 0, 0, 0, 0 };
            int[] expected = { 0 };
            int expectedK = 1;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Long consecutive duplicates")]
        public void RemoveDuplicates_LongConsecutiveDuplicates_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
            int[] expected = { 1, 2, 3 };
            int expectedK = 3;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Mixed pattern of duplicates")]
        public void RemoveDuplicates_MixedPattern_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3, 4, 4, 4, 5, 6, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            int expectedK = 6;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Large array with boundary values")]
        public void RemoveDuplicates_BoundaryValues_ShouldWork()
        {
            // Arrange
            int[] nums = { -100, -100, -50, -50, 0, 0, 50, 50, 100, 100 };
            int[] expected = { -100, -50, 0, 50, 100 };
            int expectedK = 5;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Large array test - alternating pattern")]
        public void RemoveDuplicates_LargeArrayAlternating_ShouldWork()
        {
            // Arrange  
            // Create pattern: 1,1,2,2,3,3,4,4...50,50 (100 elements total, 50 unique)
            int[] nums = new int[100];
            for (int i = 0; i < 50; i++)
            {
                nums[i * 2] = i + 1;
                nums[i * 2 + 1] = i + 1;
            }

            int[] expected = Enumerable.Range(1, 50).ToArray();
            int expectedK = 50;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with many consecutive identical elements at start")]
        public void RemoveDuplicates_ManyAtStart_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4 };
            int[] expected = { 1, 2, 3, 4 };
            int expectedK = 4;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Array with many consecutive identical elements at end")]
        public void RemoveDuplicates_ManyAtEnd_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 4, 4, 4, 4, 4 };
            int[] expected = { 1, 2, 3, 4 };
            int expectedK = 4;

            // Act
            int actualK = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsMatch(nums, actualK, expected);
        }

        [Test]
        [Description("Verify original array structure after first k elements is preserved")]
        public void RemoveDuplicates_VerifyArrayModificationInPlace_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2, 3 };
            int[] originalCopy = { 1, 1, 2, 2, 3 };

            // Act
            int k = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(k, Is.EqualTo(3));
            // Verify the array is the same reference (modified in-place)
            Assert.That(nums.Length, Is.EqualTo(originalCopy.Length), "Array length should remain the same");
            // First k elements should be unique and in order
            int[] expected = { 1, 2, 3 };
            AssertFirstKElementsMatch(nums, k, expected);
        }

        /// <summary>
        /// Helper method to verify that the first k elements match expected elements exactly in order
        /// </summary>
        private void AssertFirstKElementsMatch(int[] nums, int k, int[] expected)
        {
            Assert.That(k, Is.EqualTo(expected.Length), "k should match expected array length");

            for (int i = 0; i < k; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expected[i]),
                    $"Element at index {i} should be {expected[i]} but was {nums[i]}");
            }

            // Also verify elements are in non-decreasing order and unique
            for (int i = 1; i < k; i++)
            {
                Assert.IsTrue(nums[i] > nums[i - 1],
                    $"Elements should be in strictly increasing order. nums[{i - 1}]={nums[i - 1]}, nums[{i}]={nums[i]}");
            }
        }
    }
}
