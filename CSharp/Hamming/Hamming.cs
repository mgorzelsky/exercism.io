using System;
using System.Collections.Generic;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        firstStrand.ToLower();
        secondStrand.ToLower();
        char[] firstStrandArray = firstStrand.ToCharArray();
        char[] secondStrandArray = secondStrand.ToCharArray();
        int hamming = 0;

        if (firstStrandArray.Length != secondStrandArray.Length)
            throw new ArgumentException("The strands must be the same length.");

        for (int i = 0; i < firstStrandArray.Length; i++)
        {
            if (firstStrandArray[i] != secondStrandArray[i])
                hamming++;
        }
        return hamming;
    }
}