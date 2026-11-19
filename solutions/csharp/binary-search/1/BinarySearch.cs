using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if (input is null || input.Length == 0)
            return -1;

        int left = 0;
        int right = input.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = input[mid];

            if (midValue == value)
                return mid;

            if (midValue > value)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}