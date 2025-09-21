using ProblemSolving.LeetCode.LinkedList;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.LinkedList
{
    [TestFixture]
    public class LinkedListCycle141Tests
    {
        private LinkedListCycle141 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new LinkedListCycle141();
        }

        [Test]
        public void HasCycle_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head = ListNodeHelper.CreateListNode([3, 2, 0, -4], 1);

            //  Act
            bool result = _solution.HasCycle(head);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void HasCycle_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head = ListNodeHelper.CreateListNode2([1, 2], 0);

            //  Act
            bool result = _solution.HasCycle(head);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void HasCycle_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head = ListNodeHelper.CreateListNode([1], -1);

            //  Act
            bool result = _solution.HasCycle(head);

            //  Assert
            Assert.That(result, Is.False);
        }
    }
}
