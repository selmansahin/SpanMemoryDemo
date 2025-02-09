namespace SpanMemoryDemo.Core;

public static class StringParsingExample
{
    // Traditional string parsing approach
    public static (string firstName, string lastName) ParseNameTraditional(string fullName)
    {
        var parts = fullName.Split(' ');
        return (parts[0], parts[1]);
    }

    // Span-based string parsing - more memory efficient
    public static (string firstName, string lastName) ParseNameWithSpan(ReadOnlySpan<char> fullName)
    {
        var spaceIndex = fullName.IndexOf(' ');
        if (spaceIndex == -1)
            throw new ArgumentException("Full name must contain a space");

        var firstName = fullName[..spaceIndex].ToString();
        fullName.Slice(spaceIndex + 1);
        var lastName = fullName.ToString();

        return (firstName, lastName);
    }

    // Example of parsing numbers without allocations
    public static bool TryParseNumbers(ReadOnlySpan<char> input, Span<int> numbers)
    {
        var currentIndex = 0;
        var numberStartIndex = 0;

        for (var i = 0; i < input.Length; i++)
            if (input[i] == ',' || i == input.Length - 1)
            {
                var numberSpan = i == input.Length - 1
                    ? input[numberStartIndex..]
                    : input.Slice(numberStartIndex, i - numberStartIndex);

                if (!int.TryParse(numberSpan, out numbers[currentIndex]))
                    return false;

                currentIndex++;
                numberStartIndex = i + 1;

                if (currentIndex >= numbers.Length)
                    return true;
            }

        return true;
    }
}