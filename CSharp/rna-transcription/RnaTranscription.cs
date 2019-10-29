using System;
using System.Text;

    //G -> C
    //C -> G
    //T -> A
    //A -> U

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        StringBuilder rna = new StringBuilder();
        foreach (char letter in nucleotide)
        {
            switch (letter)
            {
                case ('G'):
                    rna.Append('C');
                    break;
                case ('C'):
                    rna.Append('G');
                    break;
                case ('T'):
                    rna.Append('A');
                    break;
                case ('A'):
                    rna.Append('U');
                    break;
            }
        }
        return rna.ToString();
    }
}