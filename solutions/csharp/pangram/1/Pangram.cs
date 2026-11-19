using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        var letters = new HashSet<char>();

        foreach (char c in input)
        {
            char lower = char.ToLowerInvariant(c);
            if (lower is >= 'a' and <= 'z')
            {
                letters.Add(lower);
                if (letters.Count == 26)
                    return true;
            }
        }

        return letters.Count == 26;
    }
}