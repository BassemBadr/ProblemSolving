using ProblemSolving.LeetCode.MathLogic;

namespace ProblemSolving.Tests.LeetCode.MathLogic
{
    [TestFixture]
    internal class PalindromeNumber9Tests
    {
        private PalindromeNumber9 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new PalindromeNumber9();
        }

        [Test]
        public void IsPalindrome_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int x = 121;

            //  Act
            bool result = _solution.IsPalindrome(x);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int x = -121;

            //  Act
            bool result = _solution.IsPalindrome(x);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int x = 10;

            //  Act
            bool result = _solution.IsPalindrome(x);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_SingleDigit_ReturnsTrue()
        {
            int x = 5;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_TwoDigitPalindrome_ReturnsTrue()
        {
            int x = 11;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_ThreeDigitPalindrome_ReturnsTrue()
        {
            int x = 131;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_FourDigitPalindrome_ReturnsTrue()
        {
            int x = 1221;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_FiveDigitPalindrome_ReturnsTrue()
        {
            int x = 12321;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_SixDigitPalindrome_ReturnsTrue()
        {
            int x = 123321;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_AllSameDigits_ReturnsTrue()
        {
            int x = 999999999;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_WithZeroInMiddle_ReturnsTrue()
        {
            int x = 1002001;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_NegativeNumber_ReturnsFalse()
        {
            int x = -123;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_NegativePalindrome_ReturnsFalse()
        {
            int x = -121;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_TwoDigitNonPalindrome_ReturnsFalse()
        {
            int x = 12;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_ThreeDigitNonPalindrome_ReturnsFalse()
        {
            int x = 123;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_FourDigitNonPalindrome_ReturnsFalse()
        {
            int x = 1234;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_SameDigitsExceptOne_ReturnsTrue()
        {
            int x = 1112111;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_EndsWithZero_ReturnsFalse()
        {
            int x = 10;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_MultipleEndingZeros_ReturnsFalse()
        {
            int x = 100;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_Zero_ReturnsTrue()
        {
            int x = 0;
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_MaxPalindromeInRange_ReturnsTrue()
        {
            int x = 2147447412; // Palindrome within int range
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindrome_LargeNonPalindrome_ReturnsFalse()
        {
            int x = 2147483647; // int.MaxValue (not a palindrome)
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindrome_MinValue_ReturnsFalse()
        {
            int x = -2147483648; // int.MinValue
            bool result = _solution.IsPalindrome(x);
            Assert.That(result, Is.False);
        }
    }
}
