using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] alphabetUpper = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] thingToEncrypt = text.ToCharArray();
        for (int i = 0; i < thingToEncrypt.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (alphabet[j] == thingToEncrypt[i])
                {
                    if (j + shiftKey > 25)
                    {
                        int wrappedShiftKey = 26 - (shiftKey + j);
                        if (wrappedShiftKey + j == 26)
                            thingToEncrypt[i] = (char)alphabet[0];
                        else
                            thingToEncrypt[i] = (char)alphabet[j + wrappedShiftKey];
                        break;
                    }
                    else
                    {
                        thingToEncrypt[i] = (char)alphabet[j + shiftKey];
                        break;
                    }
                }
                if (alphabetUpper[j] == thingToEncrypt[i])
                {
                    if (j + shiftKey > 25)
                    {
                        int wrappedShiftKey = 26 - shiftKey;
                        if (wrappedShiftKey + j == 26)
                            thingToEncrypt[i] = (char)alphabetUpper[0];
                        else
                            thingToEncrypt[i] = (char)alphabetUpper[j + wrappedShiftKey];
                    }
                    else
                        thingToEncrypt[i] = (char)alphabetUpper[j + shiftKey];
                    break;
                }
            }

        }
        string encyptedString = new string(thingToEncrypt);
        return encyptedString;
    }
}