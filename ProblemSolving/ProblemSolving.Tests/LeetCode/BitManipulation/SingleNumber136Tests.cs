using ProblemSolving.LeetCode.BitManipulation;

namespace ProblemSolving.Tests.LeetCode.BitManipulation
{
    [TestFixture]
    public class SingleNumber136Tests
    {
        private SingleNumber136 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SingleNumber136();
        }

        [Test]
        public void SingleNumber_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [2, 2, 1];
            int expected = 1;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [4, 1, 2, 1, 2];
            int expected = 4;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1];
            int expected = 1;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_SingleElement_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5];
            int expected = 5;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_NegativeNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-1, -1, -2];
            int expected = -2;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_MixedPositiveNegative_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [3, -5, 3, 7, -5];
            int expected = 7;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_AllNegative_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -20, -10, -30, -30];
            int expected = -20;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_LargeArray_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = new int[2999]; // 2999 elements (1499 pairs + 1 single)
            int singleNumber = 12345;

            // Fill with pairs
            int value = -10000;
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                nums[i] = value;
                nums[i + 1] = value;
                value++;
            }

            // Add the single number at the end
            nums[nums.Length - 1] = singleNumber;

            int expected = singleNumber;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_SingleAtBeginning_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [99, 1, 1, 2, 2, 3, 3];
            int expected = 99;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_SingleAtEnd_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 1, 2, 2, 3, 3, 77];
            int expected = 77;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_SingleInMiddle_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 1, 2, 2, 42, 3, 3, 4, 4];
            int expected = 42;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_ZeroAsSingle_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [0, 1, 1, 2, 2];
            int expected = 0;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_ZeroInPairs_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5, 0, 0, 3, 3, 2, 2, 1, 1];
            int expected = 5;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_MaxConstraintValue_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [30000, 100, 100, 200, 200];
            int expected = 30000;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_MinConstraintValue_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-30000, -100, -100, -200, -200];
            int expected = -30000;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_LargeEvenCount_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9];
            int expected = 9;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_DuplicateZeros_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [0, 0, 1];
            int expected = 1;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_AllSameExceptOne_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5, 5, 5, 5, 5, 5, 3];
            int expected = 3;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_AlternatingPattern_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [10, 20, 10, 30, 30, 20, 40];
            int expected = 40;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_MaximumSizeArray_ShouldWorkCorrectly()
        {
            //  Arrange - Create array with maximum constraint size
            int arraySize = 29999;
            int[] nums = new int[arraySize];
            int singleNumber = 9999;

            // Fill with pairs (14999 pairs + 1 single = 29999 elements)
            int value = -15000;
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                nums[i] = value;
                nums[i + 1] = value;
                value++;
                if (value > 15000) value = -15000; // Wrap around
            }

            nums[nums.Length - 1] = singleNumber;
            int expected = singleNumber;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_PerformanceTest_ShouldWorkCorrectly()
        {
            //  Arrange
            int arraySize = 29999;
            int[] nums = new int[arraySize];
            int singleNumber = 42;

            // Fill with pairs
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                nums[i] = i;
                nums[i + 1] = i;
            }

            nums[nums.Length - 1] = singleNumber;
            int expected = singleNumber;
            //  Act

            //  Act & Assert - Should complete quickly due to O(n) complexity
            int result = 0;
            Assert.That(() => { result = _solution.SingleNumber(nums); }, Throws.Nothing.After(100));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_ConsecutiveNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 2, 2, 3, 3, 4, 4, 5, 5];
            int expected = 1;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_ReverseConsecutive_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5, 5, 4, 4, 3, 3, 2, 2, 1];
            int expected = 1;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_RandomOrder_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [3, 7, 3, 5, 5, 2, 2, 1, 1];
            int expected = 7;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_AllPositive_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [100, 200, 300, 200, 100];
            int expected = 300;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleNumber_XorPropertyVerification_ShouldWorkCorrectly()
        {
            // Test XOR properties: a ^ a = 0, a ^ 0 = a
            int[] nums = [5, 0, 5]; // 5 ^ 0 ^ 5 = (5 ^ 5) ^ 0 = 0 ^ 0 = 0
            int expected = 0;

            //  Act
            int result = _solution.SingleNumber(nums);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
