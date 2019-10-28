using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        int adenine = 0;
        int cytosine = 0;
        int guanine = 0;
        int thymine = 0;
        Dictionary<char, int> nucleotideCount = new Dictionary<char, int>();

        if (sequence.Length > 0)
        {
            foreach (char nucleotide in sequence)
            {
                if (nucleotide == 'A' || nucleotide == 'C' || nucleotide == 'G' || nucleotide == 'T')
                {
                    switch (nucleotide)
                    {
                        case ('A'):
                            adenine++;
                            break;
                        case ('C'):
                            cytosine++;
                            break;
                        case ('G'):
                            guanine++;
                            break;
                        case ('T'):
                            thymine++;
                            break;
                    }
                }
                else { throw new ArgumentException("DNA only contains A, C, G, or T."); }
            }
        }
        nucleotideCount.Add('A', adenine);
        nucleotideCount.Add('C', cytosine);
        nucleotideCount.Add('G', guanine);
        nucleotideCount.Add('T', thymine);

        return nucleotideCount;
    }
}