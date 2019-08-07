using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace ForAndForEachComparison
{
    [MemoryDiagnoser]
    public class Comparison
    {
         List<int> _numbers = new List<int>();
       

        [GlobalSetup]
        public void Setup()
        {
            for(int i = 0; i < 1000; i++)
            {
                _numbers.Add(i);
            }
        }

        [Benchmark]

        public void ForLoop()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < 1000; i++)
            {
                numbers.Add(_numbers[i]);
            }
        }

        [Benchmark]

        public void ForEachLoop()
        {
            List<int> numbers = new List<int>();
            foreach (var item in _numbers)
            {
                numbers.Add(item);
            }
        }
    }
}
