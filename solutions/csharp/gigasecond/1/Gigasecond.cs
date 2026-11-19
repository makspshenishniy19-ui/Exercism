using System;

public static class Gigasecond
{
    private const double GigasecondInSeconds = 1_000_000_000d;

    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(GigasecondInSeconds);
    }
}