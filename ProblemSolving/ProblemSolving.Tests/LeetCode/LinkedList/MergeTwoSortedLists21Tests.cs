using ProblemSolving.LeetCode.LinkedList;
using ProblemSolving.LeetCode.Types;
using ProblemSolving.Tests.Assertions;
using ProblemSolving.Tests.Helpers;

namespace ProblemSolving.Tests.LeetCode.LinkedList
{
    [TestFixture]
    public class MergeTwoSortedLists21Tests
    {
        private MergeTwoSortedLists21 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new MergeTwoSortedLists21();
        }

        [Test]
        public void MergeTwoLists_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 2, 4]);
            ListNode head2 = ListNodeHelper.CreateListNode([1, 3, 4]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 1, 2, 3, 4, 4]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([]);
            ListNode head2 = ListNodeHelper.CreateListNode([]);
            ListNode expected = ListNodeHelper.CreateListNode([]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([]);
            ListNode head2 = ListNodeHelper.CreateListNode([0]);
            ListNode expected = ListNodeHelper.CreateListNode([0]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_SecondListEmpty_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([0]);
            ListNode head2 = ListNodeHelper.CreateListNode([]);
            ListNode expected = ListNodeHelper.CreateListNode([0]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_BothSingleElkement_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1]);
            ListNode head2 = ListNodeHelper.CreateListNode([2]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_NormalCase_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 3, 5]);
            ListNode head2 = ListNodeHelper.CreateListNode([2, 4, 6]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 6]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_DifferentLength_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 5, 9]);
            ListNode head2 = ListNodeHelper.CreateListNode([2, 3, 4, 6, 7, 8]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 6, 7, 8, 9]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_FirstListLonger_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 3, 5, 7, 9]);
            ListNode head2 = ListNodeHelper.CreateListNode([2, 4]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 7, 9]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_SecondListLonger_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 10]);
            ListNode head2 = ListNodeHelper.CreateListNode([2, 3, 4, 5, 6, 7, 8, 9]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_FirstComeFirst_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 2, 3]);
            ListNode head2 = ListNodeHelper.CreateListNode([4, 5, 6]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 6]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_SecondComeFirst_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([4, 5, 6]);
            ListNode head2 = ListNodeHelper.CreateListNode([1, 2, 3]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5, 6]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_DuplicatesInList1_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 2, 2, 3]);
            ListNode head2 = ListNodeHelper.CreateListNode([1, 3, 4]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 1, 2, 2, 3, 3, 4]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_DuplicatesAcross_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 3, 5]);
            ListNode head2 = ListNodeHelper.CreateListNode([1, 3, 5]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 1, 3, 3, 5, 5]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_MultipleDuplicates_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([2, 2, 2]);
            ListNode head2 = ListNodeHelper.CreateListNode([1, 1, 3, 3]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 1, 2, 2, 2, 3, 3]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_BoundaryMinValues_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([-100, -50]);
            ListNode head2 = ListNodeHelper.CreateListNode([-75, 0]);
            ListNode expected = ListNodeHelper.CreateListNode([-100, -75, -50, 0]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_BoundaryMaxValues_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([50, 100]);
            ListNode head2 = ListNodeHelper.CreateListNode([75, 90]);
            ListNode expected = ListNodeHelper.CreateListNode([50, 75, 90, 100]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_PositiveNegative_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([-5, 0, 5]);
            ListNode head2 = ListNodeHelper.CreateListNode([-3, 3]);
            ListNode expected = ListNodeHelper.CreateListNode([-5, -3, 0, 3, 5]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_List2WithinList1_ShouldWorkCorrectly()
        {
            //  Arrange
            ListNode head1 = ListNodeHelper.CreateListNode([1, 2, 3, 4, 5]);
            ListNode head2 = ListNodeHelper.CreateListNode([2, 3, 4]);
            ListNode expected = ListNodeHelper.CreateListNode([1, 2, 2, 3, 3, 4, 4, 5]);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }

        [Test]
        public void MergeTwoLists_MaxSize_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] list1 = new int[50];
            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = i;
            }
            ListNode head1 = ListNodeHelper.CreateListNode(list1);
            
            int[] list2 = new int[50];
            for (int i = 0; i < list2.Length; i++)
            {
                list2[i] =50+ i;
            }
            ListNode head2 = ListNodeHelper.CreateListNode(list2);

            int[] list3 = new int[100];
            for (int i = 0; i < list3.Length; i++)
            {
                list3[i] = i;               
            }
            ListNode expected = ListNodeHelper.CreateListNode(list3);

            //  Act
            ListNode result = _solution.MergeTwoLists(head1, head2);

            //  Assert
            Assert.That(result, LinkedListsEqualAssertion.AreLinkedListsEqual(expected));
        }
    }
}
