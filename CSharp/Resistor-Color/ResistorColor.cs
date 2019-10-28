using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] referenceColors = Colors();
        for (int i = 0; i < referenceColors.Length; i++)
        {
            if (referenceColors[i] == color)
                return i;
        }
        return 0;

        //switch (color)
        //{
        //    case ("black"):
        //        return 0;
        //    case ("brown"):
        //        return 1;
        //    case ("red"):
        //        return 2;
        //    case ("orange"):
        //        return 3;
        //    case ("yellow"):
        //        return 4;
        //    case ("green"):
        //        return 5;
        //    case ("blue"):
        //        return 6;
        //    case ("violet"):
        //        return 7;
        //    case ("grey"):
        //        return 8;
        //    case ("white"):
        //        return 9;
        //}
        //return 0;
    }

    public static string[] Colors()
    {
        string[] colorIndex = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colorIndex;
    }
}
//Black: 0
//Brown: 1
//Red: 2
//Orange: 3
//Yellow: 4
//Green: 5
//Blue: 6
//Violet: 7
//Grey: 8
//White: 9
