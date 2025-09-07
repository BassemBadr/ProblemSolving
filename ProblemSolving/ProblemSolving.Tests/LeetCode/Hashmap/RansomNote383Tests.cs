using ProblemSolving.LeetCode.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class RansomNote383Tests
    {
        private RansomNote383 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new RansomNote383();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void CanConstruct_Example1_ShouldReturnFalse()
        {
            //  Arrange
            string ransomNote = "a";
            string magazine = "b";
            bool expectted = false;

            //  Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            //  Assert
            Assert.That(result, Is.EqualTo(expectted));
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void CanConstruct_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string ransomNote = "aa";
            string magazine = "ab";
            bool expectted = false;

            //  Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            //  Assert
            Assert.That(result, Is.EqualTo(expectted));
        }

        [Test]
        [Description("Example 3 from problem description")]
        public void CanConstruct_Example3_ShouldReturnTrue()
        {
            //  Arrange
            string ransomNote = "aa";
            string magazine = "aab";
            bool expectted = true;

            //  Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            //  Assert
            Assert.That(result, Is.EqualTo(expectted));
        }

        [Test]
        public void CanConstruct_SimpleValidCaseWithMatch_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "a";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }        

        [Test]
        public void CanConstruct_InsufficientLetters_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_ExactMatch_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "abc";
            string magazine = "abc";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_RansomNoteEmpty_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "";
            string magazine = "abc";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_MagazineEmpty_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_BothEmpty_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "";
            string magazine = "";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_SingleCharacterMinimum_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "z";
            string magazine = "z";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_RansomNoteLongerThanMagazine_CanStillBeTrue()
        {
            // Arrange
            string ransomNote = "aab";
            string magazine = "baa";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_RansomNoteLongerThanMagazineButInvalid_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aaab";
            string magazine = "baa";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_AllSameCharacters_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "aaaa";
            string magazine = "aaaaaa";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_AllSameCharactersInsufficientCount_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aaaa";
            string magazine = "aaa";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_MixedCharactersValid_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "aab";
            string magazine = "baa";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_MixedCharactersInvalid_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aab";
            string magazine = "bac";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_LargerValidExample_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "hello";
            string magazine = "wellhelloworld";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_LargerInvalidExample_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "hello";
            string magazine = "world";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_AllLowercaseLetters_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "abcdefg";
            string magazine = "gfedcbaxyz";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_RepeatedCharactersComplex_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "aabbcc";
            string magazine = "abcabc";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_RepeatedCharactersComplexInvalid_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aaabbbccc";
            string magazine = "abcabc";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_LargeInputValid_ReturnsTrue()
        {
            // Arrange
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            // Create ransom note with 1000 'a's and 1000 'b's
            for (int i = 0; i < 1000; i++)
            {
                sb1.Append('a');
                sb1.Append('b');
            }

            // Create magazine with sufficient letters
            for (int i = 0; i < 1500; i++)
            {
                sb2.Append('a');
                sb2.Append('b');
            }

            string ransomNote = sb1.ToString();
            string magazine = sb2.ToString();

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_LargeInputInvalid_ReturnsFalse()
        {
            // Arrange
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            // Create ransom note with 1000 'a's
            for (int i = 0; i < 1000; i++)
            {
                sb1.Append('a');
            }

            // Create magazine with only 999 'a's
            for (int i = 0; i < 999; i++)
            {
                sb2.Append('a');
            }

            string ransomNote = sb1.ToString();
            string magazine = sb2.ToString();

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanConstruct_EdgeCaseAllAlphabet_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "abcdefghijklmnopqrstuvwxyz";
            string magazine = "zyxwvutsrqponmlkjihgfedcba";

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanConstruct_EdgeCasePartialAlphabet_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "abcdefghijklmnopqrstuvwxyz";
            string magazine = "abcdefghijklmnopqrstuvwxy"; // missing 'z'

            // Act
            bool result = _solution.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
