using NUnit.Framework;
using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Tests.LeetCode.Array_String
{
    [TestFixture]
    public class BestTimeBuySellStock121Tests
    {
        private BestTimeBuySellStock121 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new BestTimeBuySellStock121();
        }

        [Test]
        [Description("example one from problem description")]
        public void MaxProfit_BasicEaxmple1_ShouldWorkNormally()
        {
            //  Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            //  Act
            int result = _solution.MaxProfit(prices);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("example two from problem description")]
        public void MaxProfit_BasicEaxmple2_ShouldWorkNormally()
        {
            //  Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;

            //  Act
            int result = _solution.MaxProfit(prices);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Single day - no transaction possible")]
        public void MaxProfit_SingleDay_ShouldReturnZero()
        {
            // Arrange
            int[] prices = { 5 };
            int expected = 0; // Can't buy and sell on same day

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Two days with profit")]
        public void MaxProfit_TwoDaysWithProfit_ShouldReturnProfit()
        {
            // Arrange
            int[] prices = { 3, 8 };
            int expected = 5; // Buy at 3, sell at 8

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Two days with loss")]
        public void MaxProfit_TwoDaysWithLoss_ShouldReturnZero()
        {
            // Arrange
            int[] prices = { 8, 3 };
            int expected = 0; // Can't sell before buying

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("All prices are the same")]
        public void MaxProfit_AllSamePrices_ShouldReturnZero()
        {
            // Arrange
            int[] prices = { 4, 4, 4, 4, 4 };
            int expected = 0; // No profit from same prices

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Best profit at the very end")]
        public void MaxProfit_BestProfitAtEnd_ShouldWork()
        {
            // Arrange
            int[] prices = { 2, 4, 1, 1, 1, 10 };
            int expected = 9; // Buy at 1, sell at 10

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Multiple local maxima - should find global maximum")]
        public void MaxProfit_MultipleLocalMaxima_ShouldFindGlobalMax()
        {
            // Arrange
            int[] prices = { 3, 8, 2, 7, 1, 9 };
            int expected = 8; // Buy at 1, sell at 9 (not 3→8 = 5)

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Buy at minimum, sell at maximum")]
        public void MaxProfit_MinToMax_ShouldWork()
        {
            // Arrange
            int[] prices = { 5, 1, 3, 6, 4 };
            int expected = 5; // Buy at 1, sell at 6

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Minimum values from constraints")]
        public void MaxProfit_MinimumValues_ShouldWork()
        {
            // Arrange
            int[] prices = { 0, 1, 0, 2 };
            int expected = 2; // Buy at 0, sell at 2

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Maximum values from constraints")]
        public void MaxProfit_MaximumValues_ShouldWork()
        {
            // Arrange
            int[] prices = { 5000, 10000, 8000, 9999 };
            int expected = 5000; // Buy at 5000, sell at 10000

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Gradual increase - maximum profit")]
        public void MaxProfit_GradualIncrease_ShouldReturnMaxProfit()
        {
            // Arrange
            int[] prices = { 1, 2, 3, 4, 5, 6 };
            int expected = 5; // Buy at 1, sell at 6

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("V-shaped pattern")]
        public void MaxProfit_VShapedPattern_ShouldWork()
        {
            // Arrange
            int[] prices = { 6, 4, 2, 1, 3, 5, 7 };
            int expected = 6; // Buy at 1, sell at 7

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Mountain pattern - peak in middle")]
        public void MaxProfit_MountainPattern_ShouldWork()
        {
            // Arrange
            int[] prices = { 1, 5, 3, 6, 4 };
            int expected = 5; // Buy at 1, sell at 6 (not 1→5=4)

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Multiple valleys and peaks")]
        public void MaxProfit_MultipleValleysAndPeaks_ShouldFindOptimal()
        {
            // Arrange
            int[] prices = { 3, 2, 6, 5, 0, 3 };
            int expected = 4; // Buy at 2, sell at 6 (or buy at 0, sell at 3)

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Late minimum price")]
        public void MaxProfit_LateMinimum_ShouldWork()
        {
            // Arrange
            int[] prices = { 10, 8, 6, 4, 2, 5 };
            int expected = 3; // Buy at 2, sell at 5

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Large array test with optimal profit")]
        public void MaxProfit_LargeArray_ShouldWork()
        {
            // Arrange
            // Create pattern: high prices, then minimum, then maximum
            var prices = new int[1000];

            // First 500 days: decreasing from 1000 to 501
            for (int i = 0; i < 500; i++)
            {
                prices[i] = 1000 - i;
            }

            // Day 500: minimum price of 1
            prices[500] = 1;

            // Remaining days: increase to 500
            for (int i = 501; i < 1000; i++)
            {
                prices[i] = i - 500 + 1;
            }

            int expected = 499; // Buy at 1, sell at 500

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Zero prices allowed by constraints")]
        public void MaxProfit_WithZeroPrices_ShouldWork()
        {
            // Arrange
            int[] prices = { 0, 3, 0, 5, 0 };
            int expected = 5; // Buy at 0, sell at 5

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Description("Early peak followed by better opportunity")]
        public void MaxProfit_EarlyPeakBetterLater_ShouldChooseOptimal()
        {
            // Arrange
            int[] prices = { 2, 7, 1, 8 }; // Could do 2→7=5, but 1→8=7 is better
            int expected = 7; // Buy at 1, sell at 8

            // Act
            int result = _solution.MaxProfit(prices);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
