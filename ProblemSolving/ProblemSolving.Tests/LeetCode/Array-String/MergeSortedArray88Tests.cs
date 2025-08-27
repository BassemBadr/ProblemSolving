using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class MergeSortedArray88Tests
    {
        private MergeSortedArray88 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MergeSortedArray88();
        }

        [Test]
        [Description("Basic merge test from the example")]
        public void Merge_BasicExample_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge when nums1 is empty")]
        public void Merge_EmptyNums1_ShouldCopyNums2()
        {
            // Arrange
            int[] nums1 = { 0, 0, 0 };
            int m = 0;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 2, 5, 6 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge when nums2 is empty")]
        public void Merge_EmptyNums2_ShouldKeepNums1Unchanged()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3 };
            int m = 3;
            int[] nums2 = { };
            int n = 0;
            int[] expected = { 1, 2, 3 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("All elements from nums2 should come first")]
        public void Merge_Nums2ElementsAllSmaller_ShouldPlaceNums2First()
        {
            // Arrange
            int[] nums1 = { 4, 5, 6, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 1, 2, 3 };
            int n = 3;
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("All elements from nums1 should come first")]
        public void Merge_Nums1ElementsAllSmaller_ShouldKeepNums1First()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 4, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge with duplicate elements")]
        public void Merge_WithDuplicates_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 2, 2, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 3, 3 };
            int n = 3;
            int[] expected = { 1, 2, 2, 2, 3, 3 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge single elements")]
        public void Merge_SingleElements_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 2, 0 };
            int m = 1;
            int[] nums2 = { 1 };
            int n = 1;
            int[] expected = { 1, 2 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge with negative numbers")]
        public void Merge_WithNegativeNumbers_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { -3, -1, 0, 0, 0 };
            int m = 2;
            int[] nums2 = { -2, 1, 4 };
            int n = 3;
            int[] expected = { -3, -2, -1, 1, 4 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Merge with all zeros in nums2")]
        public void Merge_Nums2AllZeros_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0 };
            int m = 3;
            int[] nums2 = { 0, 0 };
            int n = 2;
            int[] expected = { 0, 0, 1, 2, 3 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large array merge test")]
        public void Merge_LargeArrays_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 3, 5, 7, 9, 0, 0, 0, 0, 0 };
            int m = 5;
            int[] nums2 = { 2, 4, 6, 8, 10 };
            int n = 5;
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Edge case: m=1, n=1")]
        public void Merge_MinimalCase_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 0 };
            int m = 1;
            int[] nums2 = { 2 };
            int n = 1;
            int[] expected = { 1, 2 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Test that original nums2 array is not modified")]
        public void Merge_ShouldNotModifyNums2()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] originalNums2 = { 2, 5, 6 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums2, Is.EqualTo(originalNums2), "nums2 should not be modified");
        }

        [Test]
        [Description("Test nums1 has one element")]
        public void Merge_Nums1Has1Element()
        {
            // Arrange
            int[] nums1 = { 1 };
            int m = 1;
            int[] nums2 = { };
            int n = 0;
            int[] expected = { 1 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

        [Test]
        [Description("Test nums2 has one element")]
        public void Merge_Nums1Has2Element()
        {
            // Arrange
            int[] nums1 = { 0 };
            int m = 0;
            int[] nums2 = { 1 };
            int n = 1;
            int[] expected = { 1 };

            // Act
            _solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }

    }
}
