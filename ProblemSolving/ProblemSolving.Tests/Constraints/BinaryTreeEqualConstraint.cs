using NUnit.Framework.Constraints;
using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.Constraints
{
    public class BinaryTreeEqualConstraint : Constraint
    {
        private TreeNode _expected;

        public BinaryTreeEqualConstraint(TreeNode expected)
        {
            _expected = expected;
        }
        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            bool areTheSame = new SameTree100().IsSameTree(actual as TreeNode, _expected);
            return new ConstraintResult(this, actual as TreeNode, areTheSame);
        }

        public override string Description => "binary trees to be equal";
    }
}
