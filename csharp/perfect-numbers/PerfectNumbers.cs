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
        {
            throw new ArgumentOutOfRangeException();
        }

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            sum += GetDivisor(number, i);
        }

        if (sum == number)
        {
            return Classification.Perfect;
        }

        if (sum < number)
        {
            return Classification.Deficient;
        }

        return Classification.Abundant;

    }

    private static int GetDivisor(int number, int i)
    {
        if (number % i == 0)
        {
            return i;
        }

        return 0;
    }
}
