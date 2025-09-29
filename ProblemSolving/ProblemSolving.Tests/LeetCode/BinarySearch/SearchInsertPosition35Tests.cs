using ProblemSolving.LeetCode.BinarySearch;

namespace ProblemSolving.Tests.LeetCode.BinarySearch
{
    [TestFixture]
    public class SearchInsertPosition35Tests
    {
        private SearchInsertPosition35 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SearchInsertPosition35();
        }

        [Test]
        public void SearchInsert_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 5;
            int expected = 2;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 2;
            int expected = 1;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 7;
            int expected = 4;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_TargetAtStartFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 1;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_TargetAtEndFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 6;
            int expected = 3;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_TargetAtStartNotFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 3, 5, 6];
            int target = 0;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_SingleElementTargetFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5];
            int target = 5;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_SingleElementTargetSmaller_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5];
            int target = 2;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_SingleElementTargetLarger_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [5];
            int target = 8;
            int expected = 1;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_EmptyArray_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [];
            int target = 5;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_NegativeNumbersTargetFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-5, -3, -1, 0, 2, 4];
            int target = -3;
            int expected = 1;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_NegativeNumbersTargetNotFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-5, -3, -1, 0, 2, 4];
            int target = -2;
            int expected = 2;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_AllNegativeNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -8, -6, -4, -2];
            int target = -5;
            int expected = 3;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_AllPositiveNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [2, 4, 6, 8, 10];
            int target = 7;
            int expected = 3;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_TargetAtLowerBoundary_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-100, -50, 0, 50, 100];
            int target = -104;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_TargetAtUpperBoundary_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-100, -50, 0, 50, 100];
            int target = 104;
            int expected = 5;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_LargeArrayTargetFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                nums[i] = i * 2;
            }
            int target = 5000;
            int expected = 2500;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_LargeArrayTargetNotFound_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                nums[i] = i * 2;
            }
            int target = 5001;
            int expected = 2501;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_AllValuesGreaterThanTarget_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [10, 20, 30, 40, 50];
            int target = 5;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_AllValuesLessThanTarget_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [10, 20, 30, 40, 50];
            int target = 60;
            int expected = 5;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_ExactMatchAtNegativeBoundary_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-104, -100, 0, 100, 104];
            int target = -104;
            int expected = 0;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_ExactMatchAtPositiveBoundary_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-104, -100, 0, 100, 104];
            int target = 104;
            int expected = 4;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_InsertBetweenTwoNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [1, 2, 4, 5];
            int target = 3;
            int expected = 2;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_MixedNumbersInsertAtStart_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -5, 0, 5, 10, 15, 20];
            int target = -7;
            int expected = 1;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_MixedNumbersInsertAtMiddle_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -5, 0, 5, 10, 15, 20];
            int target = 12;
            int expected = 5;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SearchInsert_MixedNumbersInsertAtEnd_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = [-10, -5, 0, 5, 10, 15, 20];
            int target = 25;
            int expected = 7;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Timeout(100)]
        public void SearchInsert_LargeArrayPerformance_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                nums[i] = i;
            }
            int target = 7500;
            int expected = 7500;

            //  Act
            int result = _solution.SearchInsert(nums, target);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
