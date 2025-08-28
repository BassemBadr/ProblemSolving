using ProblemSolving.LeetCode.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    internal class RemoveElement27Tests
    {
        private RemoveElement27 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new RemoveElement27();
        }

        [Test]
        [Description("basic remove elemnt from array")]
        public void RemoveElement_BasicExample_ShouldRemoveCorrectly()
        {
            //  Arrange
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int expected = 2;
            int[] expectedElements = { 2, 2 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            //  Assert
            Assert.That(actualK, Is.EqualTo(expected));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("check when input is an empty array should return 0")]
        public void RemoveElement_0LengthNums_Returns0()
        {
            //  Arrange
            int[] nums = { };
            int val = 3;
            int expected = 0;

            //  Act
            int result = _solution.RemoveElement(nums, val);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("check when the val does not exist in nums")]
        public void RemoveElement_ValNotExist_ReturnNumsLength()
        {
            //  Arrange
            int[] nums = { 1, 2, 3, 4 };
            int val = 5;
            int expected = 4;

            //  Act
            int result = _solution.RemoveElement(nums, val);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Basic example 2 from problem description")]
        public void RemoveElement_Example2_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int expectedK = 5;
            int[] expectedElements = { 0, 1, 3, 0, 4 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK), "Should return correct count of remaining elements");
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Single element that matches val")]
        public void RemoveElement_SingleElementMatches_ShouldReturnZero()
        {
            // Arrange
            int[] nums = { 5 };
            int val = 5;

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(0), "Should return 0 when single element matches val");
        }

        [Test]
        [Description("Single element that doesn't match val")]
        public void RemoveElement_SingleElementDoesntMatch_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 5 };
            int val = 3;
            int[] expectedElements = { 5 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(1), "Should return 1 when single element doesn't match val");
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("All elements match val")]
        public void RemoveElement_AllElementsMatch_ShouldReturnZero()
        {
            // Arrange
            int[] nums = { 7, 7, 7, 7, 7 };
            int val = 7;

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(0), "Should return 0 when all elements match val");
        }

        [Test]
        [Description("No elements match val")]
        public void RemoveElement_NoElementsMatch_ShouldReturnOriginalLength()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int val = 9;
            int[] expectedElements = { 1, 2, 3, 4, 5 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(5), "Should return original length when no elements match");
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Remove elements from beginning")]
        public void RemoveElement_RemoveFromBeginning_ShouldWork()
        {
            // Arrange
            int[] nums = { 2, 2, 3, 4, 5 };
            int val = 2;
            int expectedK = 3;
            int[] expectedElements = { 3, 4, 5 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Remove elements from end")]
        public void RemoveElement_RemoveFromEnd_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 5, 5 };
            int val = 5;
            int expectedK = 3;
            int[] expectedElements = { 1, 2, 3 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Remove elements from middle")]
        public void RemoveElement_RemoveFromMiddle_ShouldWork()
        {
            // Arrange
            int[] nums = { 1, 4, 4, 4, 5 };
            int val = 4;
            int expectedK = 2;
            int[] expectedElements = { 1, 5 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Array with duplicate values mixed throughout")]
        public void RemoveElement_MixedDuplicates_ShouldWork()
        {
            // Arrange
            int[] nums = { 3, 1, 3, 2, 3, 4, 3 };
            int val = 3;
            int expectedK = 3;
            int[] expectedElements = { 1, 2, 4 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Test with boundary values")]
        public void RemoveElement_BoundaryValues_ShouldWork()
        {
            // Arrange
            int[] nums = { 0, 50, 0, 50, 25 };
            int val = 50;
            int expectedK = 3;
            int[] expectedElements = { 0, 0, 25 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        [Test]
        [Description("Large array test")]
        public void RemoveElement_LargeArray_ShouldWork()
        {
            // Arrange
            int[] nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i % 10; // Creates pattern: 0,1,2,3,4,5,6,7,8,9,0,1,2...
            }
            int val = 5;
            int expectedK = 90; // 10 occurrences of 5 should be removed

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));

            // Verify first k elements don't contain val
            for (int i = 0; i < actualK; i++)
            {
                Assert.That(nums[i], Is.Not.EqualTo(val), $"Element at index {i} should not equal {val}");
            }
        }

        [Test]
        [Description("Test with val = 0 (edge case)")]
        public void RemoveElement_ValIsZero_ShouldWork()
        {
            // Arrange
            int[] nums = { 0, 1, 0, 2, 0, 3 };
            int val = 0;
            int expectedK = 3;
            int[] expectedElements = { 1, 2, 3 };

            // Act
            int actualK = _solution.RemoveElement(nums, val);

            // Assert
            Assert.That(actualK, Is.EqualTo(expectedK));
            AssertFirstKElementsValid(nums, actualK, expectedElements, val);
        }

        /// <summary>
        /// Helper method to verify that the first k elements contain exactly the expected elements
        /// (in any order) and none of them equal val
        /// </summary>
        private void AssertFirstKElementsValid(int[] nums, int k, int[] expectedElements, int val)
        {
            // Check that we have the right number of elements
            Assert.That(k, Is.EqualTo(expectedElements.Length), "k should match expected elements count");

            // Check that first k elements don't contain val
            for (int i = 0; i < k; i++)
            {
                Assert.That(nums[i], Is.Not.EqualTo(val), $"Element at index {i} should not equal {val}");
            }

            // Check that first k elements contain exactly the expected elements (order doesn't matter)
            var actualFirstK = nums.Take(k).OrderBy(x => x).ToArray();
            var expectedSorted = expectedElements.OrderBy(x => x).ToArray();

            CollectionAssert.AreEqual(expectedSorted, actualFirstK,
                "First k elements should contain exactly the expected elements (order doesn't matter)");
        }
    }
}
