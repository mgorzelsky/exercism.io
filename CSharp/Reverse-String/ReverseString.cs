using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] aString = new char[input.Length];
        int count = 0;
        foreach (char letter in input)
        {
            aString[count] = letter;
            count++;
        }

        Array.Reverse(aString);
        string reversedInput = new string(aString);
        return reversedInput;
    }
}