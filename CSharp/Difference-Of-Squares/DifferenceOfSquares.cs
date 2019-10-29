using System;
using System.Collections.Generic;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        int[] naturalNumbers = new int[max];
        for (int i = 1; i <= max; i++)
        {
            naturalNumbers[i - 1] = i;
        }
        foreach (int number in naturalNumbers)
            sum += number;

        return Convert.ToInt32(Math.Pow(sum, 2));
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        int[] naturalNumbers = new int[max];
        for (int i = 1; i <= max; i++)
        {
            naturalNumbers[i - 1] = i;
        }
        foreach (int number in naturalNumbers)
            sum += Convert.ToInt32(Math.Pow(number, 2));

        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}