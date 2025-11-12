using ProblemSolving.LeetCode._1D_DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode._1D_DP
{
    [TestFixture]
    internal class ClimbingStairs70Tests
    {
        private ClimbingStairs70 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ClimbingStairs70();
        }

        [Test]
        public void ClimbStairs_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int n = 2;
            int expected = 2;

            //  Act
            int result = _solution.ClimbStairs(n);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_Example2_ShouldWorkCorrectly()
        {
            int n = 3;
            int expected = 3;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_BaseCase1Step_Returns1()
        {
            int n = 1;
            int expected = 1;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_4Steps_Returns5()
        {
            int n = 4;
            int expected = 5; // 1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 2+2
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_5Steps_Returns8()
        {
            int n = 5;
            int expected = 8;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_6Steps_Returns13()
        {
            int n = 6;
            int expected = 13;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_7Steps_Returns21()
        {
            int n = 7;
            int expected = 21;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_8Steps_Returns34()
        {
            int n = 8;
            int expected = 34;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_9Steps_Returns55()
        {
            int n = 9;
            int expected = 55;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_10Steps_Returns89()
        {
            int n = 10;
            int expected = 89;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_20Steps_Returns10946()
        {
            int n = 20;
            int expected = 10946;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_30Steps_Returns1346269()
        {
            int n = 30;
            int expected = 1346269;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_40Steps_Returns165580141()
        {
            int n = 40;
            int expected = 165580141;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ClimbStairs_45Steps_Returns1836311903()
        {
            int n = 45;
            int expected = 1836311903;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(6, 13)]
        [TestCase(7, 21)]
        [TestCase(8, 34)]
        [TestCase(9, 55)]
        [TestCase(10, 89)]
        [TestCase(11, 144)]
        [TestCase(12, 233)]
        [TestCase(13, 377)]
        [TestCase(14, 610)]
        [TestCase(15, 987)]
        [TestCase(16, 1597)]
        [TestCase(17, 2584)]
        [TestCase(18, 4181)]
        [TestCase(19, 6765)]
        [TestCase(20, 10946)]
        public void ClimbStairs_ParameterizedTests(int n, int expected)
        {
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected),
                $"Failed for {n} steps. Expected {expected} but got {result}");
        }

        [Test]
        public void ClimbStairs_MaximumInput_ReturnsCorrectValue()
        {
            int n = 45;
            int expected = 1836311903;
            int result = _solution.ClimbStairs(n);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
