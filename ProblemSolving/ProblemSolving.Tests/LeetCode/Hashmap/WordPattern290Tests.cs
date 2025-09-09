using ProblemSolving.LeetCode.Hashmap;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class WordPattern290Tests
    {
        private WordPattern290 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new WordPattern290();
        }

        [Test]
        [Description("Example 1 from problem description 'abba' & 'dog cat cat dog'")]
        public void WordPattern_Example1_ShouldReturnTrue()
        {
            //  Arrange
            string pattern = "abba";
            string s = "dog cat cat dog";

            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("Example 2 from problem description 'abba' & 'dog cat cat fish'")]
        public void WordPattern_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string pattern = "abba";
            string s = "dog cat cat fish";

            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Example 3 from problem description 'aaaa' & 'dog cat cat dog'")]
        public void WordPattern_Example3_ShouldReturnFalse()
        {
            //  Arrange
            string pattern = "aaaa";
            string s = "dog cat cat dog";

            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("basic positive cases")]
        [TestCase("abba", "dog cat cat dog")]
        [TestCase("abc", "dog cat fish")]
        [TestCase("a", "dog")]
        public void WordPattern_BasicPositive_ShouldReturnTrue(string pattern, string s)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("basic negative cases")]
        [TestCase("abba", "dog cat cat fish")]
        [TestCase("aaaa", "dog cat cat dog")]
        [TestCase("abba", "dog dog dog dog")]
        public void WordPattern_BasicNegative_ShouldReturnFalse(string pattern, string s)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("length mismatch")]
        [TestCase("abc", "dog cat")]
        [TestCase("ab", "dog cat fish")]
        [TestCase("", "dog cat")]
        [TestCase("abc", "")]
        public void WordPattern_LengthMismatch_ShouldReturnFalse(string pattern, string s)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Bijection Validation Cases")]
        [TestCase("abba", "dog dog dog dog")]
        [TestCase("aaaa", "dog cat cat dog")]
        [TestCase("abba", "dog cat fish dog")]
        public void WordPattern_Bijection_ShouldReturnFalse(string pattern, string s)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Description("Single Character word cases")]
        [TestCase("a", "dog", true)]
        [TestCase("aa", "dog dog", true)]
        [TestCase("aa", "dog cat", false)]
        [TestCase("ab", "dog dog", false)]
        public void WordPattern_Bijection_ShouldReturnWorkCorrectly(string pattern, string s, bool expected)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("complex pattern")]
        [TestCase("abcabc", "dog cat fish dog cat fish", true)]
        [TestCase("abcabc", "dog cat fish dog cat bird", false)]
        [TestCase("aabbcc", "dog dog cat cat fish fish", true)]
        public void WordPattern_Complex_ShouldReturnWorkCorrectly(string pattern, string s, bool expected)
        {
            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("boundary case correct")]
        public void WordPattern_BoundaryCase_ShouldReturnTrue()
        {
            //  Arrange
            string pattern = new string('a', 300);
            string s = string.Join(" ", Enumerable.Repeat("word", 300));

            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("boundary case incorrect")]
        public void WordPattern_BoundaryCase_ShouldReturnFalse()
        {
            //  Arrange
            string pattern = new string('a', 300);
            string s = string.Join(" ", Enumerable.Repeat("word", 299));

            //  Act
            bool result = _solution.WordPattern(pattern, s);

            //  Assert
            Assert.That(result, Is.False);
        }
    }
}
