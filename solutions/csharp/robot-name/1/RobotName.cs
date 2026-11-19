using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random RandomGenerator = new Random();
    private static readonly HashSet<string> AssignedNames = new HashSet<string>();

    private string? _name;

    public string Name
    {
        get
        {
            if (_name is null)
            {
                _name = GenerateUniqueName();
            }

            return _name;
        }
    }

    public void Reset()
    {
        if (_name is not null)
        {
            AssignedNames.Remove(_name);
            _name = null;
        }
    }

    private static string GenerateUniqueName()
    {
        while (true)
        {
            char letter1 = (char)RandomGenerator.Next('A', 'Z' + 1);
            char letter2 = (char)RandomGenerator.Next('A', 'Z' + 1);
            int digits = RandomGenerator.Next(0, 1000);

            string candidate = $"{letter1}{letter2}{digits:D3}";

            if (AssignedNames.Add(candidate))
            {
                return candidate;
            }
        }
    }
}