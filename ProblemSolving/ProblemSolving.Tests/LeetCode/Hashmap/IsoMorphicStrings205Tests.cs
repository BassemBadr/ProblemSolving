using ProblemSolving.LeetCode.Hashmap;
using System.Text;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class IsoMorphicStrings205Tests
    {
        private IsoMorphicStrings205 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new IsoMorphicStrings205();
        }

        [Test]
        [Description("example 1 from problem description")]
        public void IsIsoMorphic_Example1_ShouldReturnTrue()
        {
            //  Arrange
            string s = "egg";
            string t = "add";

            //  Act
            bool result = _solution.IsIsomorphic(s, t);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("example 2 from problem description")]
        public void IsIsoMorphic_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string s = "foo";
            string t = "bar";

            //  Act
            bool result = _solution.IsIsomorphic(s, t);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("example 3 from problem description")]
        public void IsIsoMorphic_Example3_ShouldReturnTrue()
        {
            //  Arrange
            string s = "paper";
            string t = "title";

            //  Act
            bool result = _solution.IsIsomorphic(s, t);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_SameString_ReturnsTrue()
        {
            // Arrange
            string s = "paper";
            string t = "paper";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        // Edge cases with multiple mappings
        [Test]
        public void IsIsomorphic_OneToManyMapping_ReturnsFalse()
        {
            // Arrange
            string s = "badc";
            string t = "baba";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_ManyToOneMapping_ReturnsTrue()
        {
            // Arrange
            string s = "abab";
            string t = "baba";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        // Complex isomorphic cases
        [Test]
        public void IsIsomorphic_ComplexIsomorphic_ReturnsTrue()
        {
            // Arrange
            string s = "title";
            string t = "paper";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_LongIsomorphicStrings_ReturnsTrue()
        {
            // Arrange
            string s = "abcdefghijklmnopqrstuvwxyz";
            string t = "zyxwvutsrqponmlkjihgfedcba";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        // ASCII character tests
        [Test]
        public void IsIsomorphic_WithSpecialASCIICharacters_ReturnsTrue()
        {
            // Arrange
            string s = "a!b@c#";
            string t = "1!2@3#";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_WithDigits_ReturnsTrue()
        {
            // Arrange
            string s = "123456";
            string t = "abcdef";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        // Performance test cases (boundary of constraints)
        [Test]
        public void IsIsomorphic_MaxLengthStrings_ReturnsQuickly()
        {
            // Arrange
            int length = 50000;
            string s = new string('a', length);
            string t = new string('b', length);

            // Act & Assert - should complete quickly
            Assert.DoesNotThrow(() => _solution.IsIsomorphic(s, t));
        }

        [Test]
        public void IsIsomorphic_MaxLengthComplexMapping_ReturnsQuickly()
        {
            // Arrange
            int length = 50000;
            string s = new string(Enumerable.Range(0, length).Select(i => (char)('a' + i % 26)).ToArray());
            string t = new string(Enumerable.Range(0, length).Select(i => (char)('z' - i % 26)).ToArray());

            // Act & Assert - should complete quickly
            Assert.DoesNotThrow(() => _solution.IsIsomorphic(s, t));
        }

        // Additional edge cases
        [Test]
        public void IsIsomorphic_CircularMapping_ReturnsFalse()
        {
            // Arrange
            string s = "abcdea";
            string t = "xyzwwx";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_AllSameCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aaaa";
            string t = "bbbb";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        // Test for the specific constraint: "No two characters may map to the same character"
        [Test]
        public void IsIsomorphic_TwoCharactersMapToSame_ReturnsFalse()
        {
            // Arrange
            string s = "ab";
            string t = "aa";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        // Test for the specific constraint: "A character may map to itself"
        [Test]
        public void IsIsomorphic_CharacterMapsToItself_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "axc"; // 'a' and 'c' map to themselves, 'b' maps to 'x'

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_ComplexValidPattern_ReturnsTrue()
        {
            // Arrange
            string s = "abba";
            string t = "cddc";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_ComplexInvalidPattern_ReturnsFalse()
        {
            // Arrange
            string s = "abba";
            string t = "cdcd";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_AllSameToMixedInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "aaaa";
            string t = "abcd";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_MixedToAllSameInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "abcd";
            string t = "aaaa";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_NumbersValid_ReturnsTrue()
        {
            // Arrange
            string s = "13";
            string t = "42";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_NumbersWithRepeatsValid_ReturnsTrue()
        {
            // Arrange
            string s = "1331";
            string t = "2442";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_NumbersWithRepeatsInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "1331";
            string t = "2431";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_SpecialCharactersValid_ReturnsTrue()
        {
            // Arrange
            string s = "!@#";
            string t = "$%^";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_SpecialCharactersInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "!@!";
            string t = "$%^";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_MixedAsciiCharactersValid_ReturnsTrue()
        {
            // Arrange
            string s = "a1!";
            string t = "b2@";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_UppercaseLettersValid_ReturnsTrue()
        {
            // Arrange
            string s = "ABC";
            string t = "XYZ";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_MixedCaseValid_ReturnsTrue()
        {
            // Arrange
            string s = "AaBb";
            string t = "XxYy";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_MixedCaseInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "AaAa";
            string t = "XxYy";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_LongStringValid_ReturnsTrue()
        {
            // Arrange
            string s = "abcdefghijk";
            string t = "zyxwvutsrqp";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_LongStringWithRepeatsValid_ReturnsTrue()
        {
            // Arrange
            string s = "abcabcabc";
            string t = "xyzxyzxyz";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_LongStringWithRepeatsInvalid_ReturnsFalse()
        {
            // Arrange
            string s = "abcabcabc";
            string t = "xyzxywabc";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_PalindromeValidCorrect_ReturnsFalse()
        {
            // Arrange
            string s = "racecar";
            string t = "xyzeyzx";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsIsomorphic_WhitespaceCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "a b";
            string t = "x y";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_TabAndSpaceCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "a\tb";
            string t = "x y";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_NewlineCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "a\nb";
            string t = "x\ry";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_LargeInputValid_ReturnsTrue()
        {
            // Arrange
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            // Create pattern: "abab...ab" (1000 times each)
            for (int i = 0; i < 1000; i++)
            {
                sb1.Append("ab");
                sb2.Append("xy");
            }

            string s = sb1.ToString();
            string t = sb2.ToString();

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsIsomorphic_LargeInputInvalid_ReturnsFalse()
        {
            // Arrange
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            // Create s: "aaaa...a" (2000 'a's)
            // Create t: "xyxy...xy" (alternating pattern)
            for (int i = 0; i < 1000; i++)
            {
                sb1.Append("aa");
                sb2.Append("xy");
            }

            string s = sb1.ToString();
            string t = sb2.ToString();

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.False); // 'a' maps to both 'x' and 'y'
        }

        [Test]
        public void IsIsomorphic_AllAsciiCharactersValid_ReturnsTrue()
        {
            // Arrange - using printable ASCII characters
            string s = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            string t = "~}|{zyxwvutsrqponmlkjihgfedcba`_^]\\[ZYXWVUTSRQPONMLKJIHGFEDCBA@?>=<;:9876543210/.-,+*)('&%$#\"!";

            // Act
            bool result = _solution.IsIsomorphic(s, t);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
