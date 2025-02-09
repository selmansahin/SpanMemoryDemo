namespace SpanMemoryDemo.Core;

public static class ArrayOperationsExample
{
    // Traditional array copy
    public static void CopyArrayTraditional(byte[] source, byte[] destination)
    {
        Array.Copy(source, destination, source.Length);
    }

    // Span-based array copy - more efficient
    public static void CopyArrayWithSpan(ReadOnlySpan<byte> source, Span<byte> destination)
    {
        source.CopyTo(destination);
    }

    // Example of working with array segments without allocation
    public static int SumArray(ReadOnlySpan<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers) sum += number;
        return sum;
    }

    // Example of efficient array reversal
    public static void ReverseArray(Span<int> array)
    {
        array.Reverse();
    }

    // Example of working with stack-allocated arrays
    public static (int min, int max) FindMinMax(ReadOnlySpan<int> numbers)
    {
        if (numbers.IsEmpty)
            throw new ArgumentException("Array cannot be empty");

        var min = numbers[0];
        var max = numbers[0];

        foreach (var number in numbers.Slice(1))
        {
            if (number < min) min = number;
            if (number > max) max = number;
        }

        return (min, max);
    }
}