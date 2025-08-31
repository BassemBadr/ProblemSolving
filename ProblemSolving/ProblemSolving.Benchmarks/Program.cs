using BenchmarkDotNet.Running;
using ProblemSolving.Benchmarks.LeetCode.Array_String;

//BenchmarkRunner.Run(typeof(Program).Assembly);
BenchmarkRunner.Run<BestTimeBuySellStock121Benchmarks>();

Console.ReadLine();