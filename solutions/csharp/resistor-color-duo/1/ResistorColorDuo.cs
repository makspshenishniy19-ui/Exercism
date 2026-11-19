using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        if (colors is null || colors.Length < 2)
            throw new ArgumentException("At least two colors are required.", nameof(colors));

        return GetColorValue(colors[0]) * 10 + GetColorValue(colors[1]);
    }

    private static int GetColorValue(string color)
    {
        return color.ToLowerInvariant() switch
        {
            "black" => 0,
            "brown" => 1,
            "red" => 2,
            "orange" => 3,
            "yellow" => 4,
            "green" => 5,
            "blue" => 6,
            "violet" => 7,
            "grey" => 8,
            "white" => 9,
            _ => throw new ArgumentException($"Unknown resistor color: {color}", nameof(color))
        };
    }
}