using BenchmarkDotNet.Attributes;
using ProblemSolving.LeetCode.Array_String;

namespace ProblemSolving.Benchmarks.LeetCode.Array_String
{
    [MemoryDiagnoser]
    [RankColumn]
    public class BestTimeBuySellStock121Benchmarks
    {
        private int[] _prices = [];
        private readonly BestTimeBuySellStock121 _pricingService = new();

        [GlobalSetup]
        public void Setup()
        {
            _prices = GenerateTestData(100000);
        }

        [Benchmark]
        public int MaxProfit_Benchmark() => _pricingService.MaxProfit(_prices);

        private int[] GenerateTestData(int size)
        {
            var random = new Random(42); // Seed for consistency
            return Enumerable.Range(1, size)
                           .Select(_ => random.Next(1, 10000))
                           .ToArray();
        }
    }
}
