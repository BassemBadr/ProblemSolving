using ProblemSolving.LeetCode.BitManipulation;

namespace ProblemSolving.Tests.LeetCode.BitManipulation
{
    [TestFixture]
    public class ReverseBits190Tests
    {
        private ReverseBits190 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ReverseBits190();
        }

        [Test]
        public void ReverseBits_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 43261596;
            int expected = 964176192;

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2147483644;
            int expected = 1073741822;

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_Zero_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 0;
            int expected = 0;

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        public void ReverseBits_EvenNumber_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 42; // 00000000000000000000000000101010
            int expected = 1409286144; // 01010100000000000000000000000000

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_SmallEvenNumbers_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2; // 00000000000000000000000000000010
            int expected = 1073741824; // 0x40000000

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_MirroredPattern_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 16711680; // 0x00FF0000
            int expected = 65280; // 0x0000FF00

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_SimpleEvenNumber_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 6; // 00000000000000000000000000000110
            int expected = 1610612736; // 01100000000000000000000000000000

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(4, 536870912)]
        [TestCase(8, 268435456)]
        [TestCase(12, 805306368)]
        [TestCase(20, 671088640)]
        public void ReverseBits_VariousEvenNumbers_ShouldWorkCorrectly(int n, int expected)
        {
            // Test multiple small even numbers
            Assert.That(_solution.ReverseBits(n), Is.EqualTo(expected));
        }
       

        [Test]
        public void ReverseBits_AlternatingBits_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1431655765; // 0x55555555 (01010101010101010101010101010101)
            int expected = -1431655766; // 0xAAAAAAAA in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_SingleBitSetAtEnd_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1; // 0x00000001 (LSB set)
            int expected = -2147483648; // 0x80000000

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_SymmetricPattern_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 16711935; // 0x00FF00FF
            int expected = -16711936; // 0xFF00FF00 in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }    

        [Test]
        public void ReverseBits_AllOnesExceptMSB_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2147483647; // 0x7FFFFFFF (all ones except MSB)
            int expected = -2; // 0xFFFFFFFE in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_PositiveNumberWithMSBSetInResult_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 255; // 00000000000000000000000011111111
            int expected = -16777216; // 11111111000000000000000000000000 in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_AnotherEvenNumber_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 100; // 00000000000000000000000001100100
            int expected = 637534208; // 00100110000000000000000000000000

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_HalfOnesHalfZeros_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 65535; // 0x0000FFFF
            int expected = -65536; // 0xFFFF0000 in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_EveryOtherByte_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 252645135; // 0x0F0F0F0F
            int expected = -252645136; // 0xF0F0F0F0 in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_CheckerboardPattern_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 858993459; // 0x33333333
            int expected = -858993460; // 0xCCCCCCCC in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_ByteReversal_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 305419896; // 0x12345678
            int expected = 510274632; // 0x1E6A2C48

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }   

        [Test]
        public void ReverseBits_EveryFourthBitSet_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 286331153; // 0x11111111
            int expected = -2004318072; // 0x88888888 in two's complement

            //  Act
            int result = _solution.ReverseBits(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseBits_PerformanceTest_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 305419896; // 0x12345678

            //  Act & Assert - should complete quickly
            int result = _solution.ReverseBits(n);
            Assert.That(result, Is.EqualTo(510274632)); // 0x1E6A2C48
        }
        
    }
}
