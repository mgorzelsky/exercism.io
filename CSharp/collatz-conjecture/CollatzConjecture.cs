using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps =+ 1;
        if (number < 1)
            throw new ArgumentException("Value must be greater than zero.");
        //while (number > 1)
        //{
        //    number = number % 2 == 0 ? number / 2 : number * 3 + 1;
        //    steps++;
        //}

        //return steps;


        //Attempt at recursive solution...//

        else if (number == 1)
            return steps;
        else if (number % 2 == 0)
            return Steps(number / 2);
        else
            return Steps((3 * 1) + 1);
    }

    //private static int nIsEven(int n)
    //{
    //    return (n / 2);
    //}
    //private static int nIsOdd(int n)
    //{
    //    return ((3 * n) + 1);
    //}
}