using ProblemSolving.LeetCode.Two_Pointers;

namespace ProblemSolving.Tests.LeetCode.Two_Pointers
{
    [TestFixture]
    public class ValidPalindrome125Tests
    {
        private ValidPalindrome125 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ValidPalindrome125();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void IsPalindrome_Example1_ShouldReturnTrue()
        {
            //  Arrange
            string input = "A man, a plan, a canal: Panama";
            bool expected = true;

            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void IsPalindrome_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string input = "race a car";
            bool expected = false;

            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 3 from problem description")]
        public void IsPalindrome_Example3_ShouldReturnTrue()
        {
            //  Arrange
            string input = " ";
            bool expected = true;

            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("single letter")]
        public void IsPalindrome_SingleLetter_ShouldReturnTrue()
        {
            //  Arrange
            string input = "a";
            bool expected = true;

            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("single special character")]
        [TestCase(";", true)]
        [TestCase(" :     ", true)]
        [TestCase(",     ", true)]
        [TestCase("       ,     ", true)]
        [TestCase("       ,", true)]
        public void IsPalindrome_SingleSpecialLetter_ShouldReturnTrue(string input, bool expected)
        {
            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("two letters and  special character in between")]
        [TestCase("a;a", true)]
        [TestCase("b  ;a", false)]
        [TestCase(" a-  a    ", true)]
        [TestCase(" a  -  a    ", true)]
        public void IsPalindrome_SingleSpecialLetter_ShouldWorkCorrectly(string input, bool expected)
        {
            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("capital and small letters")]
        [TestCase("Aa", true)]
        [TestCase("AbBa", true)]
        [TestCase(" A a b B a A;", true)]
        [TestCase(" ASDDSb", false)]
        public void IsPalindrome_MixedCaseLetters_ShouldWorkCorrectly(string input, bool expected)
        {
            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("even length string")]
        [TestCase("ASDDSA", true)]
        [TestCase("asdbsa", false)]
        public void IsPalindrome_EvenLengthString_ShouldWorkCorrectly(string input, bool expected)
        {
            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("odd length string")]
        [TestCase("ASDsa", true)]
        [TestCase("AS;D;bA", false)]
        public void IsPalindrome_OddLengthString_ShouldWorkCorrectly(string input, bool expected)
        {
            //  Act
            bool result = _solution.IsPalindrome(input);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_SingleDigit_ReturnsTrue()
        {
            // Arrange
            string input = "7";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_TwoDifferentCharacters_ReturnsFalse()
        {
            // Arrange
            string input = "ab";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_NumericPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "12321";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_NumericNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "12345";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_SpecialCharactersPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "!@#@!";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_MixedCharactersPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "A1B2B1A";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_WithSpacesPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "a b a";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_WithSpacesNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "a b c";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_RepeatedCharactersPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "aaabaaabaaabaaabaaabaaabaaa";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_PunctuationMarks_ReturnsTrue()
        {
            // Arrange
            string input = ".,;:;,.";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_TabsAndNewlines_ReturnsTrue()
        {
            // Arrange
            string input = "\t\n\r\r\n\t";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_LongSimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string prefix = new string('a', 500);
            string suffix = new string('a', 500);
            string input = prefix + "b" + suffix;
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_LongNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = new string('a', 1000) + "b" + new string('c', 1000);
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_MaxLengthAllSameCharacter_ReturnsTrue()
        {
            // Arrange
            string input = new string('z', 200000);
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_MaxLengthPalindromePattern_ReturnsTrue()
        {
            // Arrange
            string pattern = "abccba";
            int repeatCount = 200000 / (pattern.Length * 2);
            string leftHalf = string.Concat(Enumerable.Repeat(pattern, repeatCount));
            string rightHalf = new string(leftHalf.Reverse().ToArray());
            string input = leftHalf + rightHalf;

            // Ensure we don't exceed max length
            if (input.Length > 200000)
            {
                input = input.Substring(0, 200000);
                // Make it a palindrome by mirroring
                int mid = input.Length / 2;
                char[] chars = input.ToCharArray();
                for (int i = 0; i < mid; i++)
                {
                    chars[input.Length - 1 - i] = chars[i];
                }
                input = new string(chars);
            }

            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.IsTrue(input.Length <= 200000, "Input should be within length constraint");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_MaxLengthNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = new string('a', 199999) + "b";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_AlternatingPattern_ReturnsCorrectResult()
        {
            // Arrange
            string input = "abababab";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_AlternatingPalindromePattern_ReturnsTrue()
        {
            // Arrange
            string input = "abacaba";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_AllPrintableAsciiCharacters_HandlesCorrectly()
        {
            // Arrange - Create string with printable ASCII chars (32-126)
            var chars = new char[95];
            for (int i = 0; i < 95; i++)
            {
                chars[i] = (char)(32 + i); // Space to ~
            }
            string input = new string(chars) + new string(chars.Reverse().ToArray());
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_UnicodeCharactersEdgeCase_HandlesCorrectly()
        {
            // Arrange - Test with extended ASCII characters
            string input = "àáâãäåæçèéêëìíîï" + "ïîíìëêéèçæåäãâáà";
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_StressTestLargeAlmostPalindrome_ReturnsFalse()
        {
            // Arrange - Large string that's almost a palindrome but fails at the end
            string base_pattern = new string('a', 99999);
            string input = base_pattern + "b" + base_pattern + "c"; // Different ending
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_PerformanceTestRepeatedMiddleCharacter_ReturnsTrue()
        {
            // Arrange - Test with many repeated characters in middle
            string sides = new string('x', 50000);
            string middle = new string('y', 100000);
            string input = sides + middle + sides;
            bool expected = true;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_EarlyMismatchOptimization_ReturnsFalse()
        {
            // Arrange - First and last characters don't match (should fail quickly)
            string input = "a" + new string('b', 199998) + "z";
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsPalindrome_LateMismatchWorstCase_ReturnsFalse()
        {
            // Arrange - Mismatch only in the very middle (worst case for optimization)
            int halfLength = 100000;
            string leftHalf = new string('a', halfLength - 1) + "b";
            string rightHalf = "c" + new string('a', halfLength - 1);
            string input = leftHalf + rightHalf;
            bool expected = false;

            // Act
            bool actual = _solution.IsPalindrome(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
