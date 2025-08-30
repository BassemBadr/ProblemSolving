using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    internal class MajorityElement169Tests
    {
        private MajorityElement169 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MajorityElement169();
        }

        [Test]
        [Description("example 1 from problem description")]
        public void MajorityElement_BasicExample1_ShouldReturnCorrectly()
        {
            // Arrange
            int[] nums = { 3, 2, 3 };
            int expected = 3;

            // Act
            int actualM = _solution.MajorityElement(nums);

            // Assert
            Assert.That(actualM, Is.EqualTo(expected));
        }

        [Test]
        [Description("example 2 from problem description")]
        public void MajorityElement_BasicExample2_ShouldReturnCorrectly()
        {
            // Arrange
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            int expected = 2;

            // Act
            int actualM = _solution.MajorityElement(nums);

            // Assert
            Assert.That(actualM, Is.EqualTo(expected));
        }

        [Test]
        [Description("Majority element is zero")]
        public void MajorityElement_ZeroMajority_ShouldReturnZero()
        {
            // Arrange
            int[] nums = { 0, 0, 0, 0, 0, 1 };
            int expected = 0;

            // Act
            int actualM = _solution.MajorityElement(nums);

            // Assert
            Assert.That(actualM, Is.EqualTo(expected));
        }

        [Test]
        [Description("All elements are zeros")]
        public void MajorityElement_AllZeros_ShouldReturnZero()
        {
            // Arrange
            int[] nums = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int expected = 0;

            // Act
            int actualM = _solution.MajorityElement(nums);

            // Assert
            Assert.That(actualM, Is.EqualTo(expected));
        }

        [Test]
        [Description("All elements are Negative")]
        public void MajorityElement_AllNegative_ShouldReturnCorrectly()
        {
            // Arrange
            int[] nums = { -1, -3, -5, -5, -5, -5, -5, -5, -5, -5, -2, -1 };
            int expected = -5;

            // Act
            int actualM = _solution.MajorityElement(nums);

            // Assert
            Assert.That(actualM, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single element array")]
        public void MajorityElement_SingleElement_ShouldReturnThatElement()
        {
            // Arrange
            int[] nums = { 42 };
            int expected = 42;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Two identical elements")]
        public void MajorityElement_TwoIdentical_ShouldReturnThatElement()
        {
            // Arrange
            int[] nums = { 7, 7 };
            int expected = 7;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("All elements are the same")]
        public void MajorityElement_AllSameElements_ShouldReturnThatElement()
        {
            // Arrange
            int[] nums = { 5, 5, 5, 5, 5 };
            int expected = 5;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Majority element at the beginning")]
        public void MajorityElement_MajorityAtBeginning_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 2, 3 };
            int expected = 1;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Majority element at the end")]
        public void MajorityElement_MajorityAtEnd_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 3, 3 };
            int expected = 3;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Majority element scattered throughout")]
        public void MajorityElement_MajorityScattered_ShouldWork()
        {
            // Arrange
            int[] nums = { 4, 1, 4, 2, 4, 3, 4 };
            int expected = 4;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Even length array with clear majority")]
        public void MajorityElement_EvenLengthArray_ShouldWork()
        {
            // Arrange
            int[] nums = { 6, 5, 5, 6, 6, 6 };
            int expected = 6;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Odd length array with exact majority")]
        public void MajorityElement_OddLengthExactMajority_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 1 }; // 1 appears 3 times out of 5 (> 2.5)
            int expected = 1;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Array with negative numbers")]
        public void MajorityElement_WithNegativeNumbers_ShouldWork()
        {
            // Arrange
            int[] nums = { -3, -3, 4, 4, -3, -3, -3 };
            int expected = -3;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Array with zeros")]
        public void MajorityElement_WithZeros_ShouldWork()
        {
            // Arrange
            int[] nums = { 0, 1, 0, 2, 0, 0, 0 };
            int expected = 0;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large numbers within constraint")]
        public void MajorityElement_LargeNumbers_ShouldWork()
        {
            // Arrange
            int[] nums = { 1000000000, -1000000000, 1000000000, 1000000000, 1000000000 };
            int expected = 1000000000;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Minimum majority case - just over half")]
        public void MajorityElement_MinimumMajority_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 1 }; // 1 appears 2 out of 3 times (> 1.5)
            int expected = 1;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Larger array with clear majority")]
        public void MajorityElement_LargerArray_ShouldWork()
        {
            // Arrange
            int[] nums = { 8, 8, 7, 7, 7, 8, 8, 8, 8, 7 }; // 8 appears 6 out of 10 times
            int expected = 8;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Array where majority element appears exactly n/2 + 1 times")]
        public void MajorityElement_ExactlyOverHalf_ShouldWork()
        {
            // Arrange
            // Array of 9 elements, majority needs > 4.5, so 5+ times
            int[] nums = { 1, 2, 3, 4, 5, 5, 5, 5, 5 }; // 5 appears exactly 5 times
            int expected = 5;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Alternating pattern with clear majority")]
        public void MajorityElement_AlternatingPattern_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 1, 2, 1, 2, 1 }; // 1 appears 4 out of 7 times
            int expected = 1;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Three different elements with clear majority")]
        public void MajorityElement_ThreeElements_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 3, 2, 2, 1, 2, 2 }; // 2 appears 4 out of 7 times
            int expected = 2;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large test case simulating real-world usage")]
        public void MajorityElement_LargeTestCase_ShouldWork()
        {
            // Arrange
            // Create an array of 1001 elements where 501 of them are the number 42
            var nums = new int[1001];

            // Fill first 501 positions with 42 (majority element)
            for (int i = 0; i < 501; i++)
            {
                nums[i] = 42;
            }

            // Fill remaining 500 positions with different numbers
            for (int i = 501; i < 1001; i++)
            {
                nums[i] = i; // Each will be unique, so no other majority
            }

            int expected = 42;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Test with repeated sequences")]
        public void MajorityElement_RepeatedSequences_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 1 }; // 1 appears 5 out of 11 times
            int expected = 1;

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
