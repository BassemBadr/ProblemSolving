using ProblemSolving.LeetCode.Hashmap;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class HappyNumber202Tests
    {
        private HappyNumber202 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new HappyNumber202();
        }

        [Test]
        [Description("example 1 from problem description 19 => true")]
        public void IsHappy_Example1_ShouldReturnTrue()
        {
            //  Arrange
            int n = 19;
            bool expected = true;

            //  Act
            bool result = _solution.IsHappy(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("example 2 from problem description 2 => false")]
        public void IsHappy_Example2_ShouldReturnFalse()
        {
            //  Arrange
            int n = 2;
            bool expected = false;

            //  Act
            bool result = _solution.IsHappy(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsHappy_SingleDigitHappy_ReturnsTrue()
        {
            // Arrange
            int n = 1;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsHappy_AnotherHappyNumber_ReturnsTrue()
        {
            // Arrange
            int n = 7;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsHappy_LargerHappyNumber_ReturnsTrue()
        {
            // Arrange
            int n = 44;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsHappy_UnhappyNumber_ReturnsFalse()
        {
            // Arrange
            int n = 2;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsHappy_AnotherUnhappyNumber_ReturnsFalse()
        {
            // Arrange
            int n = 3;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsHappy_NumberThatEntersCycle_ReturnsFalse()
        {
            // Arrange
            int n = 4;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsHappy_MaximumValue_ReturnsFalse()
        {
            // Arrange
            int n = int.MaxValue;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsHappy_MinimumValue_ReturnsTrue()
        {
            // Arrange
            int n = 1;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsHappy_Zero_ShouldHandleGracefully()
        {
            // Arrange
            int n = 0;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsHappy_LargeHappyNumber_ReturnsTrue()
        {
            // Arrange
            int n = 100;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsHappy_VeryLargeHappyNumber_ReturnsTrue()
        {
            // Arrange
            int n = 1000;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.True);
        }

        // Numbers with many digits
        [Test]
        public void IsHappy_NumberWithManyDigits_ReturnsCorrectResult()
        {
            // Arrange
            int n = 123456789;

            // Act
            bool result = _solution.IsHappy(n);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(7, true)]
        [TestCase(10, true)]
        [TestCase(13, true)]
        [TestCase(19, true)]
        [TestCase(23, true)]
        [TestCase(28, true)]
        [TestCase(31, true)]
        [TestCase(32, true)]
        [TestCase(44, true)]
        [TestCase(49, true)]
        [TestCase(68, true)]
        [TestCase(70, true)]
        [TestCase(79, true)]
        [TestCase(82, true)]
        [TestCase(86, true)]
        [TestCase(91, true)]
        [TestCase(94, true)]
        [TestCase(97, true)]
        [TestCase(100, true)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(11, false)]
        [TestCase(12, false)]
        [TestCase(14, false)]
        [TestCase(15, false)]
        [TestCase(16, false)]
        [TestCase(17, false)]
        [TestCase(18, false)]
        [TestCase(20, false)]
        public void IsHappy_MultipleTestCases_ReturnsExpectedResults(int n, bool expected)
        {
            //   Act
            bool result = _solution.IsHappy(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // Performance test for large numbers
        [Test]
        [Timeout(1000)] // Should complete within 1 second
        public void IsHappy_LargeNumber_PerformsWell()
        {
            // Arrange
            int n = 214748364; // Large number

            // Act
            bool result = _solution.IsHappy(n);

            // Assert - We don't care about the result, just that it completes quickly
            Assert.That(true, Is.True); // Just verify it doesn't timeout
        }
    }
}
