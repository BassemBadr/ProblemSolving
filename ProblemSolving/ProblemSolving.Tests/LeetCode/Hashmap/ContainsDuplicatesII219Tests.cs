using ProblemSolving.LeetCode.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class ContainsDuplicatesII219Tests
    {
        private ContainsDuplicatesII219 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ContainsDuplicatesII219();
        }

        [Test]
        [Description("Example 1 from problem description, should work correctly")]
        public void ContainsNearbyDuplicate_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            //  Act
            bool expected = _solution.ContainsNearbyDuplicate(nums, k);

            //  Assert
            Assert.That(expected, Is.True);
        }

        [Test]
        [Description("Example 2 from problem description, should work correctly")]
        public void ContainsNearbyDuplicate_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 1, 0, 1, 1 };
            int k = 1;

            //  Act
            bool expected = _solution.ContainsNearbyDuplicate(nums, k);

            //  Assert
            Assert.That(expected, Is.True);
        }

        [Test]
        [Description("Example 3 from problem description, should work correctly")]
        public void ContainsNearbyDuplicate_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;

            //  Act
            bool expected = _solution.ContainsNearbyDuplicate(nums, k);

            //  Assert
            Assert.That(expected, Is.False);
        }

        [Test]
        public void ContainsNearbyDuplicate_SingleElement_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1 };
            int k = 0;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ContainsNearbyDuplicate_TwoSameElementsKZero_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 1 };
            int k = 0;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // abs(0 - 1) = 1 > 0
        }

        [Test]
        public void ContainsNearbyDuplicate_TwoSameElementsKOne_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 1 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // abs(0 - 1) = 1 <= 1
        }

        [Test]
        public void ContainsNearbyDuplicate_TwoDifferentElements_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ContainsNearbyDuplicate_AdjacentDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[1] = nums[2] = 2, abs(1 - 2) = 1 <= 1
        }

        [Test]
        public void ContainsNearbyDuplicate_AdjacentDuplicatesKZero_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3 };
            int k = 0;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // abs(1 - 2) = 1 > 0
        }

        [Test]
        public void ContainsNearbyDuplicate_AllSameElements_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 5, 5, 5, 5 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // Multiple adjacent duplicates
        }

        [Test]
        public void ContainsNearbyDuplicate_AllSameElementsKZero_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 5, 5, 5, 5 };
            int k = 0;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // No duplicate at same index
        }

        [Test]
        public void ContainsNearbyDuplicate_NegativeNumbers_ReturnsTrue()
        {
            // Arrange
            int[] nums = { -1, -2, -1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[0] = nums[2] = -1, abs(0 - 2) = 2 <= 2
        }

        [Test]
        public void ContainsNearbyDuplicate_NegativeNumbersOutOfRange_ReturnsFalse()
        {
            // Arrange
            int[] nums = { -1, -2, -3, -1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // abs(0 - 3) = 3 > 2
        }

        [Test]
        public void ContainsNearbyDuplicate_ZeroValues_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 0, 1, 0 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[0] = nums[2] = 0, abs(0 - 2) = 2 <= 2
        }

        [Test]
        public void ContainsNearbyDuplicate_LargeNumbers_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1000000000, 999999999, 1000000000 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // Large numbers within range
        }

        [Test]
        public void ContainsNearbyDuplicate_VeryLargeK_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 1 };
            int k = 100000; // Maximum k value

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // abs(0 - 5) = 5 <= 100000
        }

        [Test]
        public void ContainsNearbyDuplicate_ExactDistanceMatch_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1 };
            int k = 4;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // abs(0 - 4) = 4 == k
        }

        [Test]
        public void ContainsNearbyDuplicate_ExactDistanceExceeded_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // abs(0 - 4) = 4 > 3
        }

        [Test]
        public void ContainsNearbyDuplicate_MultipleDuplicatesFirstInRange_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 1, 3, 1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[0] = nums[2] = 1, abs(0 - 2) = 2 <= 2
        }

        [Test]
        public void ContainsNearbyDuplicate_MultipleDuplicatesNoneInRange_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1, 5, 6, 1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // All duplicate distances > 2
        }

        [Test]
        public void ContainsNearbyDuplicate_DifferentDuplicatesInRange_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3, 1 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[1] = nums[2] = 2, abs(1 - 2) = 1 <= 3
        }

        [Test]
        public void ContainsNearbyDuplicate_RepeatingPattern_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[0] = nums[3] = 1, abs(0 - 3) = 3 <= 3
        }

        [Test]
        public void ContainsNearbyDuplicate_LongArrayNoDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 5;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // No duplicates at all
        }

        [Test]
        public void ContainsNearbyDuplicate_LongArrayWithDuplicatesInRange_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 3, 7, 8, 9, 10 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[2] = nums[5] = 3, abs(2 - 5) = 3 <= 3
        }

        [Test]
        public void ContainsNearbyDuplicate_EdgeCaseMinMaxValues_ReturnsTrue()
        {
            // Arrange
            int[] nums = { -1000000000, 1000000000, -1000000000 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // Min/max constraint values
        }

        [Test]
        public void ContainsNearbyDuplicate_LargeArrayWithEarlyMatch_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[1000];
            nums[0] = 42;
            nums[2] = 42; // Duplicate at distance 2
            for (int i = 1; i < 1000; i++)
            {
                if (i != 2) nums[i] = i;
            }
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // Should find early match efficiently
        }

        [Test]
        public void ContainsNearbyDuplicate_LargeArrayWithLateMatch_ReturnsTrue()
        {
            // Arrange
            int[] nums = new int[1000];
            for (int i = 0; i < 998; i++)
            {
                nums[i] = i;
            }
            nums[998] = 42;
            nums[999] = 42; // Last two elements are duplicates
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // Should find match at end
        }

        [Test]
        public void ContainsNearbyDuplicate_AlternatingPattern_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 1, 2, 1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // nums[0] = nums[2] = 1, abs(0 - 2) = 2 <= 2
        }

        [Test]
        public void ContainsNearbyDuplicate_ThreeSameElementsSpreadOut_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1, 5, 6, 7, 1 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // All duplicate distances are > 3
        }

        [Test]
        public void ContainsNearbyDuplicate_BasicTrueCase_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ContainsNearbyDuplicate_BasicFalseCase_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        // Edge cases with k values
        [Test]
        public void ContainsNearbyDuplicate_KEqualsZero_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 1 };
            int k = 0;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ContainsNearbyDuplicate_KEqualsOne_AdjacentDuplicates()
        {
            // Arrange
            int[] nums = { 1, 2, 1 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False); // Distance is 2, which > 1
        }

        [Test]
        public void ContainsNearbyDuplicate_KLargeEnough_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int k = 9;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ContainsNearbyDuplicate_KTooSmall_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int k = 8;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        // Multiple duplicate scenarios
        [Test]
        public void ContainsNearbyDuplicate_MultipleDuplicates_FirstValid()
        {
            // Arrange
            int[] nums = { 1, 2, 1, 4, 1 };
            int k = 2;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True); // First two 1's are distance 2 apart
        }

        [Test]
        public void ContainsNearbyDuplicate_MultipleDuplicates_NoneValid()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 4, 5, 1 };
            int k = 1;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }      

        [Test]
        public void ContainsNearbyDuplicate_NoDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int k = 3;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }       
      

        // Boundary cases
        [Test]
        public void ContainsNearbyDuplicate_KEqualsArrayLength_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1 };
            int k = nums.Length;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ContainsNearbyDuplicate_KLargerThanArrayLength_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 1 };
            int k = nums.Length + 5;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True);
        }

        // Performance test cases (conceptual)
        [Test]
        public void ContainsNearbyDuplicate_LargeArray_ValidCase()
        {
            // Arrange - create large array with duplicates at specific positions
            int size = 10000;
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = i;
            }
            nums[5000] = nums[5005] = 9999; // Duplicates with distance 5
            int k = 5;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True );
        }

        [Test]
        public void ContainsNearbyDuplicate_LargeArray_InvalidCase()
        {
            // Arrange - create large array with duplicates but large distance
            int size = 10000;
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = i;
            }
            nums[100] = nums[8000] = 9999; // Duplicates with large distance
            int k = 100;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }

        // Edge case: exactly k distance apart
        [Test]
        public void ContainsNearbyDuplicate_ExactlyKDistance_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 1 };
            int k = 5;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ContainsNearbyDuplicate_ExactlyKPlusOneDistance_ReturnsFalse()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5, 6, 1 };
            int k = 5;

            // Act
            bool result = _solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
