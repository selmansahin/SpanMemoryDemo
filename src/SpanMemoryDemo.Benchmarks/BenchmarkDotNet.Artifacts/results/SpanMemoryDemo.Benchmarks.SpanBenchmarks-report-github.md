```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3037)
13th Gen Intel Core i7-1360P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                       | Mean        | Error       | StdDev      | Median       | Gen0    | Gen1   | Allocated |
|----------------------------- |------------:|------------:|------------:|-------------:|--------:|-------:|----------:|
| &#39;Traditional String Parsing&#39; | 45,622.7 ns | 2,979.56 ns | 8,500.84 ns | 44,800.38 ns | 11.8103 |      - |  111200 B |
| &#39;Span-based String Parsing&#39;  | 23,332.6 ns |   975.00 ns | 2,717.90 ns | 23,133.08 ns |  8.4839 |      - |   79920 B |
| &#39;Traditional Array Copy&#39;     |    107.9 ns |     5.15 ns |    14.71 ns |    103.34 ns |       - |      - |         - |
| &#39;Span-based Array Copy&#39;      |    100.9 ns |     4.27 ns |    12.45 ns |     96.94 ns |       - |      - |         - |
| &#39;Traditional Number Parsing&#39; | 16,957.1 ns |   822.65 ns | 2,373.55 ns | 16,458.43 ns |  4.2419 | 0.5188 |   39944 B |
| &#39;Span-based Number Parsing&#39;  |  9,567.3 ns |   457.83 ns | 1,306.21 ns |  8,982.23 ns |       - |      - |         - |
