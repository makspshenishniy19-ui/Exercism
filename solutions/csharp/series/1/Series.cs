using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (string.IsNullOrEmpty(numbers))
            throw new ArgumentException("Input string cannot be null or empty.", nameof(numbers));

        if (sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException("Slice length must be between 1 and the length of the input string.", nameof(sliceLength));

        int count = numbers.Length - sliceLength + 1;
        string[] result = new string[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = numbers.Substring(i, sliceLength);
        }

        return result;
    }
}