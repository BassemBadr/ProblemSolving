using ProblemSolving.LeetCode.MathLogic;

namespace ProblemSolving.Tests.LeetCode.MathLogic
{
    [TestFixture]
    internal class PlusOne66Tests
    {
        private PlusOne66 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new PlusOne66();
        }

        [Test]
        public void PlusOne_Example1_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] degits = [1, 2, 3];
            int[] expected = [1, 2, 4];

            //  Act
            int[] result = _solution.PlusOne(degits);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void PlusOne_Example2_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] degits = [4, 3, 2, 1];
            int[] expected = [4, 3, 2, 2];

            //  Act
            int[] result = _solution.PlusOne(degits);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void PlusOne_Example3_ShouldWorkCorrectly()
        {
            //  Arrange
            int[] degits = [9];
            int[] expected = [1, 0];

            //  Act
            int[] result = _solution.PlusOne(degits);

            //  Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void PlusOne_SingleDigitNoCarry_ReturnsCorrect()
        {
            int[] digits = [5];
            int[] expected = [6];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_NoCarryNeeded_ReturnsIncrementedLastDigit()
        {
            int[] digits = [1, 2, 3, 4];
            int[] expected = [1, 2, 3, 5];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_EndsWithNonNine_SimpleIncrement()
        {
            int[] digits = [8, 7, 6, 5];
            int[] expected = [8, 7, 6, 6];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_MiddleDigitsNotNine_NoCarry()
        {
            int[] digits = [1, 4, 5, 8];
            int[] expected = [1, 4, 5, 9];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_LastDigitNine_CarriesOne()
        {
            int[] digits = [1, 2, 9];
            int[] expected = [1, 3, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_MultipleEndingNines_CarriesThrough()
        {
            int[] digits = [1, 9, 9];
            int[] expected = [2, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_TwoNinesAtEnd_CarriesTwice()
        {
            int[] digits = [3, 8, 9, 9];
            int[] expected = [3, 9, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_AllNines_AddsNewDigit()
        {
            int[] digits = [9, 9, 9];
            int[] expected = [1, 0, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_ManyNines_ExpandsArray()
        {
            int[] digits = [9, 9, 9, 9];
            int[] expected = [1, 0, 0, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_CarryPropagatesToBeginning_NewDigitCreated()
        {
            int[] digits = [9, 9, 9, 9, 9];
            int[] expected = [1, 0, 0, 0, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_SomeNinesSomeNot_CarriesCorrectly()
        {
            int[] digits = [2, 9, 9, 5, 9];
            int[] expected = [2, 9, 9, 6, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_NinesInMiddle_CarriesThroughMiddle()
        {
            int[] digits = [1, 8, 9, 9, 0];
            int[] expected = [1, 8, 9, 9, 1];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_ComplexCarryPattern_HandlesCorrectly()
        {
            int[] digits = [4, 9, 2, 9, 9];
            int[] expected = [4, 9, 3, 0, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_MaxLengthArray_HandlesCorrectly()
        {
            int[] digits = new int[100];
            Array.Fill(digits, 9);
            int[] expected = new int[101];
            expected[0] = 1;
            // Rest are zeros by default

            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_MinLengthArray_HandlesCorrectly()
        {
            int[] digits = [7];
            int[] expected = [8];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_ZeroInMiddle_NoSpecialHandling()
        {
            int[] digits = [1, 0, 0, 0];
            int[] expected = [1, 0, 0, 1];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_StartsWithOneEndsWithNine_CarriesCorrectly()
        {
            int[] digits = [1, 9];
            int[] expected = [2, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_AlternatingDigits_NoCarry()
        {
            int[] digits = [1, 2, 1, 2];
            int[] expected = [1, 2, 1, 3];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_AllSameDigitsNoNine_SimpleIncrement()
        {
            int[] digits = [2, 2, 2, 2];
            int[] expected = [2, 2, 2, 3];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_AllSameDigitsWithNine_Carries()
        {
            int[] digits = [8, 8, 8, 9];
            int[] expected = [8, 8, 9, 0];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_IncreasingSequence_HandlesCorrectly()
        {
            int[] digits = [1, 2, 3, 4, 5];
            int[] expected = [1, 2, 3, 4, 6];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void PlusOne_DecreasingSequence_HandlesCorrectly()
        {
            int[] digits = [9, 8, 7, 6];
            int[] expected = [9, 8, 7, 7];
            int[] result = _solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
