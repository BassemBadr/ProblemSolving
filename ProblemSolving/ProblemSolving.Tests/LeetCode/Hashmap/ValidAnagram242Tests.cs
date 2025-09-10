using ProblemSolving.LeetCode.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Hashmap
{
    [TestFixture]
    public class ValidAnagram242Tests
    {
        private ValidAnagram242 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new ValidAnagram242();
        }

        [Test]
        [Description("Example 1 from problem description 'anagram' & 'nagaram'")]
        public void IsAnagram_Example1_ShouldReturnTrue()
        {
            //  Arrange
            string s = "anagram";
            string t = "nagaram";
            bool expected = true;

            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 2 from problem description 'rat' & 'car'")]
        public void IsAnagram_Example2_ShouldReturnFalse()
        {
            //  Arrange
            string s = "rat";
            string t = "car";
            bool expected = false;

            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("single letter test cases")]
        [TestCase("a", "a", true)]
        [TestCase("a", "b", false)]
        public void IsAnagram_Example2_ShouldReturnFalse(string s, string t, bool expected)
        {
            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("two letters test cases")]
        [TestCase("aa", "aa", true)]
        [TestCase("ab", "ab", true)]
        [TestCase("ab", "ba", true)]
        [TestCase("ab", "ca", false)]
        [TestCase("ab", "ac", false)]
        public void IsAnagram_TwoLetters_ShouldWorkCorrrectly(string s, string t, bool expected)
        {
            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("multible letters test cases")]
        [TestCase("abcd", "abcd", true)]
        [TestCase("abcd", "dsba", false)]
        [TestCase("abcd", "badc", true)]
        [TestCase("abcd", "bacd", true)]
        [TestCase("abcd", "abbd", false)]
        [TestCase("aaaa", "aaaa", true)]
        [TestCase("aabb", "baba", true)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", true)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "zabcdefghijklmnopqrstuvwxy", true)]
        public void IsAnagram_MultipleLetters_ShouldWorkCorrrectly(string s, string t, bool expected)
        {
            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("different length test cases")]
        [TestCase("abcdef", "abcdef", true)]
        [TestCase("abcdef", "abcde", false)]
        [TestCase("abcdef", "abcdefg", false)]
        public void IsAnagram_DifferentLength_ShouldWorkCorrrectly(string s, string t, bool expected)
        {
            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("max length test case")]
        public void IsAnagram_MaxLength_ShouldWorkCorrrectly()
        {
            //  Arrange
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string s = new string('a', 45000) + alphabet;
            string t = alphabet + new string('a', 45000);
            bool expected = true;

            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("max length test case")]
        public void IsAnagram_MaxLength2_ShouldWorkCorrrectly()
        {
            //  Arrange
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string s = new string('a', 45000) + alphabet;
            string t = alphabet + new string('b', 45000);
            bool expected = false;

            //  Act 
            bool result = _solution.IsAnagram(s, t);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
