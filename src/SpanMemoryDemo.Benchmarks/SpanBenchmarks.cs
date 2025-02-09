using BenchmarkDotNet.Attributes;
using SpanMemoryDemo.Core;

namespace SpanMemoryDemo.Benchmarks;

[MemoryDiagnoser]
public class SpanBenchmarks
{
    private byte[] _destArray;
    private string[] _names;
    private int[] _numbers;
    private string _numberString;
    private byte[] _sourceArray;

    [GlobalSetup]
    public void Setup()
    {
        // İsim array'ini hazırla
        _names = new string[1000];
        for (var i = 0; i < _names.Length; i++)
        {
            _names[i] = $"John Doe{i}";
        }

        // Byte array'lerini hazırla
        _sourceArray = new byte[10000];
        new Random(42).NextBytes(_sourceArray);
        _destArray = new byte[10000];

        // Sayı string'ini hazırla
        var nums = new int[1000];
        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = i;
        }
        _numberString = string.Join(",", nums);
        _numbers = new int[1000];
    }

    [Benchmark(Description = "Traditional String Parsing")]
    public void TraditionalStringParsing()
    {
        foreach (var name in _names)
        {
            var result = StringParsingExample.ParseNameTraditional(name);
        }
    }

    [Benchmark(Description = "Span-based String Parsing")]
    public void SpanStringParsing()
    {
        foreach (var name in _names)
        {
            var result = StringParsingExample.ParseNameWithSpan(name);
        }
    }

    [Benchmark(Description = "Traditional Array Copy")]
    public void TraditionalArrayCopy()
    {
        ArrayOperationsExample.CopyArrayTraditional(_sourceArray, _destArray);
    }

    [Benchmark(Description = "Span-based Array Copy")]
    public void SpanArrayCopy()
    {
        ArrayOperationsExample.CopyArrayWithSpan(_sourceArray, _destArray);
    }

    [Benchmark(Description = "Traditional Number Parsing")]
    public void TraditionalNumberParsing()
    {
        var parts = _numberString.Split(',');
        for (var i = 0; i < parts.Length; i++)
        {
            int.TryParse(parts[i], out _numbers[i]);
        }
    }

    [Benchmark(Description = "Span-based Number Parsing")]
    public void SpanNumberParsing()
    {
        StringParsingExample.TryParseNumbers(_numberString, _numbers);
    }
}