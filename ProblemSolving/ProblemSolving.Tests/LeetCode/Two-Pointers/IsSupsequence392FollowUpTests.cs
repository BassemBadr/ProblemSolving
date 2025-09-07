using ProblemSolving.LeetCode.Two_Pointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Two_Pointers
{
    [TestFixture]
    public class IsSupsequence392FollowUpTests
    {
        private IsSupsequence392 _checker;
        private string _testStringT;

        [SetUp]
        public void Setup()
        {
            _testStringT = "ahbgdc"; // Common test string for most tests
            _checker = new IsSupsequence392(_testStringT);
        }

        // Basic functionality tests
        [Test]
        public void IsSubsequence_ValidSubsequence_ReturnsTrue()
        {
            // Arrange
            string s = "abc";

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_InvalidSubsequence_ReturnsFalse()
        {
            // Arrange
            string s = "axc";

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSubsequence_EmptyString_ReturnsTrue()
        {
            // Arrange
            string s = "";

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_SingleCharacterValid_ReturnsTrue()
        {
            // Arrange
            string s = "a";

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_SingleCharacterInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "z";

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        // Edge cases with different T strings
        [Test]
        public void IsSubsequence_EmptyTString_ValidForEmptyS()
        {
            // Arrange
            var emptyChecker = new IsSupsequence392("");
            string s = "";

            // Act
            bool result = emptyChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_EmptyTString_InvalidForNonEmptyS()
        {
            // Arrange
            var emptyChecker = new IsSupsequence392("");
            string s = "a";

            // Act
            bool result = emptyChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSubsequence_LongerSThanT_ReturnsFalse()
        {
            // Arrange
            string s = "abcdefgh"; // Longer than "ahbgdc"

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        // Order dependency tests
        [Test]
        public void IsSubsequence_OutOfOrderCharacters_ReturnsFalse()
        {
            // Arrange
            string s = "cba"; // Wrong order

            // Act
            bool result = _checker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSubsequence_DuplicateCharactersValid_ReturnsTrue()
        {
            // Arrange
            var duplicateChecker = new IsSupsequence392("aabbcc");
            string s = "abc";

            // Act
            bool result = duplicateChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_DuplicateCharactersInvalid_ReturnsFalse()
        {
            // Arrange
            var duplicateChecker = new IsSupsequence392("aabbcc");
            string s = "cba"; // Wrong order despite duplicates

            // Act
            bool result = duplicateChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        // Complex scenarios
        [Test]
        public void IsSubsequence_AllCharactersSame_Valid()
        {
            // Arrange
            var sameCharChecker = new IsSupsequence392("aaaaa");
            string s = "aa";

            // Act
            bool result = sameCharChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_AllCharactersSame_InvalidWhenLonger()
        {
            // Arrange
            var sameCharChecker = new IsSupsequence392("aaa");
            string s = "aaaa"; // Longer than T

            // Act
            bool result = sameCharChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.False);
        }

        // Performance test setup (would need actual timing in real scenarios)
        [Test]
        public void IsSubsequence_MultipleQueriesSameChecker_ConsistentResults()
        {
            // Arrange
            var queries = new[] { "abc", "axc", "a", "z", "bg", "dc", "ahg" };

            // Act & Assert - multiple calls should work consistently
            Assert.Multiple(() =>
            {
                Assert.That(_checker.IsSubsequence(queries[0]), Is.True);
                Assert.That(_checker.IsSubsequence(queries[1]), Is.False);
                Assert.That(_checker.IsSubsequence(queries[2]), Is.True);
                Assert.That(_checker.IsSubsequence(queries[3]), Is.False);
                Assert.That(_checker.IsSubsequence(queries[4]), Is.True);
                Assert.That(_checker.IsSubsequence(queries[5]), Is.True);
                Assert.That(_checker.IsSubsequence(queries[6]), Is.True);
            });
        }

        // Special character tests
        [Test]
        public void IsSubsequence_WithSpecialCharacters_Valid()
        {
            // Arrange
            var specialChecker = new IsSupsequence392("a!b@c#d$");
            string s = "!@#";

            // Act
            bool result = specialChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSubsequence_WithNumbers_Valid()
        {
            // Arrange
            var numberChecker = new IsSupsequence392("a1b2c3d4");
            string s = "123";

            // Act
            bool result = numberChecker.IsSubsequence(s);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
