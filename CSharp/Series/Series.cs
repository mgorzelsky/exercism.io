using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<char> numbersList = new List<char>();
        string[] slices;
        foreach (char number in numbers)
            numbersList.Add(number);

        if (sliceLength > numbersList.Count)
            throw new ArgumentException("You can't have a longer slice than the length of the string!");
        else if (sliceLength < 1)
            throw new ArgumentException("0 or negative are not valid slice amounts");
        else if (numbersList.Count == 0)
            throw new ArgumentException("An empty list can not have a slice take out of it!");
        else
        {
            int offset = numbersList.Count - sliceLength + 1;
            slices = new string[offset];
            for (int i = 0; i < offset; i++)
            {
                string tempString = "";
                for (int j = i; j < i + sliceLength; j++)
                {
                    tempString += numbersList[j];
                }
                if (i < slices.Length)
                    slices[i] = tempString;
            }
        }

        return slices;
    }
}