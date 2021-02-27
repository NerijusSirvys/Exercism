using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {

        if (numbers.Length < sliceLength) throw new ArgumentException();

        if (string.IsNullOrWhiteSpace(numbers)) throw new ArgumentException();

        if (sliceLength <= 0) throw new ArgumentException();

        if (numbers.Length == sliceLength) return new string[] { numbers };


        List<string> output = new List<string>();
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            output.Add(numbers.Substring(i, sliceLength));
        }

        return output.ToArray();
    }
}