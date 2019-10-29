using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string numberAsString = number.ToString();
        List<int> numberAsList = new List<int>();
        foreach (char digit in numberAsString)
        {
            numberAsList.Add(Convert.ToInt32(digit.ToString()));
        }

        int total = 0;
        foreach (int digit in numberAsList)
            total += Convert.ToInt32(Math.Pow(digit, numberAsList.Count));
        if (total == number)
            return true;
        else
            return false;
    }
}