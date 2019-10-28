using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(int[] multiples, int max)
    {
        int sum = 0;
        for (int i = max - 1; i >= 0; i--)
        {
            for (int j = 0; j < multiples.Length; j++)
                if (multiples[j] > 0 && i % multiples[j] == 0)
                {
                    sum += i;
                    break;
                }
        }
        return sum;
    }
}