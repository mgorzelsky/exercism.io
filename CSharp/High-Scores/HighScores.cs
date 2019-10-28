using System;
using System.Collections.Generic;
using System.Linq;
//Manage a game player's High Score list.

//Your task is to build a high-score component of the classic Frogger game, one of the highest selling and addictive games
//of all time, and a classic of the arcade era.Your task is to write methods that return the highest score from the list,
//the last added score and the three highest scores.
public class HighScores
{
    int[] arrayOfScores;
    List<int> listOfScores = new List<int>();
    public HighScores(List<int> list) => arrayOfScores = list.ToArray();

    public List<int> Scores()
    {
        foreach (int score in arrayOfScores)
            listOfScores.Add(score);
        return listOfScores;
    }

    public int Latest()
    {
        int latestScore = arrayOfScores[arrayOfScores.Length - 1];
        return latestScore;
    }

    public int PersonalBest()
    {
        Array.Sort(arrayOfScores);
        Array.Reverse(arrayOfScores);
        return arrayOfScores[0];
    }

    public List<int> PersonalTopThree()
    {
        List<int> topThreeScores = new List<int>();
        Array.Sort(arrayOfScores);
        Array.Reverse(arrayOfScores);
        if (arrayOfScores.Length > 2)
        {
            for (int i = 0; i < 3; i++)
                topThreeScores.Add(arrayOfScores[i]);
        }
        else
        {
            for (int i = 0; i < arrayOfScores.Length; i++)
                topThreeScores.Add(arrayOfScores[i]);
        }
        return topThreeScores;
    }
}