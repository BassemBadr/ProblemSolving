using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class LengthOfLastWord58Tests
    {
        private LengthOfLastWord58 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new LengthOfLastWord58();
        }

        [Test]
        [Description("example 1 from problem description 'Hello World'")]
        public void LengthOfLastWord_Example1_ShouldReturn5()
        {
            //  Arrange
            string s = "Hello World";
            int expected = 5;

            //  Act
            int result = _solution.LengthOfLastWord(s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("example 2 from problem description '   fly me   to   the moon  '")]
        public void LengthOfLastWord_Example2_ShouldReturn4()
        {
            //  Arrange
            string s = "   fly me   to   the moon  ";
            int expected = 4;

            //  Act
            int result = _solution.LengthOfLastWord(s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("example 3 from problem description 'luffy is still joyboy'")]
        public void LengthOfLastWord_Example3_ShouldReturn6()
        {
            //  Arrange
            string s = "luffy is still joyboy";
            int expected = 6;

            //  Act
            int result = _solution.LengthOfLastWord(s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a", 1)]
        [TestCase("Hello", 5)]
        [TestCase("JavaScript", 10)]
        public void LengthOfLastWord_SingleWord_ReturnsWordLength(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Hello World", 5)]
        [TestCase("Good luck", 4)]
        [TestCase("First Second", 6)]
        public void LengthOfLastWord_TwoWords_ReturnsLastWordLength(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Hello beautiful world", 5)]
        [TestCase("The quick brown fox jumping", 7)]
        [TestCase("One two three four five six", 3)]
        public void LengthOfLastWord_MultipleWords_ReturnsLastWordLength(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Hello World   ", 5)]
        [TestCase("Test    ", 4)]
        [TestCase("Single      ", 6)]
        [TestCase("One two three        ", 5)]
        public void LengthOfLastWord_TrailingSpaces_IgnoresTrailingSpaces(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("   Hello", 5)]
        [TestCase("    World", 5)]
        [TestCase("   Test word", 4)]
        public void LengthOfLastWord_LeadingSpaces_HandlesCorrectly(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Hello     World", 5)]
        [TestCase("One  two   three    four", 4)]
        [TestCase("First    Second", 6)]
        public void LengthOfLastWord_MultipleSpacesBetweenWords_HandlesCorrectly(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("   Hello World   ", 5)]
        [TestCase("    Test    ", 4)]
        [TestCase("  One two three  ", 5)]
        public void LengthOfLastWord_LeadingAndTrailingSpaces_HandlesCorrectly(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("HeLLo WoRLd", 5)]
        [TestCase("TeSt", 4)]
        [TestCase("JavaScript", 10)]
        public void LengthOfLastWord_MixedCase_ReturnsCorrectLength(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LengthOfLastWord_LongWords1_HandlesCorrectly()
        {
            //  Arrange
            string s = $"Short {new string('a', 100)}";
            int expected = 100;

            //   Act
            int result = _solution.LengthOfLastWord(s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LengthOfLastWord_LongWords2_HandlesCorrectly()
        {
            //  Arrange
            string s = $"Start middle {new string('b', 500)}";
            int expected = 500;

            //   Act
            int result = _solution.LengthOfLastWord(s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a", 1)]
        [TestCase("Z", 1)]
        public void LengthOfLastWord_BoundaryLength_HandlesMinimumInput(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LengthOfLastWord_BoundaryLength_HandlesLargeInput()
        {
            //  Arrange
            // Test approaching the 10,000 character limit
            // Create a string with many short words, ending with a specific word
            var words = new List<string>();
            string targetWord = "FinalWord"; // 9 characters

            // Fill with short words until we approach the limit
            while (string.Join(" ", words).Length + targetWord.Length + 1 < 9990)
            {
                words.Add("a"); // 1 character words
            }
            words.Add(targetWord);
            string largeInput = string.Join(" ", words);
            int expected = 9;

            //  Act
            int result = _solution.LengthOfLastWord(largeInput);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Start abcdefghijklmnopqrstuvwxyz", 26)]
        [TestCase("Begin ABCDEFGHIJKLMNOPQRSTUVWXYZ", 26)]
        [TestCase("Mixed aBcDeF", 6)]
        public void LengthOfLastWord_AlphabeticalCharacters_HandlesAllLetters(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a b c d e", 1)]
        [TestCase("a very b short c word", 4)]
        [TestCase("a ab abc abcd abcde abcdef", 6)]
        public void LengthOfLastWord_VariousWordPatterns_HandlesCorrectly(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("Hello", 5)]
        [TestCase("Hello World", 5)]
        [TestCase("a", 1)]
        [TestCase("The quick brown fox", 3)]
        [TestCase("   spaced   ", 6)]
        [TestCase("One two three", 5)]
        [TestCase("Programming is fun", 3)]
        public void LengthOfLastWord_TestCases_ParameterizedTests(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LengthOfLastWord_StressTest_MultipleWordsWithSpaces()
        {
            //  Arrange
            // Create a string with many words to test performance
            var words = new string[1000];
            for (int i = 0; i < 999; i++)
            {
                words[i] = $"word{i}"; // Each word is unique
            }
            words[999] = "FinalTestWord"; // 13 characters
            int expected = 13;
            string input = string.Join(" ", words);

            //  Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a    word", 4)]
        [TestCase("many     spaces     between     word", 4)]
        [TestCase("single double", 6)]
        public void LengthOfLastWord_EdgeSpacing_VariousSpacePatterns(string input, int expected)
        {
            //   Act
            int result = _solution.LengthOfLastWord(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
