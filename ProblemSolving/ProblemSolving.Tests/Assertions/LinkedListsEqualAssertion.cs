using ProblemSolving.Tests.Constraints;
using ProblemSolving.Types;

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
