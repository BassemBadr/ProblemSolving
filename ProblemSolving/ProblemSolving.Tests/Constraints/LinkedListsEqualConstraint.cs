using NUnit.Framework.Constraints;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.Constraints
{
    internal class LinkedListsEqualConstraint : Constraint
    {
        private readonly ListNode _expected;

        public LinkedListsEqualConstraint(ListNode expected)
        {
            _expected = expected;
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            bool areEqual = ListNode.AreNonCyclicListsEqual(_expected, actual as ListNode);
            return new ConstraintResult(this, actual, areEqual);
        }

        public override string Description => "linked lists to be equal";
    }
}
