using ProblemSolving.LeetCode.BitManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.BitManipulation
{
    [TestFixture]
    public class NumberOf1Bits191Tests
    {
        private NumberOf1Bits191 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new NumberOf1Bits191();
        }

        [Test]
        public void HammingWeight_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 11;
            int expected = 3;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 128;
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2147483645;
            int expected = 30;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Zero_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 0;
            int expected = 0;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_One_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1;
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Two_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2; // Binary: 10
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Three_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 3; // Binary: 11
            int expected = 2;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Four_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 4; // Binary: 100
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Five_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 5; // Binary: 101
            int expected = 2;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Seven_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 7; // Binary: 111
            int expected = 3;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Eight_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 8; // Binary: 1000
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Fifteen_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 15; // Binary: 1111
            int expected = 4;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_Sixteen_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 16; // Binary: 10000
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_255_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 255; // Binary: 11111111
            int expected = 8;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_256_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 256; // Binary: 100000000
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_1023_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1023; // Binary: 1111111111 (10 ones)
            int expected = 10;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_1024_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1024; // Binary: 10000000000
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_MaxPowerOfTwo_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1073741824; // 2^30
            int expected = 1;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_AllOnes31Bits_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2147483647; // 2^31 - 1 (all 31 bits set to 1)
            int expected = 31;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_AlternatingBits_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1431655765; // Binary: 01010101010101010101010101010101
            int expected = 16;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_RandomPattern1_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 123456789; // Binary: 00000111010110111100110100010101
            int expected = 16;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_RandomPattern2_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 987654321; // Binary: 00111010110111100110100010110001
            int expected = 17;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_SparseOnes_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 1 + (1 << 10) + (1 << 20) + (1 << 30); // Bits at positions 0, 10, 20, 30
            int expected = 4;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HammingWeight_MaxValue_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = int.MaxValue; // Binary: 01111111111111111111111111111111
            int expected = 31;

            //  Act
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 1)]
        [TestCase(8, 1)]
        [TestCase(16, 1)]
        [TestCase(32, 1)]
        [TestCase(64, 1)]
        [TestCase(128, 1)]
        [TestCase(256, 1)]
        [TestCase(512, 1)]
        [TestCase(1024, 1)]
        public void HammingWeight_PowersOfTwoSequence_ShouldWorkCorrectly(int n, int expected)
        {
            Assert.That(_solution.HammingWeight(n), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2)]
        [TestCase(11, 3)]
        [TestCase(12, 2)]
        [TestCase(13, 3)]
        [TestCase(14, 3)]
        [TestCase(15, 4)]
        public void HammingWeight_ConsecutiveNumbers_ShouldWorkCorrectly(int n, int expected)
        {
            Assert.That(_solution.HammingWeight(n), Is.EqualTo(expected));
        }

        [Test]
        [Timeout(100)]
        public void HammingWeight_PerformanceTest_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = int.MaxValue; // Worst case for some algorithms (all bits set except MSB)

            //  Act - should complete quickly
            int result = _solution.HammingWeight(n);

            //  Assert
            Assert.That(result, Is.EqualTo(31));
        }
    }
}
