using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        for (char i = 'a'; i <= 'z'; i++)
            alphabet.Add(i, 0);

        foreach (char letter in input.ToLower())
        {
            alphabet[letter] = 1;
        }

        foreach (KeyValuePair<char, int> entry in alphabet)
        {
            if (entry.Value == 0)
                return false;
        }
        return true;

    }
}
