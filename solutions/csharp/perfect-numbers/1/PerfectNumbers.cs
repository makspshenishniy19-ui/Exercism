using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a positive integer.");

        int aliquotSum = CalculateAliquotSum(number);

        if (aliquotSum == number)
            return Classification.Perfect;

        if (aliquotSum > number)
            return Classification.Abundant;

        return Classification.Deficient;
    }

    private static int CalculateAliquotSum(int number)
    {
        if (number == 1)
            return 0;

        int sum = 1;
        int limit = (int)Math.Sqrt(number);

        for (int divisor = 2; divisor <= limit; divisor++)
        {
            if (number % divisor == 0)
            {
                sum += divisor;
                int pairDivisor = number / divisor;
                if (pairDivisor != divisor)
                {
                    sum += pairDivisor;
                }
            }
        }

        return sum;
    }
}