using System;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        if (colors is null || colors.Length < 3)
            throw new ArgumentException("At least three colors are required.", nameof(colors));

        long baseValue = GetColorValue(colors[0]) * 10L + GetColorValue(colors[1]);
        int zeros = GetColorValue(colors[2]);

        long ohms = baseValue;
        for (int i = 0; i < zeros; i++)
        {
            ohms *= 10L;
        }

        if (ohms >= 1_000_000_000L)
            return $"{ohms / 1_000_000_000L} gigaohms";

        if (ohms >= 1_000_000L)
            return $"{ohms / 1_000_000L} megaohms";

        if (ohms >= 1_000L)
            return $"{ohms / 1_000L} kiloohms";

        return $"{ohms} ohms";
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