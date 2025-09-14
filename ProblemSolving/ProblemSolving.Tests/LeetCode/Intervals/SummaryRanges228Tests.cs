using ProblemSolving.LeetCode.Intervals;

namespace ProblemSolving.Tests.LeetCode.Intervals
{
    [TestFixture]
    public class SummaryRanges228Tests
    {
        private SummaryRanges228 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SummaryRanges228();
        }

        [Test]
        public void SummaryRanges_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 0, 1, 2, 4, 5, 7 };
            string[] expected = { "0->2", "4->5", "7" };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void SummaryRanges_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
            string[] expected = { "0", "2->4", "6", "8->9" };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void SummaryRanges_EmptyArray_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { };
            string[] expected = { };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void SummaryRanges_SingleElement_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 1 };
            string[] expected = { "1" };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void SummaryRanges_TwoConsecutive_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 4, 5 };
            string[] expected = { "4->5" };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void SummaryRanges_TwoNonConsecutive_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] nums = { 4, 6 };
            string[] expected = { "4", "6" };

            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(new int[] { 0, 1, 2, 4, 5, 7 }, new string[] { "0->2", "4->5", "7" })]
        [TestCase(new int[] { 1, 3, 5, 7 }, new string[] { "1", "3", "5", "7" })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new string[] { "1->6" })]
        [TestCase(new int[] { -3, -2, -1, 1, 2, 4, 5 }, new string[] { "-3->-1", "1->2", "4->5" })]
        [TestCase(new int[] { -2, -1, 0, 1, 2 }, new string[] { "-2->2" })]
        public void SummaryRanges_NormalCases_ShouldWorkCorrectly(int[] nums, string[] expected)
        {
            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(new int[] { -2147483648, -2147483647, 2147483646, 2147483647 }, new string[] { "-2147483648->-2147483647", "2147483646->2147483647" })]
        [TestCase(new int[] { 1000000, 1000001, 1000003, 1000004, 1000005 }, new string[] { "1000000->1000001", "1000003->1000005" })]
        [TestCase(new int[] { -1, 0, 1, 2, 4 }, new string[] { "-1->2", "4" })]
        public void SummaryRanges_BoundaryCases_ShouldWorkCorrectly(int[] nums, string[] expected)
        {
            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 4, 6, 7, 8, 10 }, new string[] { "1->2", "4", "6->8", "10" })]
        [TestCase(new int[] { 1, 3, 4, 5, 7 }, new string[] { "1", "3->5", "7" })]
        [TestCase(new int[] { 1, 2, 3, 5, 7 }, new string[] { "1->3", "5", "7" })]
        [TestCase(new int[] { 1, 2, 4, 5, 7, 8 }, new string[] { "1->2", "4->5", "7->8" })]
        public void SummaryRanges_AdditionalCases_ShouldWorkCorrectly(int[] nums, string[] expected)
        {
            //  Act
            IList<string> result = _solution.SummaryRanges(nums);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
