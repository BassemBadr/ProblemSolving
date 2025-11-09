using ProblemSolving.LeetCode.MathLogic;

namespace ProblemSolving.Tests.LeetCode.MathLogic
{
    [TestFixture]
    internal class SquareRoot69Tests
    {
        private SquareRoot69 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SquareRoot69();
        }

        [Test]
        public void MySqrt_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int x = 4;
            int expected = 2;

            //  Act
            int result = _solution.MySqrt(x);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int x = 8;
            int expected = 2;

            //  Act
            int result = _solution.MySqrt(x);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_Zero_ReturnsZero()
        {
            int x = 0;
            int expected = 0;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_One_ReturnsOne()
        {
            int x = 1;
            int expected = 1;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_PerfectSquareSmall_ReturnsExactRoot()
        {
            int x = 9;
            int expected = 3;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_PerfectSquareMedium_ReturnsExactRoot()
        {
            int x = 16;
            int expected = 4;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_PerfectSquareLarge_ReturnsExactRoot()
        {
            int x = 100;
            int expected = 10;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_PerfectSquareVeryLarge_ReturnsExactRoot()
        {
            int x = 10000;
            int expected = 100;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_NonPerfectSquareSmall_RoundsDown()
        {
            int x = 2;
            int expected = 1;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_NonPerfectSquareMedium_RoundsDown()
        {
            int x = 15;
            int expected = 3;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_NonPerfectSquareLarge_RoundsDown()
        {
            int x = 99;
            int expected = 9;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_JustBelowPerfectSquare_RoundsDown()
        {
            int x = 120;
            int expected = 10;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_JustAbovePerfectSquare_RoundsDown()
        {
            int x = 122;
            int expected = 11;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_MaxIntegerValue_HandlesCorrectly()
        {
            int x = int.MaxValue;
            int expected = 46340; // sqrt(2^31-1) ≈ 46340.95
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_LargeNumber_RoundsDownCorrectly()
        {
            int x = 1000000;
            int expected = 1000;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_VeryCloseToNextSquare_RoundsDown()
        {
            int x = 143; // 11^2=121, 12^2=144
            int expected = 11;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MySqrt_AtNextSquareBoundary_ReturnsExact()
        {
            int x = 144;
            int expected = 12;
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 2)]
        [TestCase(5, 2)]
        [TestCase(6, 2)]
        [TestCase(7, 2)]
        [TestCase(8, 2)]
        [TestCase(9, 3)]
        [TestCase(10, 3)]
        [TestCase(15, 3)]
        [TestCase(16, 4)]
        [TestCase(24, 4)]
        [TestCase(25, 5)]
        [TestCase(26, 5)]
        [TestCase(35, 5)]
        [TestCase(36, 6)]
        [TestCase(48, 6)]
        [TestCase(49, 7)]
        [TestCase(63, 7)]
        [TestCase(64, 8)]
        [TestCase(80, 8)]
        [TestCase(81, 9)]
        [TestCase(99, 9)]
        [TestCase(100, 10)]
        [TestCase(120, 10)]
        [TestCase(121, 11)]
        [TestCase(143, 11)]
        [TestCase(144, 12)]
        [TestCase(168, 12)]
        [TestCase(169, 13)]
        [TestCase(195, 13)]
        [TestCase(196, 14)]
        [TestCase(224, 14)]
        [TestCase(225, 15)]
        [TestCase(1000, 31)]
        [TestCase(1024, 32)]
        [TestCase(10000, 100)]
        [TestCase(1000000, 1000)]
        public void MySqrt_ParameterizedTests(int x, int expected)
        {
            int result = _solution.MySqrt(x);
            Assert.That(result, Is.EqualTo(expected),
                $"sqrt({x}) should be {expected} but got {result}");
        }
    }
}
