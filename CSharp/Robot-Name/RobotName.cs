using System;
using System.Collections.Generic;

public class Robot
{
    Random rand = new Random();
    private string name;
    private static List<string> listOfNames = new List<string>();
    static HashSet<string> hashset = new HashSet<string>();
    public Robot()
    {
        Reset();
    }
    public string Name
    {
        get { return name; }
        private set { }
    }

    public void Reset()
    {
        bool tryAgain = true;
        bool isMatch = false;
        string tempName = null;

        while (tryAgain)                            
        {                                          
            string firstHalf = LetterGenerator();
            string secondHalf = NumberGenerator();
            tempName = firstHalf + secondHalf;

            foreach (var name in hashset)
                if (name == tempName)
                {
                    isMatch = true;
                    break;
                }
                else isMatch = false;

            if (!isMatch)
            {
                tryAgain = false;
            }
        }
        hashset.Add(tempName);
        name = tempName;
        //listOfNames.Add(name);
    }

    private string LetterGenerator()
    {
        string identifierOne;
        string identifierTwo;

        char randomLetter = (char)rand.Next('A', 'Z');
        identifierOne = randomLetter.ToString();
        randomLetter = (char)rand.Next('A', 'Z');
        identifierTwo = randomLetter.ToString();

        string identifiers = (identifierOne + identifierTwo);

        return identifiers;
    }
    private string NumberGenerator()
    {
        string numberIdentifier;
        int randomNumber = rand.Next(100, 1000);
        numberIdentifier = randomNumber.ToString();

        return numberIdentifier;
    }
}