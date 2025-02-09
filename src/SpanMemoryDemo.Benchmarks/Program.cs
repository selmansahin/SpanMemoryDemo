using BenchmarkDotNet.Running;
using SpanMemoryDemo.Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<SpanBenchmarks>();
    }
}