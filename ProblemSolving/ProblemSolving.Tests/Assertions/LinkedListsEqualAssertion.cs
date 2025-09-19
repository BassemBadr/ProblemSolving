using ProblemSolving.LeetCode.Types;
using ProblemSolving.Tests.Constraints;

namespace ProblemSolving.Tests.Assertions
{
    internal class LinkedListsEqualAssertion
    {
        public static LinkedListsEqualConstraint AreLinkedListsEqual(ListNode expected)
        {
            return new LinkedListsEqualConstraint(expected);
        }
    }
}
