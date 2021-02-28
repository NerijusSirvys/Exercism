using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        ValidationCheck(digits, span);

        if (span == digits.Length) return CalculateLargestProduct(digits, 0);
        if (span == 0 && string.IsNullOrWhiteSpace(digits)) return 1;
        if (span == 0 && !string.IsNullOrWhiteSpace(digits)) return 1;


        int largestProduct = 0;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            if (!int.TryParse(digits.Substring(i, span), out _)) throw new ArgumentException();

            largestProduct = CalculateLargestProduct(digits.Substring(i, span), largestProduct);
        }

        return largestProduct;
    }

    private static void ValidationCheck(string digits, int span)
    {
        if (span > digits.Length) throw new ArgumentException();

        if (span < 0) throw new ArgumentException();
    }

    private static int CalculateLargestProduct(string input, int largestProduct)
    {
        int product = 1;
        foreach (var digit in input)
        {
            product *= int.Parse(digit.ToString());
        }

        return product > largestProduct ? product : largestProduct;
    }
}