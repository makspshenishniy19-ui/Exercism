public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix = GetOrdinalSuffix(number);
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }

    private static string GetOrdinalSuffix(int number)
    {
        int lastTwoDigits = number % 100;
        if (lastTwoDigits is 11 or 12 or 13)
        {
            return "th";
        }

        return (number % 10) switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th"
        };
    }
}