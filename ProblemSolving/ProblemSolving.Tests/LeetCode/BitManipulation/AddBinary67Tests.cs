using ProblemSolving.LeetCode.BitManipulation;

namespace ProblemSolving.Tests.LeetCode.BitManipulation
{
    [TestFixture]
    public class AddBinary67Tests
    {
        private AddBinary67 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new AddBinary67();
        }

        [Test]
        public void AddBinary_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "11", b = "1";
            string expected = "100";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1010", b = "1011";
            string expected = "10101";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_BothZero_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "0";
            string b = "0";
            string expected = "0";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_OneZero_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "0";
            string b = "1";
            string expected = "1";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_OneEmpty_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1";
            string b = "";
            string expected = "1";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_NoCarry_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "10";
            string b = "1";
            string expected = "11";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_MultipleCarries_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1111";
            string b = "1111";
            string expected = "11110";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_DifferentLengths_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "100";
            string b = "110010";
            string expected = "110110";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_VeryDifferentLengths_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1";
            string b = "1111111111";
            string expected = "10000000000";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_SingleBitAddition_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1";
            string b = "1";
            string expected = "10";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_LargeNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "10101010101010101010";
            string b = "11001100110011001100";
            string expected = "101110111011101110110";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_MaximumLength_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = new string('1', 10000); // All ones
            string b = "1";
            string expected = "1" + new string('0', 10000); // 1 followed by 10000 zeros

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_CarryPropagation_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "101010101";
            string b = "010101010";
            string expected = "111111111";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_AlternatingBits_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "10101010";
            string b = "01010101";
            string expected = "11111111";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_PalindromeNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1001";
            string b = "1001";
            string expected = "10010";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_AllOnesSmall_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "111";
            string b = "111";
            string expected = "1110";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_AllOnesLarge_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "111111";
            string b = "111111";
            string expected = "1111110";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_ComplexCarryChain_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "10000000000000000001";
            string b = "1";
            string expected = "10000000000000000010";

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_PowerOfTwoAddition_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "1000000"; // 64
            string b = "1000000"; // 64
            string expected = "10000000"; // 128

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Timeout(100)]
        public void AddBinary_MaximumConstraintLength_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = new string('1', 10000);
            string b = new string('1', 10000);

            //  Act - should not throw and complete within timeout
            string result = _solution.AddBinary(a, b);

            //  Assert - result should be valid binary string
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Does.Match("^[01]+$"));
            Assert.That(result.Length, Is.EqualTo(10001)); // 10000 ones + 1 = 10001 bits
        }

        [Test]
        public void AddBinary_SimpleIncrement_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "101"; // 5
            string b = "1";   // 1
            string expected = "110"; // 6

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_NoCommonBitsSet_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "101010"; // 42
            string b = "010101"; // 21
            string expected = "111111"; // 63

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddBinary_ResultLongerThanInputs_ShouldWorkCorrectly()
        {
            //  Arrange
            string a = "111"; // 7
            string b = "001"; // 1
            string expected = "1000"; // 8

            //  Act
            string result = _solution.AddBinary(a, b);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
