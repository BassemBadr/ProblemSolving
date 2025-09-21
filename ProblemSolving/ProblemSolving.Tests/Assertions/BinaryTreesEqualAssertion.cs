using ProblemSolving.Tests.Constraints;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.Assertions
{
    public class BinaryTreesEqualAssertion
    {
        public static BinaryTreeEqualConstraint AreBinaryTreesEqual(TreeNode expected)
        {
            return new BinaryTreeEqualConstraint(expected);
        }
    }
}
