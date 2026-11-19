using System;

public static class TwoFer
{
    public static string Speak(string? name = null)
    {
        string target = string.IsNullOrWhiteSpace(name) ? "you" : name;
        return $"One for {target}, one for me.";
    }
}