using System;
using System.Collections.Generic;
// eggs - 1 : Peanuts - 2 : Shellfish - 4 : Strawberries - 8 : Tomatoes - 16 : Chocolate - 32 : Pollen - 64 : Cats - 128
public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    public Allergies(int mask)
    {
        allergiesNumber = Convert.ToString(mask, toBase: 2);
    }
    private string allergiesNumber;

    public bool IsAllergicTo(Allergen allergen)
    {
        foreach (Allergen a in List())
        {
            if (a == allergen)
                return true;
        }
        return false;
    }

    public Allergen[] List()
    {
        List<Allergen> allergicTo = new List<Allergen>();
        if (allergiesNumber.Length < 9)
        {
            for (int i = 0; allergiesNumber.Length < 8; i++)
            {
                allergiesNumber = 0 + allergiesNumber;
            }
        }
        if (allergiesNumber.Length > 8)
        {
            allergiesNumber = allergiesNumber.Substring(allergiesNumber.Length - 8);
        }
        for (int i = 0; i < allergiesNumber.Length; i++)
        {
            if (allergiesNumber[i] == '1')
            {
                switch (i)
                {
                    case (0):
                        allergicTo.Add(Allergen.Cats);
                        break;
                    case (1):
                        allergicTo.Add(Allergen.Pollen);
                        break;
                    case (2):
                        allergicTo.Add(Allergen.Chocolate);
                        break;
                    case (3):
                        allergicTo.Add(Allergen.Tomatoes);
                        break;
                    case (4):
                        allergicTo.Add(Allergen.Strawberries);
                        break;
                    case (5):
                        allergicTo.Add(Allergen.Shellfish);
                        break;
                    case (6):
                        allergicTo.Add(Allergen.Peanuts);
                        break;
                    case (7):
                        allergicTo.Add(Allergen.Eggs);
                        break;
                }
            }
        }
        Allergen[] allergies = new Allergen[allergicTo.Count];
        allergicTo.CopyTo(allergies);
        Array.Reverse(allergies);
        return allergies;
    }
}