using ProblemSolving.LeetCode.Stack;
using System.Text;

namespace ProblemSolving.Tests.LeetCode.Stack
{
    public class ValidParentheses20Tests
    {
        private ValidParentheses20 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ValidParentheses20();
        }

        [Test]
        public void IsValid_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            string s = "()";

            //  Act
            bool result = _solution.IsValid(s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            string s = "()[]{}";

            //  Act
            bool result = _solution.IsValid(s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            string s = "(]";

            //  Act
            bool result = _solution.IsValid(s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_Example4_ShouldWorkCorrectly()
        {
            //  Arrange
            string s = "([])";

            //  Act
            bool result = _solution.IsValid(s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_Example5_ShouldWorkCorrectly()
        {
            //  Arrange
            string s = "([)]";

            //  Act
            bool result = _solution.IsValid(s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_SingleOpenParenthesis_ReturnsFalse()
        {
            // Arrange
            string s = "(";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_SingleCloseParenthesis_ReturnsFalse()
        {
            // Arrange
            string s = ")";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_SinglePairParentheses_ReturnsTrue()
        {
            // Arrange
            string s = "()";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_SinglePairSquareBrackets_ReturnsTrue()
        {
            // Arrange
            string s = "[]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_SinglePairCurlyBraces_ReturnsTrue()
        {
            // Arrange
            string s = "{}";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_AllThreeTypes_ReturnsTrue()
        {
            // Arrange
            string s = "()[]{}";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_NestedParentheses_ReturnsTrue()
        {
            // Arrange
            string s = "(())";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_NestedAllTypes_ReturnsTrue()
        {
            // Arrange
            string s = "([{}])";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_ComplexNesting_ReturnsTrue()
        {
            // Arrange
            string s = "({[]})";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_MismatchedTypes_ReturnsFalse()
        {
            // Arrange
            string s = "(]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_MismatchedTypesParenSquare_ReturnsFalse()
        {
            // Arrange
            string s = "([)]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_WrongOrder_ReturnsFalse()
        {
            // Arrange
            string s = ")(";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_ExtraOpeningBracket_ReturnsFalse()
        {
            // Arrange
            string s = "((";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_ExtraClosingBracket_ReturnsFalse()
        {
            // Arrange
            string s = "))";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_UnevenCount_ReturnsFalse()
        {
            // Arrange
            string s = "(()";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_MultipleNestedValid_ReturnsTrue()
        {
            // Arrange
            string s = "((()))";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_MultipleTypesSequential_ReturnsTrue()
        {
            // Arrange
            string s = "(){}[]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_MultipleTypesInterleaved_ReturnsTrue()
        {
            // Arrange
            string s = "({[]})";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_ClosingBeforeOpening_ReturnsFalse()
        {
            // Arrange
            string s = "}(";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_ClosingSquareBeforeOpenParen_ReturnsFalse()
        {
            // Arrange
            string s = "](";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_LongValidString_ReturnsTrue()
        {
            // Arrange
            string s = "(()())([]{})[{}]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_LongInvalidString_ReturnsFalse()
        {
            // Arrange
            string s = "(()())([]{})[{}";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // Missing closing bracket
        }

        [Test]
        public void IsValid_OnlyOpeningBrackets_ReturnsFalse()
        {
            // Arrange
            string s = "([{";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_OnlyClosingBrackets_ReturnsFalse()
        {
            // Arrange
            string s = ")]}";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_ComplexNestedStructure_ReturnsTrue()
        {
            // Arrange
            string s = "(({}[])())";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_ComplexInvalidStructure_ReturnsFalse()
        {
            // Arrange
            string s = "(({}[])()";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // Missing closing parenthesis
        }

        [Test]
        public void IsValid_AlternatingTypes_ReturnsTrue()
        {
            // Arrange
            string s = "(){}[](){}[]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_CrossedBrackets_ReturnsFalse()
        {
            // Arrange
            string s = "([)]";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // Crossed: ( [ ) ]
        }

        [Test]
        public void IsValid_TripleCrossed_ReturnsFalse()
        {
            // Arrange
            string s = "({[}])";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // { closed by } before [ is closed
        }

        [Test]
        public void IsValid_DeepNesting_ReturnsTrue()
        {
            // Arrange
            string s = "((((((()))))))";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_DeepNestingIncomplete_ReturnsFalse()
        {
            // Arrange
            string s = "((((((())))))";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // One less closing bracket
        }

        [Test]
        public void IsValid_MixedDeepNesting_ReturnsTrue()
        {
            // Arrange
            string s = "({[({[]})]})";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_SingleOpenSquare_ReturnsFalse()
        {
            // Arrange
            string s = "[";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_SingleCloseCurly_ReturnsFalse()
        {
            // Arrange
            string s = "}";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_LargeValidExpression_ReturnsTrue()
        {
            // Arrange
            StringBuilder sb = new StringBuilder();
            // Create a large valid expression: (((...))) with 1000 pairs
            for (int i = 0; i < 1000; i++)
            {
                sb.Append("(");
            }
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(")");
            }
            string s = sb.ToString();

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_LargeInvalidExpression_ReturnsFalse()
        {
            // Arrange
            StringBuilder sb = new StringBuilder();
            // Create a large invalid expression: (((...)) with 1000 opening, 999 closing
            for (int i = 0; i < 1000; i++)
            {
                sb.Append("(");
            }
            for (int i = 0; i < 999; i++)
            {
                sb.Append(")");
            }
            string s = sb.ToString();

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_LargeMixedValidExpression_ReturnsTrue()
        {
            // Arrange
            StringBuilder sb = new StringBuilder();
            // Create pattern: ()[]{}()[]{}... repeated 500 times
            for (int i = 0; i < 500; i++)
            {
                sb.Append("()[]{}");
            }
            string s = sb.ToString();

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_EmptyString_ReturnsTrue()
        {
            // Arrange
            string s = "";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True); // Empty string is considered valid
        }

        [Test]
        public void IsValid_AllTypesReversed_ReturnsFalse()
        {
            // Arrange
            string s = "}{][)(";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_ConsecutivePairs_ReturnsTrue()
        {
            // Arrange
            string s = "()()()(";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.False); // Last opening bracket not closed
        }

        [Test]
        public void IsValid_ConsecutivePairsComplete_ReturnsTrue()
        {
            // Arrange
            string s = "()()()()";

            // Act
            bool result = _solution.IsValid(s);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
