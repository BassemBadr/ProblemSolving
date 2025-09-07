using ProblemSolving.LeetCode.Two_Pointers;
using System.Text;

namespace ProblemSolving.Tests.LeetCode.Two_Pointers
{
    [TestFixture]
    public class IsSupsequence392Tests
    {
        private IsSupsequence392 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new IsSupsequence392();
        }

        [Test]
        [Description("example 1 from problem description")]
        public void IsSubsequence_Example1_ShouldReturnTrue()
        {
            //  Arrange
            string s = "abc";
            string t = "ahbgdc";
            bool expected = true;

            //  Act
            bool result = _solution.IsSubsequence(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("example 2 from problem description")]
        public void IsSubsequence_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string s = "axc";
            string t = "ahbgdc";
            bool expected = false;

            //  Act
            bool result = _solution.IsSubsequence(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        //  subsequence as empty string while main isn't
        //  main string as empty string while substring isn't
        //  both main and substring are empty
        //  one letter subsequence and exist
        //  one letter as subsequence but doesn't exist
        //  subsequence is the same as main string
        //  subsequence exist without removing characters in main string
        //  subsequence exist at the middle
        //  subsequence exist at the end
        //  subsequence exist as scattered letters
        //  subsequence exist but on different character order (should return false)
        //  boundary check subsequence of 100 character
        //  boundary check main string of 10,000 character

        [Test]
        public void IsSubsequence_EmptySubsequenceEmptyString_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_EmptySubsequenceNonEmptyString_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "abc";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_NonEmptySubsequenceEmptyString_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SingleCharacterMatch_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "a";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SingleCharacterNoMatch_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SingleCharacterInLongerString_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "bac";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_IdenticalStrings_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "abc";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SimpleSubsequence_ReturnsTrue()
        {
            // Arrange
            string s = "ace";
            string t = "abcde";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SimpleNonSubsequence_ReturnsFalse()
        {
            // Arrange
            string s = "aec";
            string t = "abcde";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SubsequenceAtBeginning_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "abcdef";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SubsequenceAtEnd_ReturnsTrue()
        {
            // Arrange
            string s = "def";
            string t = "abcdef";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SubsequenceInMiddle_ReturnsTrue()
        {
            // Arrange
            string s = "bcd";
            string t = "abcdef";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_ScatteredSubsequence_ReturnsFalse()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgdc";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_ScatteredNonSubsequence_ReturnsFalse()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgd";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_RepeatedCharactersInTarget_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "aabbcc";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_RepeatedCharactersInSubsequence_ReturnsTrue()
        {
            // Arrange
            string s = "aab";
            string t = "aaabbb";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_RepeatedCharactersNotEnoughInTarget_ReturnsFalse()
        {
            // Arrange
            string s = "aaa";
            string t = "aab";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_AllSameCharacter_ReturnsTrue()
        {
            // Arrange
            string s = "aaa";
            string t = "aaaaaaa";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_OrderMattersCorrectOrder_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "azbycx";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_OrderMattersWrongOrder_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "acb";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_LongerSubsequenceThanTarget_ReturnsFalse()
        {
            // Arrange
            string s = "abcdef";
            string t = "abc";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_FirstCharacterMissing_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "bcdef";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_LastCharacterMissing_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "abdef";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_MiddleCharacterMissing_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "acdef";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_AlphabeticalSequence_ReturnsTrue()
        {
            // Arrange
            string s = "abcdefghij";
            string t = "aabbccddeeffgghhiijj";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_ReverseAlphabeticalNonSequence_ReturnsFalse()
        {
            // Arrange
            string s = "jihgfedcba";
            string t = "abcdefghij";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_MaxLengthSubsequenceInMaxTarget_ReturnsTrue()
        {
            // Arrange
            string s = new string('a', 100); // Max length for s
            string t = new string('a', 10000); // Max length for t
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_MaxLengthSubsequenceNotInTarget_ReturnsFalse()
        {
            // Arrange
            string s = new string('a', 100);
            string t = new string('a', 99) + new string('b', 9901); // Only 99 'a's
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_AlternatingPattern_ReturnsTrue()
        {
            // Arrange
            string s = "ababab";
            string t = "aabbbaabbbaabbb";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_AlternatingPatternInsufficient_ReturnsFalse()
        {
            // Arrange
            string s = "ababab";
            string t = "aabbbaabb"; // Missing final 'ab'
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_LongDistanceMatching_ReturnsTrue()
        {
            // Arrange
            string s = "az";
            string t = "a" + new string('b', 8998) + "z"; // 'a' and 'z' far apart
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_ComplexPattern_ReturnsTrue()
        {
            // Arrange
            string s = "programming";
            string t = "pxrxoxgxrxaxmxmxixnxg";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_ComplexPatternIncomplete_ReturnsFalse()
        {
            // Arrange
            string s = "programming";
            string t = "pxrxoxgxrxaxmxmxixnx"; // Missing final 'g'
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_StressTestLargeInput_ReturnsTrue()
        {
            // Arrange
            StringBuilder sBuilder = new StringBuilder();
            StringBuilder tBuilder = new StringBuilder();

            // Create pattern: a, b, c, d, e repeated
            for (int i = 0; i < 20; i++)
            {
                sBuilder.Append("abcde");
            }

            // Create target with extra characters between pattern letters
            for (int i = 0; i < 20; i++)
            {
                tBuilder.Append("axbxcxdxexfxgxhxijklmnopqrstuvwxyz");
            }

            string s = sBuilder.ToString();
            string t = tBuilder.ToString();
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert         
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_PerformanceWorstCase_HandlesProperly()
        {
            // Arrange - Worst case: last character of s matches last character of t
            string s = new string('a', 99) + "z";
            string t = new string('a', 9999) + "z";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_EdgeCaseAllDifferentCharacters_ReturnsFalse()
        {
            // Arrange
            string s = "abcdefghijklmnopqrstuvwxyz";
            string t = "zyxwvutsrqponmlkjihgfedcba";
            bool expected = false;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_SingleCharacterRepeatedInBoth_ReturnsTrue()
        {
            // Arrange
            string s = "z";
            string t = new string('a', 9999) + "z";
            bool expected = true;

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsSubsequence_BoundaryTestMaxLengthPattern_ReturnsTrue()
        {
            // Arrange
            StringBuilder sBuilder = new StringBuilder();
            StringBuilder tBuilder = new StringBuilder();

            // Create a pattern that uses all 26 letters repeated to reach close to max length
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < 100 / 26; i++)
            {
                sBuilder.Append(alphabet);
            }
            // Add remaining characters to reach exactly 100
            for (int i = 0; i < 100 % 26; i++)
            {
                sBuilder.Append(alphabet[i]);
            }

            // Create target by repeating the pattern with filler
            for (int repeat = 0; repeat < 10000 / (alphabet.Length * 2); repeat++)
            {
                foreach (char c in alphabet)
                {
                    tBuilder.Append(c);
                    if (tBuilder.Length < 10000)
                        tBuilder.Append('x'); // Filler character
                }
            }
            // Ensure we have the complete pattern at the end
            tBuilder.Append(sBuilder.ToString());

            // Truncate to exactly 10000 if needed
            if (tBuilder.Length > 10000)
            {
                tBuilder.Length = 10000;
            }

            string s = sBuilder.ToString();
            string t = tBuilder.ToString();
            bool expected = true; // Should be true since we constructed t to contain s

            // Act
            bool actual = _solution.IsSubsequence(s, t);

            // Assert           
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
