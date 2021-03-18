using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        if (sum <= 0) throw new ArgumentException();

        List<(int a, int b, int c)> output = new List<(int a, int b, int c)>();
        int usedSum = 0;

        for (int a = 0; a < sum / 3; a++)
        {
            for (int b = 0; b < sum / 2; b++)
            {
                int c = sum - a - b;

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    if (usedSum == c) break;

                    usedSum = c;

                    output.Add((a, b, c));
                }
            }
        }
        return output;
    }
}