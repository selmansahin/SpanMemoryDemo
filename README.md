# Span<T> ve Memory<T> Performans Demo Projesi
# Span<T> and Memory<T> Performance Demo Project

[TR]

Bu proje, .NET Core uygulamalarında `Span<T>` ve `Memory<T>` kullanımının performans avantajlarını göstermektedir. Bu tipler, diziler ve stringlerle çalışırken yüksek performanslı ve düşük bellek ayırma alternatifleri sunar.

## Benchmark Sonuçları

Benchmark sonuçlarına aşağıdaki bağlantılardan ulaşabilirsiniz:
- [HTML Raporu](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report.html)
- [CSV Raporu](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report.csv)
- [GitHub Markdown Raporu](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report-github.md)

## Proje Yapısı

- **SpanMemoryDemo.Core**: Geleneksel ve Span-tabanlı yaklaşımları gösteren örnek uygulamaları içerir
  - `StringParsingExample.cs`: Bellek ayırma yapmadan verimli string ayrıştırma örnekleri
  - `ArrayOperationsExample.cs`: Bellek açısından verimli dizi işlemleri

- **SpanMemoryDemo.Benchmarks**: Geleneksel ve Span-tabanlı yaklaşımların karşılaştırmalı performans testlerini içerir
  - `SpanBenchmarks.cs`: Çeşitli işlemler için karşılaştırmalı performans testleri

## Gösterilen Temel Özellikler

1. **String Ayrıştırma**
   - Geleneksel string bölme vs Span-tabanlı ayrıştırma
   - Stringlerden bellek-verimli sayı ayrıştırma

2. **Dizi İşlemleri**
   - Verimli dizi kopyalama
   - Stack-tabanlı dizi işlemleri
   - Bellek ayırma yapmadan dizi segment işlemleri

3. **Performans Testleri**
   - Bellek ayırma karşılaştırmaları
   - Çalışma süresi karşılaştırmaları

## Performans Testlerini Çalıştırma

1. Projeyi Release modunda derleyin
2. SpanMemoryDemo.Benchmarks dizinine gidin
3. Şu komutu çalıştırın: `dotnet run -c Release`

## Span<T> ve Memory<T>'nin Temel Faydaları

1. **Azaltılmış Bellek Ayırmaları**
   - Ayrıştırma sırasında string ayırmalarından kaçınma
   - Kopya oluşturmadan dizi segmentleriyle çalışma

2. **Geliştirilmiş Performans**
   - Daha az çöp toplama baskısı
   - Daha verimli bellek kullanımı
   - Daha iyi önbellek kullanımı

3. **Stack Ayırma**
   - Stack-ayrılmış dizilerle çalışabilme
   - Geçici tamponlar için heap ayırmalarından kaçınma

## En İyi Uygulamalar

1. Stack-only işlemler için `Span<T>` kullanın
2. Referansı saklamanız gerektiğinde `Memory<T>` kullanın
3. Veriyi değiştirmeniz gerekmediğinde `ReadOnlySpan<T>`'yi tercih edin
4. Küçük diziler için stack ayırmayı kullanın
5. String ayrıştırma işlemleri için `Span<T>` kullanmayı düşünün

## Kullanım Senaryoları

1. **Web API'lerde JSON Ayrıştırma**
   - Request/Response body'lerinin verimli işlenmesi
   - HTTP başlıklarının ayrıştırılması

2. **Dosya İşleme**
   - Büyük log dosyalarının ayrıştırılması
   - CSV dosyalarının işlenmesi

3. **Yüksek Performanslı Uygulamalar**
   - Gerçek zamanlı veri işleme
   - Yüksek trafik senaryoları
   - Mikroservis haberleşmeleri

---

[EN]

This project demonstrates the performance advantages of using `Span<T>` and `Memory<T>` in .NET Core applications. These types provide high-performance and low-allocation alternatives when working with arrays and strings.

## Benchmark Results

You can access the benchmark results through the following links:
- [HTML Report](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report.html)
- [CSV Report](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report.csv)
- [GitHub Markdown Report](BenchmarkDotNet.Artifacts/results/SpanMemoryDemo.Benchmarks.SpanBenchmarks-report-github.md)

## Project Structure

- **SpanMemoryDemo.Core**: Contains example implementations showing traditional and Span-based approaches
  - `StringParsingExample.cs`: Examples of efficient string parsing without allocations
  - `ArrayOperationsExample.cs`: Memory-efficient array operations

- **SpanMemoryDemo.Benchmarks**: Contains comparative performance tests of traditional and Span-based approaches
  - `SpanBenchmarks.cs`: Comparative performance tests for various operations

## Key Features Demonstrated

1. **String Parsing**
   - Traditional string splitting vs Span-based parsing
   - Memory-efficient number parsing from strings

2. **Array Operations**
   - Efficient array copying
   - Stack-based array operations
   - Array segment operations without allocations

3. **Performance Tests**
   - Memory allocation comparisons
   - Execution time comparisons

## Running Performance Tests

1. Build the project in Release mode
2. Navigate to SpanMemoryDemo.Benchmarks directory
3. Run the command: `dotnet run -c Release`

## Key Benefits of Span<T> and Memory<T>

1. **Reduced Memory Allocations**
   - Avoid string allocations during parsing
   - Work with array segments without creating copies

2. **Improved Performance**
   - Less garbage collection pressure
   - More efficient memory usage
   - Better cache utilization

3. **Stack Allocation**
   - Ability to work with stack-allocated arrays
   - Avoid heap allocations for temporary buffers

## Best Practices

1. Use `Span<T>` for stack-only operations
2. Use `Memory<T>` when you need to store the reference
3. Prefer `ReadOnlySpan<T>` when you don't need to modify the data
4. Use stack allocation for small arrays
5. Consider using `Span<T>` for string parsing operations

## Usage Scenarios

1. **JSON Parsing in Web APIs**
   - Efficient processing of request/response bodies
   - Parsing HTTP headers

2. **File Processing**
   - Parsing large log files
   - Processing CSV files

3. **High-Performance Applications**
   - Real-time data processing
   - High-traffic scenarios
   - Microservice communications
