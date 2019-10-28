using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        TimeSpan gigasecond = new TimeSpan(0, 0, 1_000_000_000);
        return moment + gigasecond;

    }
}