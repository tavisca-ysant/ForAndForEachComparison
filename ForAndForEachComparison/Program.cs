using BenchmarkDotNet.Running;
using System;

namespace ForAndForEachComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var Summary = BenchmarkRunner.Run<Comparison>();
            Console.ReadKey(true);
        }
    }
}
