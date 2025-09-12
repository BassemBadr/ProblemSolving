using ProblemSolving.LeetCode.Hashmap;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class TwoSums1Tests
    {
        private TwoSums1 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new TwoSums1();
        }

        [Test]
        [Description("example 1 from problem description nums = [2,7,11,15], target = 9")]
        public void TwoSum_Example1_ShouldWorkCorrectly()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(result, Is.EquivalentTo(expected));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        [Description("example 2 from problem description nums = [3,2,4], target = 6")]
        public void TwoSum_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };

            //  Act
            int[] result = _solution.TwoSum(nums, target);

            //  Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(result, Is.EquivalentTo(expected));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        [Description("example 3 from problem description nums = [3,3], target = 6")]
        public void TwoSum_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };

            //  Act
            int[] result = _solution.TwoSum(nums, target);

            //  Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(result, Is.EquivalentTo(expected));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_MinimumArraySize_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 1, 2 };
            int target = 3;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_NegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_PositiveAndNegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { -1, 2, 3, -4, 5 };
            int target = 1;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_ZeroTarget_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { -5, 0, 5, 10 };
            int target = 0;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_LargeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 1000000000, 2000000000, -1000000000, -2000000000 };
            int target = 0;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_DuplicateValuesDifferentIndices_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 2, 4 };
            int target = 4;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_SolutionAtEndOfArray_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 19;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
            Assert.That(result, Is.EquivalentTo(new[] { 8, 9 })); // 9 + 10 = 19
        }

        [Test]
        public void TwoSum_SolutionAtBeginningOfArray_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 10, 20, 30, 40, 50 };
            int target = 30;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
            Assert.That(result, Is.EquivalentTo(new[] { 0, 1 }));
        }

        [Test]
        public void TwoSum_MinimumValues_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { -109, -109, 0, 109 };
            int target = 0;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        public void TwoSum_MaximumValues_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 109, 109, 0, -109 };
            int target = 218;

            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }

        [Test]
        [TestCase(new[] { 1, 2, 3 }, 4)]
        [TestCase(new[] { 4, 5, 6 }, 11)]
        [TestCase(new[] { 10, 15, 20 }, 35)]
        public void TwoSum_MultipleScenarios_AllReturnCorrect(int[] nums, int target)
        {
            // Act
            int[] result = _solution.TwoSum(nums, target);

            // Assert
            Assert.That(result, Has.Length.EqualTo(2));
            Assert.That(nums[result[0]] + nums[result[1]], Is.EqualTo(target));
        }
    }
}
