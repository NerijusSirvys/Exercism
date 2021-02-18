using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {

        int sum = 0;

        // loop through every number from max - 1 all the way to zero
        for (int i = max - 1; i >= 0; i--)
        {
            // check if number can be evenly devided by any of the multiples
            if (multiples.Where(x => x != 0).FirstOrDefault(x => i % x == 0) > 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}