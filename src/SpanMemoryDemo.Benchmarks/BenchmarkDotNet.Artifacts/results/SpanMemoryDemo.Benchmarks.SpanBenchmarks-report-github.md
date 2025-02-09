```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3037)
13th Gen Intel Core i7-1360P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                   | Mean        | Error       | StdDev      | Median      | Gen0    | Gen1   | Allocated |
|------------------------- |------------:|------------:|------------:|------------:|--------:|-------:|----------:|
| TraditionalStringParsing | 36,238.1 ns | 2,089.50 ns | 5,893.48 ns | 35,040.2 ns | 11.8103 |      - |  111200 B |
| SpanStringParsing        | 24,023.2 ns | 1,172.13 ns | 3,286.77 ns | 23,697.5 ns |  8.4839 |      - |   79920 B |
| TraditionalArrayCopy     |    118.4 ns |     8.10 ns |    23.25 ns |    110.4 ns |       - |      - |         - |
| SpanArrayCopy            |    110.4 ns |     6.56 ns |    18.40 ns |    105.6 ns |       - |      - |         - |
| TraditionalNumberParsing | 18,465.6 ns | 1,319.76 ns | 3,807.80 ns | 17,275.4 ns |  4.2419 | 0.5188 |   39944 B |
| SpanNumberParsing        | 10,022.7 ns |   454.39 ns | 1,266.65 ns |  9,713.6 ns |       - |      - |         - |
