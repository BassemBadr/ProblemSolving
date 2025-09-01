using NUnit.Framework;
using ProblemSolving.LeetCode.Array_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class RomanToInteger13Tests
    {
        private RomanToInteger13 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new RomanToInteger13();
        }

        [Test]
        [Description("Example 1 from problem description")]
        public void RomanToInt_Example1_ShouldReturn3()
        {
            //  Arrange
            string roman = "III";
            int expected = 3;

            //  Act
            int result = _solution.RomanToInt(roman);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 2 from problem description")]
        public void RomanToInt_Example2_ShouldReturn58()
        {
            //  Arrange
            string roman = "LVIII";
            int expected = 58;

            //  Act
            int result = _solution.RomanToInt(roman);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Example 3 from problem description")]
        public void RomanToInt_Example3_ShouldReturn1994()
        {
            //  Arrange
            string roman = "MCMXCIV";
            int expected = 1994;

            //  Act
            int result = _solution.RomanToInt(roman);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        #region Basic Single Character Tests
        [Test]
        [Description("Single character I")]
        public void RomanToInt_SingleI_ShouldReturnOne()
        {
            // Arrange
            string roman = "I";
            int expected = 1;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character V")]
        public void RomanToInt_SingleV_ShouldReturnFive()
        {
            // Arrange
            string roman = "V";
            int expected = 5;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character X")]
        public void RomanToInt_SingleX_ShouldReturnTen()
        {
            // Arrange
            string roman = "X";
            int expected = 10;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character L")]
        public void RomanToInt_SingleL_ShouldReturnFifty()
        {
            // Arrange
            string roman = "L";
            int expected = 50;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character C")]
        public void RomanToInt_SingleC_ShouldReturnHundred()
        {
            // Arrange
            string roman = "C";
            int expected = 100;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character D")]
        public void RomanToInt_SingleD_ShouldReturnFiveHundred()
        {
            // Arrange
            string roman = "D";
            int expected = 500;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single character M")]
        public void RomanToInt_SingleM_ShouldReturnThousand()
        {
            // Arrange
            string roman = "M";
            int expected = 1000;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Basic Addition Tests
        [Test]
        [Description("Simple addition - II")]
        public void RomanToInt_II_ShouldReturnTwo()
        {
            // Arrange
            string roman = "II";
            int expected = 2;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Simple addition - III")]
        public void RomanToInt_III_ShouldReturnThree()
        {
            // Arrange
            string roman = "III";
            int expected = 3;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Simple addition - VI")]
        public void RomanToInt_VI_ShouldReturnSix()
        {
            // Arrange
            string roman = "VI";
            int expected = 6;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Simple addition - VIII")]
        public void RomanToInt_VIII_ShouldReturnEight()
        {
            // Arrange
            string roman = "VIII";
            int expected = 8;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Subtraction Tests
        [Test]
        [Description("Subtraction case - IV")]
        public void RomanToInt_IV_ShouldReturnFour()
        {
            // Arrange
            string roman = "IV";
            int expected = 4;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Subtraction case - IX")]
        public void RomanToInt_IX_ShouldReturnNine()
        {
            // Arrange
            string roman = "IX";
            int expected = 9;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Subtraction case - XL")]
        public void RomanToInt_XL_ShouldReturnForty()
        {
            // Arrange
            string roman = "XL";
            int expected = 40;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Subtraction case - XC")]
        public void RomanToInt_XC_ShouldReturnNinety()
        {
            // Arrange
            string roman = "XC";
            int expected = 90;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Subtraction case - CD")]
        public void RomanToInt_CD_ShouldReturnFourHundred()
        {
            // Arrange
            string roman = "CD";
            int expected = 400;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Subtraction case - CM")]
        public void RomanToInt_CM_ShouldReturnNineHundred()
        {
            // Arrange
            string roman = "CM";
            int expected = 900;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Complex Mixed Cases
        [Test]
        [Description("Mixed case - LVIII (58)")]
        public void RomanToInt_LVIII_ShouldReturnFiftyEight()
        {
            // Arrange
            string roman = "LVIII";
            int expected = 58; // L(50) + V(5) + III(3)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Mixed case - MCMXC (1990)")]
        public void RomanToInt_MCMXC_ShouldReturn1990()
        {
            // Arrange
            string roman = "MCMXC";
            int expected = 1990; // M(1000) + CM(900) + XC(90)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Mixed case - MMCDXLIV (2444)")]
        public void RomanToInt_MMCDXLIV_ShouldReturn2444()
        {
            // Arrange
            string roman = "MMCDXLIV";
            int expected = 2444; // MM(2000) + CD(400) + XL(40) + IV(4)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Complex case - MCDXLIV (1444)")]
        public void RomanToInt_MCDXLIV_ShouldReturn1444()
        {
            // Arrange
            string roman = "MCDXLIV";
            int expected = 1444; // M(1000) + CD(400) + XL(40) + IV(4)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Boundary Value Tests
        [Test]
        [Description("Minimum value - I (1)")]
        public void RomanToInt_MinimumValue_ShouldReturnOne()
        {
            // Arrange
            string roman = "I";
            int expected = 1;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Maximum value - MMMCMXCIX (3999)")]
        public void RomanToInt_MaximumValue_ShouldReturn3999()
        {
            // Arrange
            string roman = "MMMCMXCIX";
            int expected = 3999; // MMM(3000) + CM(900) + XC(90) + IX(9)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large round number - MM (2000)")]
        public void RomanToInt_MM_ShouldReturn2000()
        {
            // Arrange
            string roman = "MM";
            int expected = 2000;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large round number - MMM (3000)")]
        public void RomanToInt_MMM_ShouldReturn3000()
        {
            // Arrange
            string roman = "MMM";
            int expected = 3000;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Specific Pattern Tests
        [Test]
        [Description("Multiple subtractions - CDXLIV (444)")]
        public void RomanToInt_CDXLIV_ShouldReturn444()
        {
            // Arrange
            string roman = "CDXLIV";
            int expected = 444; // CD(400) + XL(40) + IV(4)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Year example - MCMLIV (1954)")]
        public void RomanToInt_MCMLIV_ShouldReturn1954()
        {
            // Arrange
            string roman = "MCMLIV";
            int expected = 1954; // M(1000) + CM(900) + L(50) + IV(4)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("No subtractions - MDCLXVI (1666)")]
        public void RomanToInt_MDCLXVI_ShouldReturn1666()
        {
            // Arrange
            string roman = "MDCLXVI";
            int expected = 1666; // M(1000) + D(500) + C(100) + L(50) + X(10) + V(5) + I(1)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Multiple same characters - XXXIII (33)")]
        public void RomanToInt_XXXIII_ShouldReturn33()
        {
            // Arrange
            string roman = "XXXIII";
            int expected = 33; // XXX(30) + III(3)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Edge Cases with Length
        [Test]
        [Description("Maximum length string")]
        public void RomanToInt_MaximumLengthString_ShouldWork()
        {
            // Arrange
            string roman = "MMMCCCXXXIII"; // 15 characters: 3000 + 300 + 30 + 3 = 3333
            int expected = 3333;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Long string with subtractions")]
        public void RomanToInt_LongStringWithSubtractions_ShouldWork()
        {
            // Arrange
            string roman = "MMMCMXCIX"; // MMM(3000) + CM(900) + XC(90) + IX(9) = 3999
            int expected = 3999;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion

        #region Additional Common Values
        [Test]
        [Description("Common value - L (50)")]
        public void RomanToInt_L_ShouldReturnFifty()
        {
            // Arrange
            string roman = "L";
            int expected = 50;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Common value - C (100)")]
        public void RomanToInt_C_ShouldReturnHundred()
        {
            // Arrange
            string roman = "C";
            int expected = 100;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Common value - D (500)")]
        public void RomanToInt_D_ShouldReturnFiveHundred()
        {
            // Arrange
            string roman = "D";
            int expected = 500;

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Teen number - XIV (14)")]
        public void RomanToInt_XIV_ShouldReturn14()
        {
            // Arrange
            string roman = "XIV";
            int expected = 14; // X(10) + IV(4)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Teen number - XIX (19)")]
        public void RomanToInt_XIX_ShouldReturn19()
        {
            // Arrange
            string roman = "XIX";
            int expected = 19; // X(10) + IX(9)

            // Act
            int result = _solution.RomanToInt(roman);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion
    }
}
