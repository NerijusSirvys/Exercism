using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (n == 1)
        {
            return 1;
        }
        else
        {
            return (ulong)Math.Pow(2, n - 1);
        }

    }

    public static ulong Total()
    {
        ulong total = 0;

        for (int i = 1; i < 65; i++)
        {
            total += Square(i);
        }

        return total;
    }
}