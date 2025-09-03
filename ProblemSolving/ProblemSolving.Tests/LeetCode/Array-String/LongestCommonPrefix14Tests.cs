using ProblemSolving.LeetCode.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class LongestCommonPrefix14Tests
    {
        private LongestCommonPrefix14 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new LongestCommonPrefix14();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void LongestCommonPrefix_Example1_ShouldReturnfl()
        {
            //  Arrange
            string[] strs = { "flower", "flow", "flight" };
            string expected = "fl";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void LongestCommonPrefix_Example2_ShouldReturnEmpty()
        {
            //  Arrange
            string[] strs = { "dog", "racecar", "car" };
            string expected = "";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("all strings are the same word")]
        public void LongestCommonPrefix_AllSameWord_ShouldReturnWord()
        {
            //  Arrange
            string[] strs = { "word", "word", "word", "word", "word", "word", "word", "word" };
            string expected = "word";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("all strings are the same word but some are empty")]
        public void LongestCommonPrefix_AllSameWordWithEmpty_ShouldReturnEmpty()
        {
            //  Arrange
            string[] strs = { "word", "word", "word", "word", "", "word", "word", "word" };
            string expected = "";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("first letter common")]
        public void LongestCommonPrefix_FirstLetterCommon_ShouldReturnW()
        {
            //  Arrange
            string[] strs = { "word", "wood", "ward", "wand", "wild", "wane", "war", "wizard" };
            string expected = "w";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("multiple common one letter")]
        public void LongestCommonPrefix_CommonOneLetter_ShouldReturnO()
        {
            //  Arrange
            string[] strs = { "o", "o", "o", "o" };
            string expected = "o";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("single letter")]
        public void LongestCommonPrefix_SingleLetter_ShouldReturnl()
        {
            //  Arrange
            string[] strs = { "l" };
            string expected = "l";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("first 3 letters are common")]
        public void LongestCommonPrefix_3CommonLetters_ShouldReturnOne()
        {
            //  Arrange
            string[] strs = { "one", "oneday", "onenight", "onegashima", "oneda" };
            string expected = "one";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("string array has one item")]
        public void LongestCommonPrefix_OneWordArray_ShouldReturnParty()
        {
            //  Arrange
            string[] strs = { "party" };
            string expected = "party";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("string array has one empty item")]
        public void LongestCommonPrefix_EmptyItem_ShouldReturnEmpty()
        {
            //  Arrange
            string[] strs = { "" };
            string expected = "";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("boundary with 200 character words")]
        public void LongestCommonPrefix_200CharWords_ShouldWorkCorrectly()
        {
            //  Arrange
            string[] strs = { new string('c', 200), new string('c', 100) + new string('b', 100), new string('c', 50) + new string('b', 150), new string('c', 25) + new string('b', 175) };
            string expected = new string('c', 25);

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("test boudnary with array length of 200 word")]
        public void LongestCommonPrefix_200ItemsArray_ShouldWorkCorrectly()
        {
            //  Arrange
            string[] strs = new string[200];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = new string('a', i + 1);
            }

            string expected = "a";

            //  Act
            string result = _solution.LongestCommonPrefix(strs);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LongestCommonPrefix_AllEmptyStrings_ReturnsEmptyString()
        {
            // Arrange
            string[] strs = { "", "", "" };
            string expected = "";

            // Act
            string result = _solution.LongestCommonPrefix(strs);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LongestCommonPrefix_MaximumStringLength_HandlesLongStrings()
        {
            // Arrange
            string longPrefix = new string('a', 100); // 100 'a' characters
            string[] strs = { longPrefix + "bc", longPrefix + "de", longPrefix + "fg" };
            string expected = longPrefix;

            // Act
            string result = _solution.LongestCommonPrefix(strs);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LongestCommonPrefix_MaximumStringLengthNoCommonPrefix_ReturnsEmpty()
        {
            // Arrange
            string str1 = new string('a', 200);
            string str2 = new string('b', 200);
            string[] strs = { str1, str2 };
            string expected = "";

            // Act
            string result = _solution.LongestCommonPrefix(strs);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LongestCommonPrefix_AllSameLongString_ReturnsEntireLongString()
        {
            // Arrange
            string longString = new string('z', 150);
            string[] strs = { longString, longString, longString };
            string expected = longString;

            // Act
            string result = _solution.LongestCommonPrefix(strs);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
