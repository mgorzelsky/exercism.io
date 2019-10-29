using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException("Number not within the number of squares on a chessboard.");
        ulong sum = 1;
        for (int i = 1; i < n; i++)
            sum *= 2;
        return sum;
    }

    public static ulong Total()
    {
        ulong sum = 0;
        for (int i = 1; i < 65; i++)
            sum += Square(i);
        return sum;
    }
}