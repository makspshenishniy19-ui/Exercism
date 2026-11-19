using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number < 0)
            return false;

        string digits = number.ToString();
        int power = digits.Length;
        long sum = 0;

        foreach (char digitChar in digits)
        {
            int digit = digitChar - '0';
            long term = 1;

            for (int i = 0; i < power; i++)
            {
                term *= digit;
            }

            sum += term;
        }

        return sum == number;
    }
}