using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class StringFirstOccurenceIndex28Tests
    {
        private StringFirstOccurenceIndex28 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new StringFirstOccurenceIndex28();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void FindNeedle_Example1_ShouldReturn0()
        {
            //  Arrange
            string needle = "sad", haystack = "sadbutsad";
            int expected = 0;

            //  Act
            int result = _solution.StrStr(haystack, needle);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void FindNeedle_Example2_ShouldReturnMinusOne()
        {
            //  Arrange
            string needle = "leeto", haystack = "leetcode";
            int expected = -1;

            //  Act
            int result = _solution.StrStr(haystack, needle);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_SingleCharacterMatch_ReturnsZero()
        {
            // Arrange
            string haystack = "a";
            string needle = "a";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_SingleCharacterNoMatch_ReturnsMinusOne()
        {
            // Arrange
            string haystack = "a";
            string needle = "b";
            int expected = -1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NeedleAtBeginning_ReturnsZero()
        {
            // Arrange
            string haystack = "helloworld";
            string needle = "hello";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NeedleAtEnd_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = "helloworld";
            string needle = "world";
            int expected = 5;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NeedleInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = "programming";
            string needle = "gram";
            int expected = 3;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_EntireHaystackIsNeedle_ReturnsZero()
        {
            // Arrange
            string haystack = "test";
            string needle = "test";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NeedleLongerThanHaystack_ReturnsMinusOne()
        {
            // Arrange
            string haystack = "short";
            string needle = "longer";
            int expected = -1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NeedleNotFound_ReturnsMinusOne()
        {
            // Arrange
            string haystack = "helloworld";
            string needle = "xyz";
            int expected = -1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_MultipleOccurrencesReturnsFirst_ReturnsFirstIndex()
        {
            // Arrange
            string haystack = "abababab";
            string needle = "abab";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_OverlappingPattern_ReturnsFirstOccurrence()
        {
            // Arrange
            string haystack = "aaab";
            string needle = "aab";
            int expected = 1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_RepeatedCharactersInNeedle_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = "mississippi";
            string needle = "issip";
            int expected = 4;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_RepeatedSingleCharacter_ReturnsFirstIndex()
        {
            // Arrange
            string haystack = "aaaaaaa";
            string needle = "aaa";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_PartialMatchAtEnd_ReturnsMinusOne()
        {
            // Arrange
            string haystack = "abcdef";
            string needle = "defg";
            int expected = -1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_AlmostMatchAtEnd_ReturnsMinusOne()
        {
            // Arrange
            string haystack = "programming";
            string needle = "ming";
            int expected = 7;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_LongHaystackShortNeedle_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = new string('a', 1000) + "target" + new string('b', 1000);
            string needle = "target";
            int expected = 1000;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_LongIdenticalStrings_ReturnsZero()
        {
            // Arrange
            string longString = new string('x', 5000);
            string haystack = longString;
            string needle = longString;
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_MaxLengthStringsNoMatch_ReturnsMinusOne()
        {
            // Arrange
            string haystack = new string('a', 9999) + "b";
            string needle = new string('c', 5000);
            int expected = -1;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_NearMaxLengthWithMatch_ReturnsCorrectIndex()
        {
            // Arrange
            string prefix = new string('a', 8000);
            string suffix = new string('b', 1500);
            string haystack = prefix + "needle" + suffix;
            string needle = "needle";
            int expected = 8000;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.IsTrue(haystack.Length <= 10000, "Test setup should be within bounds");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_RepeatingPatternEdgeCase_ReturnsFirstOccurrence()
        {
            // Arrange
            string haystack = "abcabcabcabc";
            string needle = "abcabc";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_AlmostRepeatingPattern_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = "abcabcabdabc";
            string needle = "abcabd";
            int expected = 3;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_PalindromicPattern_ReturnsCorrectIndex()
        {
            // Arrange
            string haystack = "racecaracecar";
            string needle = "racecar";
            int expected = 0;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_StressTestManyRepeats_HandlesPerformance()
        {
            // Arrange
            string pattern = "abc";
            string haystack = string.Concat(Enumerable.Repeat(pattern, 3000)) + "xyz";
            string needle = "abcxyz";
            int expected = haystack.Length - 6; // Length of "abcxyz"

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_WorstCaseScenario_HandlesCorrectly()
        {
            // Arrange - Pattern that causes many partial matches
            string haystack = new string('a', 999) + "b";
            string needle = new string('a', 500) + "b";
            int expected = 499;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_SingleCharacterNeedleAtEnd_ReturnsLastIndex()
        {
            // Arrange
            string haystack = "abcdefg";
            string needle = "g";
            int expected = 6;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FindNeedle_SingleCharacterNeedleRepeated_ReturnsFirstIndex()
        {
            // Arrange
            string haystack = "abcabc";
            string needle = "c";
            int expected = 2;

            // Act
            int actual = _solution.StrStr(haystack, needle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
